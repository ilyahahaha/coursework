using System.Data;

namespace CR
{
    public partial class MainForm : Form
    {
        private User currentUser;

        public MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            ConfigureAccessByRole();
        }

        private void ConfigureAccessByRole()
        {
            if (currentUser.Role == "Гость")
            {
                btnAddStudent.Enabled = false;
                btnProcessData.Enabled = false;
                btnManageUsers.Enabled = false;
            }
            else if (currentUser.Role == "Пользователь")
            {
                btnAddStudent.Enabled = true;
                btnProcessData.Enabled = true;
                btnManageUsers.Enabled = false;
            }
            else if (currentUser.Role == "Администратор")
            {
                btnAddStudent.Enabled = true;
                btnProcessData.Enabled = true;
                btnManageUsers.Enabled = true;
            }
        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm("Список студентов", 
                "SELECT * FROM Students ORDER BY FullName", 
                currentUser.Role == "Администратор");
            resultForm.ShowDialog();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addForm = new AddStudentForm();
            addForm.ShowDialog();
        }

        private void btnProcessData_Click(object sender, EventArgs e)
        {
            ProcessDataForm processForm = new ProcessDataForm();
            processForm.ShowDialog();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm("Список пользователей", 
                "SELECT Id, Username, Role FROM Users ORDER BY Username", 
                false);
            resultForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}