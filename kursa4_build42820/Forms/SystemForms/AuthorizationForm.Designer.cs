namespace kursa4_build42820.Forms.SystemForms
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.WorkerLabel = new System.Windows.Forms.Label();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.ExceptionLabel = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.UserPic = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).BeginInit();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.WorkerLabel);
            this.MainPanel.Controls.Add(this.RegistrationButton);
            this.MainPanel.Controls.Add(this.ExceptionLabel);
            this.MainPanel.Controls.Add(this.SignInButton);
            this.MainPanel.Controls.Add(this.PasswordLabel);
            this.MainPanel.Controls.Add(this.LoginLabel);
            this.MainPanel.Controls.Add(this.PasswordTextBox);
            this.MainPanel.Controls.Add(this.LoginTextBox);
            this.MainPanel.Controls.Add(this.UserPic);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.Location = new System.Drawing.Point(0, 30);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(450, 320);
            this.MainPanel.TabIndex = 10;
            // 
            // WorkerLabel
            // 
            this.WorkerLabel.AutoSize = true;
            this.WorkerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WorkerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkerLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.WorkerLabel.Location = new System.Drawing.Point(140, 285);
            this.WorkerLabel.Name = "WorkerLabel";
            this.WorkerLabel.Size = new System.Drawing.Size(101, 17);
            this.WorkerLabel.TabIndex = 5;
            this.WorkerLabel.Text = "Вы работник?";
            this.WorkerLabel.Click += new System.EventHandler(this.WorkerLabel_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationButton.Location = new System.Drawing.Point(12, 278);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(109, 30);
            this.RegistrationButton.TabIndex = 4;
            this.RegistrationButton.Text = "Регистрация";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // ExceptionLabel
            // 
            this.ExceptionLabel.AutoSize = true;
            this.ExceptionLabel.ForeColor = System.Drawing.Color.Red;
            this.ExceptionLabel.Location = new System.Drawing.Point(9, 150);
            this.ExceptionLabel.Name = "ExceptionLabel";
            this.ExceptionLabel.Size = new System.Drawing.Size(69, 17);
            this.ExceptionLabel.TabIndex = 8;
            this.ExceptionLabel.Text = "Exception";
            this.ExceptionLabel.Visible = false;
            // 
            // SignInButton
            // 
            this.SignInButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInButton.Location = new System.Drawing.Point(363, 278);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(75, 30);
            this.SignInButton.TabIndex = 3;
            this.SignInButton.Text = "Войти";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(9, 100);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(61, 17);
            this.PasswordLabel.TabIndex = 13;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(9, 50);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(51, 17);
            this.LoginLabel.TabIndex = 12;
            this.LoginLabel.Text = "Логин:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Location = new System.Drawing.Point(94, 100);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(220, 22);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginTextBox.Location = new System.Drawing.Point(94, 50);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(220, 22);
            this.LoginTextBox.TabIndex = 1;
            // 
            // UserPic
            // 
            this.UserPic.Image = ((System.Drawing.Image)(resources.GetObject("UserPic.Image")));
            this.UserPic.Location = new System.Drawing.Point(355, 8);
            this.UserPic.Name = "UserPic";
            this.UserPic.Size = new System.Drawing.Size(64, 64);
            this.UserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UserPic.TabIndex = 1;
            this.UserPic.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(272, 25);
            this.TitleLabel.TabIndex = 9;
            this.TitleLabel.Text = "Авторизация пользователя";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(418, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 28);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TitlePanel
            // 
            this.TitlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitlePanel.Controls.Add(this.MinimizeButton);
            this.TitlePanel.Controls.Add(this.ExitButton);
            this.TitlePanel.Controls.Add(this.TitleLabel);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(450, 30);
            this.TitlePanel.TabIndex = 11;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.TitlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(388, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 28);
            this.MinimizeButton.TabIndex = 6;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно Авторизации";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).EndInit();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox UserPic;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ExceptionLabel;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Label WorkerLabel;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Button MinimizeButton;
    }
}