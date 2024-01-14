namespace build42820.Forms.MainForms.AdminSubsystem.BooksQueries
{
    partial class InsertBookForm
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
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.HintLabel = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.YearLabel = new System.Windows.Forms.Label();
            this.CopiesLabel = new System.Windows.Forms.Label();
            this.CopiesTextBox = new System.Windows.Forms.TextBox();
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.PublisherLabel = new System.Windows.Forms.Label();
            this.ThemeTextBox = new System.Windows.Forms.TextBox();
            this.PublisherTextBox = new System.Windows.Forms.TextBox();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AutorLabel = new System.Windows.Forms.Label();
            this.AutorTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ExceptionLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.PlaceOfPublicationLabel = new System.Windows.Forms.Label();
            this.PlaceOfPublicationTextBox = new System.Windows.Forms.TextBox();
            this.TitlePanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            this.TitlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitlePanel.Controls.Add(this.MinimizeButton);
            this.TitlePanel.Controls.Add(this.CloseButton);
            this.TitlePanel.Controls.Add(this.TitleLabel);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(450, 30);
            this.TitlePanel.TabIndex = 18;
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
            this.MinimizeButton.TabIndex = 10;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(418, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 28);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(251, 25);
            this.TitleLabel.TabIndex = 12;
            this.TitleLabel.Text = "Форма добавления книги";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.HintLabel);
            this.MainPanel.Controls.Add(this.YearTextBox);
            this.MainPanel.Controls.Add(this.YearLabel);
            this.MainPanel.Controls.Add(this.CopiesLabel);
            this.MainPanel.Controls.Add(this.CopiesTextBox);
            this.MainPanel.Controls.Add(this.ThemeLabel);
            this.MainPanel.Controls.Add(this.PublisherLabel);
            this.MainPanel.Controls.Add(this.ThemeTextBox);
            this.MainPanel.Controls.Add(this.PublisherTextBox);
            this.MainPanel.Controls.Add(this.ReturnButton);
            this.MainPanel.Controls.Add(this.NameLabel);
            this.MainPanel.Controls.Add(this.AutorLabel);
            this.MainPanel.Controls.Add(this.AutorTextBox);
            this.MainPanel.Controls.Add(this.NameTextBox);
            this.MainPanel.Controls.Add(this.ExceptionLabel);
            this.MainPanel.Controls.Add(this.OkButton);
            this.MainPanel.Controls.Add(this.PlaceOfPublicationLabel);
            this.MainPanel.Controls.Add(this.PlaceOfPublicationTextBox);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.Location = new System.Drawing.Point(0, 30);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(450, 420);
            this.MainPanel.TabIndex = 17;
            // 
            // HintLabel
            // 
            this.HintLabel.AutoSize = true;
            this.HintLabel.Location = new System.Drawing.Point(210, 270);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(158, 17);
            this.HintLabel.TabIndex = 24;
            this.HintLabel.Text = "*необязательное поле";
            // 
            // YearTextBox
            // 
            this.YearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YearTextBox.Location = new System.Drawing.Point(150, 150);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(70, 22);
            this.YearTextBox.TabIndex = 4;
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(9, 150);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(36, 17);
            this.YearLabel.TabIndex = 22;
            this.YearLabel.Text = "Год:";
            // 
            // CopiesLabel
            // 
            this.CopiesLabel.AutoSize = true;
            this.CopiesLabel.Location = new System.Drawing.Point(9, 270);
            this.CopiesLabel.Name = "CopiesLabel";
            this.CopiesLabel.Size = new System.Drawing.Size(133, 17);
            this.CopiesLabel.TabIndex = 21;
            this.CopiesLabel.Text = "Количество копий:";
            // 
            // CopiesTextBox
            // 
            this.CopiesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CopiesTextBox.Location = new System.Drawing.Point(150, 270);
            this.CopiesTextBox.Name = "CopiesTextBox";
            this.CopiesTextBox.Size = new System.Drawing.Size(40, 22);
            this.CopiesTextBox.TabIndex = 7;
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.Location = new System.Drawing.Point(9, 230);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(76, 17);
            this.ThemeLabel.TabIndex = 20;
            this.ThemeLabel.Text = "Тематика:";
            // 
            // PublisherLabel
            // 
            this.PublisherLabel.AutoSize = true;
            this.PublisherLabel.Location = new System.Drawing.Point(9, 190);
            this.PublisherLabel.Name = "PublisherLabel";
            this.PublisherLabel.Size = new System.Drawing.Size(104, 17);
            this.PublisherLabel.TabIndex = 19;
            this.PublisherLabel.Text = "Издательство:";
            // 
            // ThemeTextBox
            // 
            this.ThemeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThemeTextBox.Location = new System.Drawing.Point(150, 230);
            this.ThemeTextBox.Name = "ThemeTextBox";
            this.ThemeTextBox.Size = new System.Drawing.Size(220, 22);
            this.ThemeTextBox.TabIndex = 6;
            // 
            // PublisherTextBox
            // 
            this.PublisherTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PublisherTextBox.Location = new System.Drawing.Point(150, 190);
            this.PublisherTextBox.Name = "PublisherTextBox";
            this.PublisherTextBox.Size = new System.Drawing.Size(220, 22);
            this.PublisherTextBox.TabIndex = 5;
            // 
            // ReturnButton
            // 
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButton.Location = new System.Drawing.Point(12, 378);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 30);
            this.ReturnButton.TabIndex = 9;
            this.ReturnButton.Text = "Отмена";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(9, 30);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(76, 17);
            this.NameLabel.TabIndex = 15;
            this.NameLabel.Text = "Название:";
            // 
            // AutorLabel
            // 
            this.AutorLabel.AutoSize = true;
            this.AutorLabel.Location = new System.Drawing.Point(9, 70);
            this.AutorLabel.Name = "AutorLabel";
            this.AutorLabel.Size = new System.Drawing.Size(51, 17);
            this.AutorLabel.TabIndex = 16;
            this.AutorLabel.Text = "Автор:";
            // 
            // AutorTextBox
            // 
            this.AutorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AutorTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AutorTextBox.Location = new System.Drawing.Point(150, 70);
            this.AutorTextBox.Name = "AutorTextBox";
            this.AutorTextBox.Size = new System.Drawing.Size(220, 22);
            this.AutorTextBox.TabIndex = 2;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NameTextBox.Location = new System.Drawing.Point(150, 30);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(220, 22);
            this.NameTextBox.TabIndex = 1;
            // 
            // ExceptionLabel
            // 
            this.ExceptionLabel.AutoSize = true;
            this.ExceptionLabel.ForeColor = System.Drawing.Color.Red;
            this.ExceptionLabel.Location = new System.Drawing.Point(9, 310);
            this.ExceptionLabel.Name = "ExceptionLabel";
            this.ExceptionLabel.Size = new System.Drawing.Size(69, 17);
            this.ExceptionLabel.TabIndex = 11;
            this.ExceptionLabel.Text = "Exception";
            this.ExceptionLabel.Visible = false;
            // 
            // OkButton
            // 
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkButton.Location = new System.Drawing.Point(338, 378);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(100, 30);
            this.OkButton.TabIndex = 8;
            this.OkButton.Text = "Выполнить";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // PlaceOfPublicationLabel
            // 
            this.PlaceOfPublicationLabel.AutoSize = true;
            this.PlaceOfPublicationLabel.Location = new System.Drawing.Point(9, 110);
            this.PlaceOfPublicationLabel.Name = "PlaceOfPublicationLabel";
            this.PlaceOfPublicationLabel.Size = new System.Drawing.Size(112, 17);
            this.PlaceOfPublicationLabel.TabIndex = 17;
            this.PlaceOfPublicationLabel.Text = "Место издания:";
            // 
            // PlaceOfPublicationTextBox
            // 
            this.PlaceOfPublicationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlaceOfPublicationTextBox.Location = new System.Drawing.Point(150, 110);
            this.PlaceOfPublicationTextBox.Name = "PlaceOfPublicationTextBox";
            this.PlaceOfPublicationTextBox.Size = new System.Drawing.Size(220, 22);
            this.PlaceOfPublicationTextBox.TabIndex = 3;
            // 
            // InsertBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertBookForm";
            this.Load += new System.EventHandler(this.InsertBookForm_Load);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label CopiesLabel;
        private System.Windows.Forms.TextBox CopiesTextBox;
        private System.Windows.Forms.Label ThemeLabel;
        private System.Windows.Forms.Label PublisherLabel;
        private System.Windows.Forms.TextBox ThemeTextBox;
        private System.Windows.Forms.TextBox PublisherTextBox;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AutorLabel;
        private System.Windows.Forms.TextBox AutorTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label ExceptionLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label PlaceOfPublicationLabel;
        private System.Windows.Forms.TextBox PlaceOfPublicationTextBox;
        private System.Windows.Forms.Label HintLabel;
    }
}