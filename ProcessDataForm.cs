namespace CR
{
    public partial class ProcessDataForm : Form
    {
        public ProcessDataForm()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string faculty = txtFaculty.Text.Trim();
            string? studyBasis = cmbStudyBasis.SelectedItem?.ToString();
            string? sortBy = cmbSortBy.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(faculty))
            {
                MessageBox.Show("Введите факультет для отбора!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT * FROM Students WHERE Faculty LIKE @faculty";

            var parameters = new Dictionary<string, object>
            {
                { "@faculty", $"%{faculty}%" }
            };

            if (!string.IsNullOrEmpty(studyBasis) && studyBasis != "Все")
            {
                query += " AND StudyBasis = @studyBasis";
                parameters.Add("@studyBasis", studyBasis);
            }

            if (sortBy == "По ФИО")
                query += " ORDER BY FullName";
            else if (sortBy == "По дате рождения")
                query += " ORDER BY BirthDate";
            else if (sortBy == "По № студ. билета")
                query += " ORDER BY StudentId";
            else
                query += " ORDER BY FullName";

            ResultForm resultForm = new ResultForm("Результат обработки", query, false, parameters);
            resultForm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}