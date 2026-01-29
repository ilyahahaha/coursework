namespace CR
{
    partial class ProcessDataForm
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
            txtFaculty = new TextBox();
            cmbStudyBasis = new ComboBox();
            cmbSortBy = new ComboBox();
            btnProcess = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Факультет:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 70);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 1;
            label2.Text = "Основа обучения:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 110);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "Сортировать по:";
            // 
            // txtFaculty
            // 
            txtFaculty.Location = new Point(170, 27);
            txtFaculty.Name = "txtFaculty";
            txtFaculty.Size = new Size(250, 27);
            txtFaculty.TabIndex = 3;
            // 
            // cmbStudyBasis
            // 
            cmbStudyBasis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudyBasis.FormattingEnabled = true;
            cmbStudyBasis.Items.AddRange(new object[] { "Все", "Бюджет", "Договор" });
            cmbStudyBasis.Location = new Point(170, 67);
            cmbStudyBasis.Name = "cmbStudyBasis";
            cmbStudyBasis.Size = new Size(250, 28);
            cmbStudyBasis.TabIndex = 4;
            cmbStudyBasis.SelectedIndex = 0;
            // 
            // cmbSortBy
            // 
            cmbSortBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSortBy.FormattingEnabled = true;
            cmbSortBy.Items.AddRange(new object[] { "По ФИО", "По дате рождения", "По № студ. билета" });
            cmbSortBy.Location = new Point(170, 107);
            cmbSortBy.Name = "cmbSortBy";
            cmbSortBy.Size = new Size(250, 28);
            cmbSortBy.TabIndex = 5;
            cmbSortBy.SelectedIndex = 0;
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(130, 170);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(120, 35);
            btnProcess.TabIndex = 6;
            btnProcess.Text = "Обработать";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(270, 170);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 35);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ProcessDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 240);
            Controls.Add(btnCancel);
            Controls.Add(btnProcess);
            Controls.Add(cmbSortBy);
            Controls.Add(cmbStudyBasis);
            Controls.Add(txtFaculty);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProcessDataForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Обработка данных";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFaculty;
        private ComboBox cmbStudyBasis;
        private ComboBox cmbSortBy;
        private Button btnProcess;
        private Button btnCancel;
    }
}