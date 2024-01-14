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

namespace build42820.Forms.MainForms.AdminSubsystem.UsersQueries
{
    public partial class UpdateUserForm : Form
    {
        public UpdateUserForm()
        {
            InitializeComponent();
        }

        Database database;

        private void UpdateUserForm_Load(object sender, EventArgs e)
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
        private void TitlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TitlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private async void OkButton_Click(object sender, EventArgs e)
        {
            if (ExceptionLabel.Visible)
                ExceptionLabel.Visible = false;

            if (!string.IsNullOrEmpty(IdTextBox.Text) &&
                !string.IsNullOrWhiteSpace(IdTextBox.Text) &&
                IsNumber(IdTextBox.Text) &&
                !string.IsNullOrEmpty(NameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(NameTextBox.Text) &&
                !string.IsNullOrEmpty(SurnameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(SurnameTextBox.Text))
            {
                string strCommand = "UPDATE [Users] SET [Name] = @Name, [Surname] = @Surname, [PhoneNumber] = @PhoneNumber, [Address] = @Address WHERE [Id] = @Id";
                SqlCommand command = new SqlCommand(strCommand, database.GetSqlConnection());

                command.Parameters.AddWithValue("Id", IdTextBox.Text);
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
                    Console.WriteLine("Successful update a record...");
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
                ExceptionLabel.Text = "Заполните обязательные поля и проверьте их правильность!";
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
    }
}
