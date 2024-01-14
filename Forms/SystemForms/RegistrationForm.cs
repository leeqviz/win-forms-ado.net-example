using build42820.Forms.MainForms.UserSubsystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace build42820.Forms.SystemForms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        Database database;

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            database = new Database();
            database.OpenConnection();
            PhoneTextBox.Text = "необязательное поле (номер)";
            PhoneTextBox.ForeColor = Color.Gray;
            AddressTextBox.Text = "необязательное поле";
            AddressTextBox.ForeColor = Color.Gray;
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

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            database.CloseConnection();
            //this.Hide();
            //AuthorizationForm authorizationForm = new AuthorizationForm();
            //authorizationForm.Show();
            AuthorizationForm.form.Show();
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PhoneTextBox_Leave(object sender, EventArgs e)
        {
            if (PhoneTextBox.Text == "")
            {
                PhoneTextBox.Text = "необязательное поле (номер)";
                PhoneTextBox.ForeColor = Color.Gray;
            }
        }

        private void PhoneTextBox_Enter(object sender, EventArgs e)
        {
            if (PhoneTextBox.Text == "необязательное поле (номер)")
            {
                PhoneTextBox.Text = "";
                PhoneTextBox.ForeColor = Color.Black;
            }
        }

        private void AddressTextBox_Leave(object sender, EventArgs e)
        {
            if (AddressTextBox.Text == "")
            {
                AddressTextBox.Text = "необязательное поле";
                AddressTextBox.ForeColor = Color.Gray;
            }
        }

        private void AddressTextBox_Enter(object sender, EventArgs e)
        {
            if (AddressTextBox.Text == "необязательное поле")
            {
                AddressTextBox.Text = "";
                AddressTextBox.ForeColor = Color.Black;
            }
        }

        private async void SignInButton_Click(object sender, EventArgs e)
        {
            if (IsUserExists())
                return;

            if (ExceptionLabel.Visible)
                ExceptionLabel.Visible = false;

            if (!string.IsNullOrEmpty(LoginTextBox.Text) &&
                !string.IsNullOrWhiteSpace(LoginTextBox.Text) &&
                !string.IsNullOrEmpty(PasswordTextBox.Text) &&
                !string.IsNullOrWhiteSpace(PasswordTextBox.Text) &&
                !string.IsNullOrEmpty(NameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(NameTextBox.Text) &&
                !string.IsNullOrEmpty(SurnameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(SurnameTextBox.Text))
            {
                string strCommand = "INSERT INTO [Users] (Login, Password, Name, Surname, PhoneNumber, Address, DateOfRegistration) VALUES (@Login, @Password, @Name, @Surname, @PhoneNumber, @Address, GETDATE())";
                SqlCommand command = new SqlCommand(strCommand, database.GetSqlConnection());
                command.Parameters.AddWithValue("Login", LoginTextBox.Text);
                command.Parameters.AddWithValue("Password", PasswordTextBox.Text);
                command.Parameters.AddWithValue("Name", NameTextBox.Text);
                command.Parameters.AddWithValue("Surname", SurnameTextBox.Text);

                if (PhoneTextBox.Text != "необязательное поле (номер)" && IsNumber(PhoneTextBox.Text))
                    command.Parameters.AddWithValue("PhoneNumber", PhoneTextBox.Text);
                else
                    command.Parameters.AddWithValue("PhoneNumber", "не указан");
                if (AddressTextBox.Text != "необязательное поле")
                    command.Parameters.AddWithValue("Address", AddressTextBox.Text);
                else
                    command.Parameters.AddWithValue("Address", "не указан");
                try
                {
                    await command.ExecuteNonQueryAsync(); //--
                    User.UserLogin = LoginTextBox.Text;
                    Console.WriteLine("Successful registration as {0}", LoginTextBox.Text);
                    database.CloseConnection();
                    //this.Hide();
                    UserForm userForm = new UserForm();
                    userForm.Show();
                    this.Close();
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

        private bool IsNumber(string str)
        {
            Regex rxNums = new Regex(@"^\d+$"); // любые цифры
            if (rxNums.IsMatch(str))
                return true;
            else
                return false;
        }

        private bool IsUserExists()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Users] WHERE [Login] = @Login", database.GetSqlConnection());
            command.Parameters.AddWithValue("Login", LoginTextBox.Text);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует!");
                Console.WriteLine("This login already exists: {0}", LoginTextBox.Text);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
