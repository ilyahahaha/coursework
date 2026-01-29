namespace CR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabLogin = new TabPage();
            btnLogin = new Button();
            txtLoginPassword = new TextBox();
            txtLoginUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabRegister = new TabPage();
            btnRegister = new Button();
            txtRegisterPassword = new TextBox();
            txtRegisterUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabLogin.SuspendLayout();
            tabRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabLogin);
            tabControl1.Controls.Add(tabRegister);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(400, 250);
            tabControl1.TabIndex = 0;
            // 
            // tabLogin
            // 
            tabLogin.Controls.Add(btnLogin);
            tabLogin.Controls.Add(txtLoginPassword);
            tabLogin.Controls.Add(txtLoginUsername);
            tabLogin.Controls.Add(label2);
            tabLogin.Controls.Add(label1);
            tabLogin.Location = new Point(4, 29);
            tabLogin.Name = "tabLogin";
            tabLogin.Padding = new Padding(3);
            tabLogin.Size = new Size(392, 217);
            tabLogin.TabIndex = 0;
            tabLogin.Text = "Авторизация";
            tabLogin.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(135, 150);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 35);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(135, 95);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PasswordChar = '*';
            txtLoginPassword.Size = new Size(200, 27);
            txtLoginPassword.TabIndex = 3;
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Location = new Point(135, 50);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.Size = new Size(200, 27);
            txtLoginUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 98);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Пароль:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 53);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Логин:";
            // 
            // tabRegister
            // 
            tabRegister.Controls.Add(btnRegister);
            tabRegister.Controls.Add(txtRegisterPassword);
            tabRegister.Controls.Add(txtRegisterUsername);
            tabRegister.Controls.Add(label4);
            tabRegister.Controls.Add(label3);
            tabRegister.Location = new Point(4, 29);
            tabRegister.Name = "tabRegister";
            tabRegister.Padding = new Padding(3);
            tabRegister.Size = new Size(392, 217);
            tabRegister.TabIndex = 1;
            tabRegister.Text = "Регистрация";
            tabRegister.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(135, 150);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 35);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Зарегистрироваться";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.Location = new Point(135, 95);
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.PasswordChar = '*';
            txtRegisterPassword.Size = new Size(200, 27);
            txtRegisterPassword.TabIndex = 3;
            // 
            // txtRegisterUsername
            // 
            txtRegisterUsername.Location = new Point(135, 50);
            txtRegisterUsername.Name = "txtRegisterUsername";
            txtRegisterUsername.Size = new Size(200, 27);
            txtRegisterUsername.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 98);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 1;
            label4.Text = "Пароль:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 53);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 0;
            label3.Text = "Логин:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 250);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            tabControl1.ResumeLayout(false);
            tabLogin.ResumeLayout(false);
            tabLogin.PerformLayout();
            tabRegister.ResumeLayout(false);
            tabRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabLogin;
        private TabPage tabRegister;
        private Label label1;
        private Label label2;
        private TextBox txtLoginUsername;
        private TextBox txtLoginPassword;
        private Button btnLogin;
        private Label label3;
        private Label label4;
        private TextBox txtRegisterUsername;
        private TextBox txtRegisterPassword;
        private Button btnRegister;
    }
}
