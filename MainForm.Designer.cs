namespace CR
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnViewStudents = new Button();
            btnAddStudent = new Button();
            btnProcessData = new Button();
            btnManageUsers = new Button();
            btnExit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnViewStudents
            // 
            btnViewStudents.Location = new Point(81, 128);
            btnViewStudents.Margin = new Padding(5, 5, 5, 5);
            btnViewStudents.Name = "btnViewStudents";
            btnViewStudents.Size = new Size(488, 64);
            btnViewStudents.TabIndex = 0;
            btnViewStudents.Text = "Просмотр списка студентов";
            btnViewStudents.UseVisualStyleBackColor = true;
            btnViewStudents.Click += btnViewStudents_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(81, 224);
            btnAddStudent.Margin = new Padding(5, 5, 5, 5);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(488, 64);
            btnAddStudent.TabIndex = 1;
            btnAddStudent.Text = "Добавить студента";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnProcessData
            // 
            btnProcessData.Location = new Point(81, 320);
            btnProcessData.Margin = new Padding(5, 5, 5, 5);
            btnProcessData.Name = "btnProcessData";
            btnProcessData.Size = new Size(488, 64);
            btnProcessData.TabIndex = 2;
            btnProcessData.Text = "Обработка данных";
            btnProcessData.UseVisualStyleBackColor = true;
            btnProcessData.Click += btnProcessData_Click;
            // 
            // btnManageUsers
            // 
            btnManageUsers.Location = new Point(81, 416);
            btnManageUsers.Margin = new Padding(5, 5, 5, 5);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(488, 64);
            btnManageUsers.TabIndex = 3;
            btnManageUsers.Text = "Управление пользователями";
            btnManageUsers.UseVisualStyleBackColor = true;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(81, 512);
            btnExit.Margin = new Padding(5, 5, 5, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(488, 64);
            btnExit.TabIndex = 4;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(81, 48);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(246, 45);
            label1.TabIndex = 5;
            label1.Text = "Главное меню";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 640);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnManageUsers);
            Controls.Add(btnProcessData);
            Controls.Add(btnAddStudent);
            Controls.Add(btnViewStudents);
            Margin = new Padding(5, 5, 5, 5);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Кучменко Илья Владимирович, ЭБЦД-211";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnViewStudents;
        private Button btnAddStudent;
        private Button btnProcessData;
        private Button btnManageUsers;
        private Button btnExit;
        private Label label1;
    }
}