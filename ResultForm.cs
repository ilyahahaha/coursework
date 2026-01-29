using System.Data;
using System.Data.SQLite;

namespace CR
{
    public partial class ResultForm : Form
    {
        private string _query;
        private bool _allowEdit;
        private Dictionary<string, object> _parameters;

        public ResultForm(string title, string sqlQuery, bool allowEditing, Dictionary<string, object>? queryParams = null)
        {
            InitializeComponent();
            this.Text = title;
            _query = sqlQuery;
            _allowEdit = allowEditing;
            _parameters = queryParams;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(_query, connection))
                    {
                        if (_parameters != null)
                        {
                            foreach (var param in _parameters)
                            {
                                if (param.Value != null && param.Value.ToString() != "Все")
                                {
                                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                                }
                            }
                        }

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                        dataGridView1.ReadOnly = !_allowEdit;
                        
                        if (!_allowEdit)
                        {
                            btnDelete.Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message, "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_allowEdit && dataGridView1.DataSource is DataTable dt && dt.GetChanges() != null)
            {
                SaveChanges(dt);
            }
            this.Close();
        }

        private void SaveChanges(DataTable dt)
        {
            try
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row.RowState == DataRowState.Modified)
                        {
                            string updateQuery = @"UPDATE Students SET 
                                StudentId = @studentId, 
                                FullName = @fullName, 
                                BirthDate = @birthDate,
                                Gender = @gender, 
                                StudyBasis = @studyBasis, 
                                Faculty = @faculty, 
                                Specialty = @specialty 
                                WHERE Id = @id";

                            using (var cmd = new SQLiteCommand(updateQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@id", row["Id"]);
                                cmd.Parameters.AddWithValue("@studentId", row["StudentId"]);
                                cmd.Parameters.AddWithValue("@fullName", row["FullName"]);
                                cmd.Parameters.AddWithValue("@birthDate", row["BirthDate"]);
                                cmd.Parameters.AddWithValue("@gender", row["Gender"]);
                                cmd.Parameters.AddWithValue("@studyBasis", row["StudyBasis"]);
                                cmd.Parameters.AddWithValue("@faculty", row["Faculty"]);
                                cmd.Parameters.AddWithValue("@specialty", row["Specialty"]);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                MessageBox.Show("Изменения сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message, "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись для удаления!", "Предупреждение", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?", 
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                    
                    using (var connection = DatabaseHelper.GetConnection())
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM Students WHERE Id = @id";
                        using (var cmd = new SQLiteCommand(deleteQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Запись удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления: " + ex.Message, "Ошибка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}