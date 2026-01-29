namespace CR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DatabaseHelper.InitializeDatabase();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtLoginUsername.Text.Trim();
            string password = txtLoginPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user = DatabaseHelper.AuthenticateUser(username, password);

            if (user != null)
            {
                this.Hide();
                MainForm mainForm = new(user);
                mainForm.ShowDialog();
                this.Show();
                txtLoginPassword.Clear();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtRegisterUsername.Text.Trim();
            string password = txtRegisterPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DatabaseHelper.RegisterUser(username, password, out string errorMessage))
            {
                MessageBox.Show("Регистрация успеха! Вы можете войти с ролью 'Гость'.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRegisterUsername.Clear();
                txtRegisterPassword.Clear();
                tabControl1.SelectedTab = tabLogin;
            }
            else
            {
                MessageBox.Show(errorMessage, "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
