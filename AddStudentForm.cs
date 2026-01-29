using System.Data.SQLite;

namespace CR
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string studentId = txtStudentId.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            DateTime birthDate = dtpBirthDate.Value;
            string? gender = cmbGender.SelectedItem?.ToString();
            string? studyBasis = cmbStudyBasis.SelectedItem?.ToString();
            string faculty = txtFaculty.Text.Trim();
            string specialty = txtSpecialty.Text.Trim();

            if (string.IsNullOrEmpty(studentId) || string.IsNullOrEmpty(fullName) ||
                string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(studyBasis) ||
                string.IsNullOrEmpty(faculty) || string.IsNullOrEmpty(specialty))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (birthDate > DateTime.Now.AddYears(-16))
            {
                MessageBox.Show("Студент должен быть старше 16 лет!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    string query = @"INSERT INTO Students (StudentId, FullName, BirthDate, Gender, StudyBasis, Faculty, Specialty) 
                                   VALUES (@studentId, @fullName, @birthDate, @gender, @studyBasis, @faculty, @specialty)";

                    using var cmd = new SQLiteCommand(query, connection);
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    cmd.Parameters.AddWithValue("@fullName", fullName);
                    cmd.Parameters.AddWithValue("@birthDate", birthDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@studyBasis", studyBasis);
                    cmd.Parameters.AddWithValue("@faculty", faculty);
                    cmd.Parameters.AddWithValue("@specialty", specialty);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Студент успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (SQLiteException ex)
            {
                if (ex.Message.Contains("UNIQUE"))
                {
                    MessageBox.Show("Студент с таким номером студенческого билета уже существует!", 
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ошибка добавления: " + ex.Message, "Ошибка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}