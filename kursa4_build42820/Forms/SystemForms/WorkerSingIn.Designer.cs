namespace kursa4_build42820.Forms.SystemForms
{
    partial class WorkerSingIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerSingIn));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.HintLabel = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.ExceptionLabel = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.WorkerTextBox = new System.Windows.Forms.TextBox();
            this.UserPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.MainPanel.Controls.Add(this.HintLabel);
            this.MainPanel.Controls.Add(this.ReturnButton);
            this.MainPanel.Controls.Add(this.ExceptionLabel);
            this.MainPanel.Controls.Add(this.SignInButton);
            this.MainPanel.Controls.Add(this.WorkerTextBox);
            this.MainPanel.Controls.Add(this.UserPic);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.Location = new System.Drawing.Point(0, 30);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(350, 220);
            this.MainPanel.TabIndex = 9;
            // 
            // HintLabel
            // 
            this.HintLabel.AutoSize = true;
            this.HintLabel.Location = new System.Drawing.Point(9, 88);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HintLabel.Size = new System.Drawing.Size(294, 17);
            this.HintLabel.TabIndex = 7;
            this.HintLabel.Text = "*введите ваш уникальный логин работника";
            // 
            // ReturnButton
            // 
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButton.Location = new System.Drawing.Point(12, 178);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 30);
            this.ReturnButton.TabIndex = 3;
            this.ReturnButton.Text = "Назад";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // ExceptionLabel
            // 
            this.ExceptionLabel.AutoSize = true;
            this.ExceptionLabel.ForeColor = System.Drawing.Color.Red;
            this.ExceptionLabel.Location = new System.Drawing.Point(9, 127);
            this.ExceptionLabel.Name = "ExceptionLabel";
            this.ExceptionLabel.Size = new System.Drawing.Size(69, 17);
            this.ExceptionLabel.TabIndex = 6;
            this.ExceptionLabel.Text = "Exception";
            this.ExceptionLabel.Visible = false;
            // 
            // SignInButton
            // 
            this.SignInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInButton.Location = new System.Drawing.Point(263, 178);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(75, 30);
            this.SignInButton.TabIndex = 2;
            this.SignInButton.Text = "Войти";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // WorkerTextBox
            // 
            this.WorkerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorkerTextBox.Location = new System.Drawing.Point(12, 48);
            this.WorkerTextBox.Name = "WorkerTextBox";
            this.WorkerTextBox.Size = new System.Drawing.Size(220, 22);
            this.WorkerTextBox.TabIndex = 1;
            this.WorkerTextBox.UseSystemPasswordChar = true;
            // 
            // UserPic
            // 
            this.UserPic.Image = ((System.Drawing.Image)(resources.GetObject("UserPic.Image")));
            this.UserPic.Location = new System.Drawing.Point(255, 6);
            this.UserPic.Name = "UserPic";
            this.UserPic.Size = new System.Drawing.Size(64, 64);
            this.UserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UserPic.TabIndex = 1;
            this.UserPic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Авторизация работника";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(318, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 28);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TitlePanel
            // 
            this.TitlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitlePanel.Controls.Add(this.label1);
            this.TitlePanel.Controls.Add(this.MinimizeButton);
            this.TitlePanel.Controls.Add(this.ExitButton);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(350, 30);
            this.TitlePanel.TabIndex = 10;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.TitlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(288, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 28);
            this.MinimizeButton.TabIndex = 4;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // WorkerSingIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkerSingIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkerSingIn";
            this.Load += new System.EventHandler(this.WorkerSingIn_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).EndInit();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label ExceptionLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.TextBox WorkerTextBox;
        private System.Windows.Forms.PictureBox UserPic;
        private System.Windows.Forms.Label HintLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Button MinimizeButton;
    }
}