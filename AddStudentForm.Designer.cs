namespace CR
{
    partial class AddStudentForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtStudentId = new TextBox();
            txtFullName = new TextBox();
            txtFaculty = new TextBox();
            txtSpecialty = new TextBox();
            dtpBirthDate = new DateTimePicker();
            cmbGender = new ComboBox();
            cmbStudyBasis = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(177, 20);
            label1.TabIndex = 0;
            label1.Text = "№ Студенческого билета:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 70);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "ФИО:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 110);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 2;
            label3.Text = "Дата рождения:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 150);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 3;
            label4.Text = "Пол:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 190);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 4;
            label5.Text = "Основа обучения:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 230);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 5;
            label6.Text = "Факультет:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 270);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 6;
            label7.Text = "Специальность:";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(220, 27);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(250, 27);
            txtStudentId.TabIndex = 7;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(220, 67);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(250, 27);
            txtFullName.TabIndex = 8;
            // 
            // txtFaculty
            // 
            txtFaculty.Location = new Point(220, 227);
            txtFaculty.Name = "txtFaculty";
            txtFaculty.Size = new Size(250, 27);
            txtFaculty.TabIndex = 9;
            // 
            // txtSpecialty
            // 
            txtSpecialty.Location = new Point(220, 267);
            txtSpecialty.Name = "txtSpecialty";
            txtSpecialty.Size = new Size(250, 27);
            txtSpecialty.TabIndex = 10;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(220, 107);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(250, 27);
            dtpBirthDate.TabIndex = 11;
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Мужской", "Женский" });
            cmbGender.Location = new Point(220, 147);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(250, 28);
            cmbGender.TabIndex = 12;
            // 
            // cmbStudyBasis
            // 
            cmbStudyBasis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudyBasis.FormattingEnabled = true;
            cmbStudyBasis.Items.AddRange(new object[] { "Бюджет", "Договор" });
            cmbStudyBasis.Location = new Point(220, 187);
            cmbStudyBasis.Name = "cmbStudyBasis";
            cmbStudyBasis.Size = new Size(250, 28);
            cmbStudyBasis.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(150, 330);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 35);
            btnSave.TabIndex = 14;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(290, 330);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 35);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 400);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbStudyBasis);
            Controls.Add(cmbGender);
            Controls.Add(dtpBirthDate);
            Controls.Add(txtSpecialty);
            Controls.Add(txtFaculty);
            Controls.Add(txtFullName);
            Controls.Add(txtStudentId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddStudentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление студента";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtStudentId;
        private TextBox txtFullName;
        private TextBox txtFaculty;
        private TextBox txtSpecialty;
        private DateTimePicker dtpBirthDate;
        private ComboBox cmbGender;
        private ComboBox cmbStudyBasis;
        private Button btnSave;
        private Button btnCancel;
    }
}