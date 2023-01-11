using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using kursa4_build42820.Forms.MainForms.UserSubsystem;
using kursa4_build42820.Forms.SystemForms;
using System.Runtime.CompilerServices;

namespace kursa4_build42820.Forms.SystemForms
{
    public partial class AuthorizationForm : Form
    {
        public static Form form;

        public AuthorizationForm()
        {
            form = this;
            InitializeComponent();
        }

        Database database;

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            database = new Database();
            database.OpenConnection();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            database.CloseConnection();
            Application.Exit();
        }

        Point lastPoint;

        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            database.CloseConnection();
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show(); 
        }

        private void WorkerLabel_Click(object sender, EventArgs e)
        {
            database.CloseConnection();
            this.Hide();
            WorkerSingIn workerSingIn = new WorkerSingIn();
            workerSingIn.Show();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void SignInButton_Click(object sender, EventArgs e)
        {
            if (database.GetSqlConnection() == null ||
                database.GetSqlConnection().State == ConnectionState.Closed)
                database.OpenConnection();

            if (ExceptionLabel.Visible)
                ExceptionLabel.Visible = false;

            if (!string.IsNullOrEmpty(LoginTextBox.Text) && 
                !string.IsNullOrWhiteSpace(LoginTextBox.Text) &&
                !string.IsNullOrEmpty(PasswordTextBox.Text) &&
                !string.IsNullOrWhiteSpace(PasswordTextBox.Text)) 
            {

                SqlCommand command = new SqlCommand("SELECT * FROM [Users] WHERE [Login] = @Login AND [Password] = @Password", database.GetSqlConnection());
                command.Parameters.AddWithValue("Login", LoginTextBox.Text);
                command.Parameters.AddWithValue("Password", PasswordTextBox.Text);

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                try
                {
                    await command.ExecuteNonQueryAsync(); //--
                    adapter.SelectCommand = command;
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        User.UserLogin = LoginTextBox.Text;
                        Console.WriteLine("Successful authorization as {0}", User.UserLogin);
                        database.CloseConnection();
                        this.Hide();
                        UserForm userForm = new UserForm();
                        userForm.Show();
                    }
                    else
                    {
                        Console.WriteLine("Failure authorization. Check yor input data and try again...");
                        ExceptionLabel.Visible = true;
                        ExceptionLabel.Text = "Проверьте правильность введенных данных!";
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Exception thrown...\n" + ex.Message);
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Console.WriteLine("Failure authorization. Check yor input data and try again...");
                ExceptionLabel.Visible = true;
                ExceptionLabel.Text = "Заполните все поля!";
            }
        }
    }
}
