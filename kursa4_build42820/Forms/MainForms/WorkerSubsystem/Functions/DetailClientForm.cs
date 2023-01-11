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

namespace kursa4_build42820.Forms.MainForms.WorkerSubsystem.Functions
{
    public partial class DetailClientForm : Form
    {
        public DetailClientForm()
        {
            InitializeComponent();
        }

        Database database;

        private void EditCopiesForm_Load(object sender, EventArgs e)
        {
            database = new Database();
            database.OpenConnection();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            database.CloseConnection();
            this.Close();
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
            if (ExceptionLabel.Visible)
                ExceptionLabel.Visible = false;

            if (database.GetSqlConnection().State == ConnectionState.Closed)
                database.OpenConnection();

            ClientListBox.Items.Clear();

            if (!string.IsNullOrEmpty(IdTextBox.Text) && IsNumber(IdTextBox.Text) 
                && !string.IsNullOrWhiteSpace(IdTextBox.Text))
            {
                SqlDataReader dataReader = null;

                //client
                string sqlQuery = "SELECT [ClientId] FROM [Clients] WHERE [Id] = @Id";
                SqlCommand command = new SqlCommand(sqlQuery, database.GetSqlConnection());
                command.Parameters.AddWithValue("Id", IdTextBox.Text);

                int ClientId = -1;
                try
                {
                    object result = command.ExecuteScalar();
                    ClientId = Convert.ToInt32(result);
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Exception thrown...\n" + ex.Message);
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string getClientInfo = "SELECT [Login], [Name], [Surname], [PhoneNumber], [Address]" +
                                        "FROM [Users] WHERE [Id] = @Id";
                SqlCommand getClientInfoCommand = new SqlCommand(getClientInfo, database.GetSqlConnection());
                getClientInfoCommand.Parameters.AddWithValue("Id", ClientId);

                //book
                string sqlQuery1 = "SELECT [BookId] FROM [Clients] WHERE [Id] = @Id";
                SqlCommand command1 = new SqlCommand(sqlQuery1, database.GetSqlConnection());
                command1.Parameters.AddWithValue("Id", IdTextBox.Text);

                int BookId = -1;
                try
                {
                    object result1 = command1.ExecuteScalar();
                    BookId = Convert.ToInt32(result1);
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Exception thrown...\n" + ex.Message);
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string getBookInfo = "SELECT [Name] FROM [Books] WHERE [Id] = @Id";
                SqlCommand getBookInfoCommand = new SqlCommand(getBookInfo, database.GetSqlConnection());
                getBookInfoCommand.Parameters.AddWithValue("Id", BookId);

                try
                {
                    dataReader = await getClientInfoCommand.ExecuteReaderAsync();
                    while (await dataReader.ReadAsync())
                    {
                        ClientListBox.Items.Add("Логин - " + Convert.ToString(dataReader["Login"]));
                        ClientListBox.Items.Add("Имя - " + Convert.ToString(dataReader["Name"]));
                        ClientListBox.Items.Add("Фамилия - " + Convert.ToString(dataReader["Surname"]));
                        ClientListBox.Items.Add("Телефонный номер - " + Convert.ToString(dataReader["PhoneNumber"]));
                        ClientListBox.Items.Add("Адрес - " + Convert.ToString(dataReader["Address"]));
                    }
                    dataReader.Close();
                    dataReader = await getBookInfoCommand.ExecuteReaderAsync();
                    while (await dataReader.ReadAsync())
                    {
                        ClientListBox.Items.Add("Название книги - " + Convert.ToString(dataReader["Name"]));
                    }
                    Console.WriteLine("Successful selected info...");
                    database.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (dataReader != null)
                        dataReader.Close();
                }
            }
            else
            {
                Console.WriteLine("Failure! Check yor input data and try again...");
                ExceptionLabel.Visible = true;
                ExceptionLabel.Text = "Заполните обязательное поле и проверьте его правильность!";
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
