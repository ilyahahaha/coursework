using Konscious.Security.Cryptography;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;

namespace CR
{
    public class DatabaseHelper
    {
        private static string connectionString = "Data Source=students.db;Version=3;";

        public static void InitializeDatabase()
        {
            if (!File.Exists("students.db"))
            {
                SQLiteConnection.CreateFile("students.db");
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createUsersTable = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT UNIQUE NOT NULL,
                        Password TEXT NOT NULL,
                        Role TEXT NOT NULL
                    )";

                string createStudentsTable = @"
                    CREATE TABLE IF NOT EXISTS Students (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentId TEXT UNIQUE NOT NULL,
                        FullName TEXT NOT NULL,
                        BirthDate TEXT NOT NULL,
                        Gender TEXT NOT NULL,
                        StudyBasis TEXT NOT NULL,
                        Faculty TEXT NOT NULL,
                        Specialty TEXT NOT NULL
                    )";

                using (var cmd = new SQLiteCommand(createUsersTable, connection))
                {
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new SQLiteCommand(createStudentsTable, connection))
                {
                    cmd.ExecuteNonQuery();
                }

                string checkUsers = "SELECT COUNT(*) FROM Users";
                using (var cmd = new SQLiteCommand(checkUsers, connection))
                {
                    long count = (long)cmd.ExecuteScalar();
                    if (count == 0)
                    {
                        InsertDefaultUsers(connection);
                        InsertDefaultStudents(connection);
                    }
                }
            }
        }

        private static void InsertDefaultUsers(SQLiteConnection connection)
        {
            string[] users = {
                $"INSERT INTO Users (Username, Password, Role) VALUES ('admin', '{HashPassword("admin123")}', 'Администратор')",
                $"INSERT INTO Users (Username, Password, Role) VALUES ('user', '{HashPassword("user123")}', 'Пользователь')",
                $"INSERT INTO Users (Username, Password, Role) VALUES ('guest', '{HashPassword("guest123")}', 'Гость')"
            };

            foreach (var query in users)
            {
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static void InsertDefaultStudents(SQLiteConnection connection)
        {
            string[] students = {
                "INSERT INTO Students (StudentId, FullName, BirthDate, Gender, StudyBasis, Faculty, Specialty) VALUES ('2021001', 'Иванов Иван Иванович', '2003-05-15', 'Мужской', 'Бюджет', 'ИТ', 'Программирование')",
                "INSERT INTO Students (StudentId, FullName, BirthDate, Gender, StudyBasis, Faculty, Specialty) VALUES ('2021002', 'Петрова Мария Сергеевна', '2003-08-20', 'Женский', 'Договор', 'ИТ', 'Информационные системы')",
                "INSERT INTO Students (StudentId, FullName, BirthDate, Gender, StudyBasis, Faculty, Specialty) VALUES ('2021003', 'Сидоров Петр Алексеевич', '2002-12-10', 'Мужской', 'Бюджет', 'Экономика', 'Финансы')",
                "INSERT INTO Students (StudentId, FullName, BirthDate, Gender, StudyBasis, Faculty, Specialty) VALUES ('2021004', 'Смирнова Анна Викторовна', '2003-03-25', 'Женский', 'Бюджет', 'ИТ', 'Программирование')",
                "INSERT INTO Students (StudentId, FullName, BirthDate, Gender, StudyBasis, Faculty, Specialty) VALUES ('2021005', 'Козлов Дмитрий Николаевич', '2003-07-18', 'Мужской', 'Договор', 'Право', 'Юриспруденция')",
                "INSERT INTO Students (StudentId, FullName, BirthDate, Gender, StudyBasis, Faculty, Specialty) VALUES ('2021006', 'Новикова Елена Павловна', '2002-11-05', 'Женский', 'Бюджет', 'Медицина', 'Лечебное дело')",
                "INSERT INTO Students (StudentId, FullName, BirthDate, Gender, StudyBasis, Faculty, Specialty) VALUES ('2021007', 'Морозов Александр Игоревич', '2003-01-30', 'Мужской', 'Бюджет', 'ИТ', 'Информационные системы')",
                "INSERT INTO Students (StudentId, FullName, BirthDate, Gender, StudyBasis, Faculty, Specialty) VALUES ('2021008', 'Волкова Ольга Дмитриевна', '2003-06-12', 'Женский', 'Договор', 'Экономика', 'Менеджмент')",
                "INSERT INTO Students (StudentId, FullName, BirthDate, Gender, StudyBasis, Faculty, Specialty) VALUES ('2021009', 'Соколов Андрей Владимирович', '2002-09-22', 'Мужской', 'Бюджет', 'Техника', 'Машиностроение')",
                "INSERT INTO Students (StudentId, FullName, BirthDate, Gender, StudyBasis, Faculty, Specialty) VALUES ('2021010', 'Лебедева Татьяна Сергеевна', '2003-04-08', 'Женский', 'Договор', 'ИТ', 'Программирование')"
            };

            foreach (var query in students)
            {
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static string HashPassword(string password)
        {
            byte[] salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            using (var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password)))
            {
                argon2.Salt = salt;
                argon2.DegreeOfParallelism = 8;
                argon2.MemorySize = 65536;
                argon2.Iterations = 4;

                byte[] hash = argon2.GetBytes(32);

                byte[] hashWithSalt = new byte[salt.Length + hash.Length];
                Buffer.BlockCopy(salt, 0, hashWithSalt, 0, salt.Length);
                Buffer.BlockCopy(hash, 0, hashWithSalt, salt.Length, hash.Length);

                return Convert.ToBase64String(hashWithSalt);
            }
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            try
            {
                byte[] hashWithSalt = Convert.FromBase64String(hashedPassword);

                byte[] salt = new byte[16];
                Buffer.BlockCopy(hashWithSalt, 0, salt, 0, 16);

                byte[] hash = new byte[hashWithSalt.Length - 16];
                Buffer.BlockCopy(hashWithSalt, 16, hash, 0, hash.Length);

                using (var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password)))
                {
                    argon2.Salt = salt;
                    argon2.DegreeOfParallelism = 8;
                    argon2.MemorySize = 65536;
                    argon2.Iterations = 4;

                    byte[] newHash = argon2.GetBytes(32);

                    return hash.SequenceEqual(newHash);
                }
            }
            catch
            {
                return false;
            }
        }

        public static User? AuthenticateUser(string username, string password)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id, Username, Password, Role FROM Users WHERE Username = @username";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader.GetString(2);

                            if (VerifyPassword(password, storedHash))
                            {
                                return new User
                                {
                                    Id = reader.GetInt32(0),
                                    Username = reader.GetString(1),
                                    Role = reader.GetString(3)
                                };
                            }
                        }
                    }
                }
            }
            return null;
        }

        public static bool RegisterUser(string username, string password, out string errorMessage)
        {
            errorMessage = "";

            if (username.Length < 3)
            {
                errorMessage = "Имя пользователя должно содержать минимум 3 символа";
                return false;
            }

            if (password.Length < 6)
            {
                errorMessage = "Пароль должен содержать минимум 6 символов";
                return false;
            }

            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string hashedPassword = HashPassword(password);
                    string query = "INSERT INTO Users (Username, Password, Role) VALUES (@username, @password, 'Гость')";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SQLiteException ex)
            {
                if (ex.Message.Contains("UNIQUE"))
                {
                    errorMessage = "Пользователь с таким именем уже существует";
                }
                else
                {
                    errorMessage = "Ошибка регистрации: " + ex.Message;
                }
                return false;
            }
        }

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }
    }
}