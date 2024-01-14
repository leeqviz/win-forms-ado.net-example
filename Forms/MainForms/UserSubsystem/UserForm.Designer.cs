namespace build42820.Forms.MainForms.UserSubsystem
{
    partial class UserForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.UserListBox = new System.Windows.Forms.ListBox();
            this.GiveButton = new System.Windows.Forms.Button();
            this.GetButton = new System.Windows.Forms.Button();
            this.TableTextBox = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.OtherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TitlePanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            this.TitlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitlePanel.Controls.Add(this.MinimizeButton);
            this.TitlePanel.Controls.Add(this.TitleLabel);
            this.TitlePanel.Controls.Add(this.ExitButton);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(1000, 30);
            this.TitlePanel.TabIndex = 7;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.TitlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(938, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 28);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(264, 25);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Рабочая область читателя";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(968, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 28);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.UserListBox);
            this.MainPanel.Controls.Add(this.GiveButton);
            this.MainPanel.Controls.Add(this.GetButton);
            this.MainPanel.Controls.Add(this.TableTextBox);
            this.MainPanel.Controls.Add(this.DataGridView);
            this.MainPanel.Controls.Add(this.MenuStrip);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.Location = new System.Drawing.Point(0, 30);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1000, 670);
            this.MainPanel.TabIndex = 6;
            // 
            // UserListBox
            // 
            this.UserListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserListBox.FormattingEnabled = true;
            this.UserListBox.ItemHeight = 22;
            this.UserListBox.Location = new System.Drawing.Point(730, 210);
            this.UserListBox.Name = "UserListBox";
            this.UserListBox.Size = new System.Drawing.Size(250, 288);
            this.UserListBox.TabIndex = 17;
            // 
            // GiveButton
            // 
            this.GiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GiveButton.Location = new System.Drawing.Point(730, 130);
            this.GiveButton.Name = "GiveButton";
            this.GiveButton.Size = new System.Drawing.Size(250, 30);
            this.GiveButton.TabIndex = 2;
            this.GiveButton.Text = "Вернуть книгу";
            this.GiveButton.UseVisualStyleBackColor = true;
            this.GiveButton.Click += new System.EventHandler(this.GiveButton_Click);
            // 
            // GetButton
            // 
            this.GetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetButton.Location = new System.Drawing.Point(730, 90);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(250, 30);
            this.GetButton.TabIndex = 1;
            this.GetButton.Text = "Взять книгу";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // TableTextBox
            // 
            this.TableTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.TableTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TableTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.TableTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableTextBox.Location = new System.Drawing.Point(730, 50);
            this.TableTextBox.Name = "TableTextBox";
            this.TableTextBox.ReadOnly = true;
            this.TableTextBox.Size = new System.Drawing.Size(250, 27);
            this.TableTextBox.TabIndex = 16;
            this.TableTextBox.Text = "TableName";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView.Location = new System.Drawing.Point(6, 33);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(700, 625);
            this.DataGridView.TabIndex = 11;
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OtherToolStripMenuItem,
            this.ViewToolStripMenuItem,
            this.DetailToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(998, 28);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // OtherToolStripMenuItem
            // 
            this.OtherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.OtherToolStripMenuItem.Name = "OtherToolStripMenuItem";
            this.OtherToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.OtherToolStripMenuItem.Text = "Дополнительно";
            // 
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.RefreshToolStripMenuItem.Text = "Обновить";
            this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BooksToolStripMenuItem,
            this.ClientToolStripMenuItem});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.ViewToolStripMenuItem.Text = "Представление";
            // 
            // BooksToolStripMenuItem
            // 
            this.BooksToolStripMenuItem.Name = "BooksToolStripMenuItem";
            this.BooksToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.BooksToolStripMenuItem.Text = "Каталог";
            this.BooksToolStripMenuItem.Click += new System.EventHandler(this.BooksToolStripMenuItem_Click);
            // 
            // ClientToolStripMenuItem
            // 
            this.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem";
            this.ClientToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.ClientToolStripMenuItem.Text = "Клиент";
            this.ClientToolStripMenuItem.Click += new System.EventHandler(this.ClientToolStripMenuItem_Click);
            // 
            // DetailToolStripMenuItem
            // 
            this.DetailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoToolStripMenuItem});
            this.DetailToolStripMenuItem.Name = "DetailToolStripMenuItem";
            this.DetailToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.DetailToolStripMenuItem.Text = "Справка";
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.InfoToolStripMenuItem.Text = "Инфо";
            this.InfoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // UserForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OtherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.ToolStripMenuItem ClientToolStripMenuItem;
        private System.Windows.Forms.TextBox TableTextBox;
        private System.Windows.Forms.Button GiveButton;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.ListBox UserListBox;
        private System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}