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

namespace kursa4_build42820.Forms.MainForms.AdminSubsystem.UsersQueries
{
    public partial class InsertUserForm : Form
    {
        public InsertUserForm()
        {
            InitializeComponent();
        }

        Database database;

        private void InsertUserForm_Load(object sender, EventArgs e)
        {
            database = new Database();
            database.OpenConnection();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            database.CloseConnection();
            Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private async void OkButton_Click(object sender, EventArgs e)
        {
            if (IsUserExists() || IsWorkerExists())
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
                string strCommand;
                if (!string.IsNullOrEmpty(WorkerIdTextBox.Text) && !string.IsNullOrWhiteSpace(WorkerIdTextBox.Text))
                    strCommand = "INSERT INTO [Users] (WorkerId, Login, Password, Name, Surname, PhoneNumber, Address, DateOfRegistration) VALUES (@WorkerId, @Login, @Password, @Name, @Surname, @PhoneNumber, @Address, GETDATE())";
                else
                    strCommand = "INSERT INTO [Users] (Login, Password, Name, Surname, PhoneNumber, Address, DateOfRegistration) VALUES (@Login, @Password, @Name, @Surname, @PhoneNumber, @Address, GETDATE())";
                
                SqlCommand command = new SqlCommand(strCommand, database.GetSqlConnection());

                if (!string.IsNullOrEmpty(WorkerIdTextBox.Text) && !string.IsNullOrWhiteSpace(WorkerIdTextBox.Text))
                    command.Parameters.AddWithValue("WorkerId", WorkerIdTextBox.Text);

                command.Parameters.AddWithValue("Login", LoginTextBox.Text);
                command.Parameters.AddWithValue("Password", PasswordTextBox.Text);
                command.Parameters.AddWithValue("Name", NameTextBox.Text);
                command.Parameters.AddWithValue("Surname", SurnameTextBox.Text);

                if (!string.IsNullOrEmpty(PhoneTextBox.Text) &&
                !string.IsNullOrWhiteSpace(PhoneTextBox.Text) && IsNumber(PhoneTextBox.Text))
                    command.Parameters.AddWithValue("PhoneNumber", PhoneTextBox.Text);
                else
                    command.Parameters.AddWithValue("PhoneNumber", "не указан");
                if (!string.IsNullOrEmpty(AddressTextBox.Text) && !string.IsNullOrWhiteSpace(AddressTextBox.Text))
                    command.Parameters.AddWithValue("Address", AddressTextBox.Text);
                else
                    command.Parameters.AddWithValue("Address", "не указан");
                try
                {
                    await command.ExecuteNonQueryAsync(); //--
                    Console.WriteLine("Successful insert a record...");
                    database.CloseConnection();
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
                Console.WriteLine("Failure! Check yor input data and try again...");
                ExceptionLabel.Visible = true;
                ExceptionLabel.Text = "Заполните обязательные поля!";
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

        private bool IsWorkerExists()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Users] WHERE [WorkerId] = @WorkerId", database.GetSqlConnection());
            command.Parameters.AddWithValue("WorkerId", WorkerIdTextBox.Text);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Такой работник уже существует!");
                Console.WriteLine("This worker id already exists: {0}", WorkerIdTextBox.Text);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
