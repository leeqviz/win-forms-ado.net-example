using build42820.Forms.MainForms.UserSubsystem.Operations;
using build42820.Forms.SystemForms;
using build42820.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace build42820.Forms.MainForms.UserSubsystem
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        Database database;

        private void UserForm_Load(object sender, EventArgs e)
        {
            database = new Database();
            database.OpenConnection();
            GetButton.Enabled = false;
            GiveButton.Enabled = false;
            TableTextBox.Text = "Текущая таблица: не выбрана";
            LoadUserData();            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            database.CloseConnection();
            Application.Exit();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            database.CloseConnection();
            AuthorizationForm.form.Show();
            this.Close();
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

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void LoadUserData()
        {
            UserListBox.Items.Clear();
            SqlDataReader sqlDataReader = null;
            string sqlQuery = "SELECT * FROM [Users] WHERE [Login] = @Login";
            SqlCommand command = new SqlCommand(sqlQuery, database.GetSqlConnection());
            command.Parameters.AddWithValue("Login", User.UserLogin);
            try
            {
                sqlDataReader = await command.ExecuteReaderAsync();
                await sqlDataReader.ReadAsync();
                UserListBox.Items.Add("Вы авторизованы как клиент");
                UserListBox.Items.Add("Логин пользователя: " + Convert.ToString(sqlDataReader["Login"]));
                UserListBox.Items.Add("Имя: " + Convert.ToString(sqlDataReader["Name"]));
                UserListBox.Items.Add("Фамилия: " + Convert.ToString(sqlDataReader["Surname"]));
                UserListBox.Items.Add("Телефон: " + Convert.ToString(sqlDataReader["PhoneNumber"]));
                UserListBox.Items.Add("Адрес: " + Convert.ToString(sqlDataReader["Address"]));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlDataReader != null)
                    sqlDataReader.Close();
            }
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("kursa4 :D");
        }

        private void GetAllBooks()
        {
            string sqlQuery = "SELECT * FROM [Books]";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuery, database.GetSqlConnection());
            DataSet dataSet = new DataSet();
            try
            {
                sqlDataAdapter.Fill(dataSet);
                DataGridView.DataSource = dataSet.Tables[0].DefaultView;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception thrown...\n" + ex.Message);
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TableTextBox.Text = "Текущая таблица: Книги";
            GetButton.Enabled = true;
            GiveButton.Enabled = false;
        }

        private void GetClientData()
        {
            string sqlQuery = "SELECT [Clients].[Id] AS [Номер операции], [Clients].[BookId] AS [Идентификационный номер книги]," +
                                        "[Books].[Name] AS [Название книги], [Clients].[Date] AS [Дата получения], [Clients].[Debt] AS [Задолженность]" +
                                "FROM [Books] JOIN [Clients] ON [Books].[Id] = [Clients].[BookId]" +
                                                "JOIN [Users] ON [Clients].[ClientId] = [Users].[Id]" +
                                "WHERE [Users].[Login] = '" + User.UserLogin + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuery, database.GetSqlConnection());
            DataSet dataSet = new DataSet();
            try
            {
                sqlDataAdapter.Fill(dataSet);
                DataGridView.DataSource = dataSet.Tables[0].DefaultView;
                DataGridView.Columns[0].Width = 100;
                DataGridView.Columns[1].Width = 150;
                DataGridView.Columns[2].Width = 100;
                DataGridView.Columns[3].Width = 100;
                DataGridView.Columns[4].Width = 100;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception thrown...\n" + ex.Message);
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TableTextBox.Text = "Текущая таблица: Клиент";
            if (GetBooksCount() == 0)
                GiveButton.Enabled = false;
            else
                GiveButton.Enabled = true;
            GetButton.Enabled = false;
            
        }

        private void BooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetAllBooks();
            ShowReminder();
        }

        private void ClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetClientData();
            CalculateDebt();
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TableTextBox.Text == "Текущая таблица: Клиент")
            {
                GetClientData();
                CalculateDebt();
            }
            if (TableTextBox.Text == "Текущая таблица: Книги")
            {
                GetAllBooks();
                ShowReminder();
            }
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            if (TableTextBox.Text == "Текущая таблица: Книги" && GetBooksCount() < 10)
            {
                GetBookForm getBookForm = new GetBookForm();
                getBookForm.Show();
            }
            else if (GetBooksCount() >= 10)
            {
                MessageBox.Show("Превышен лимит взятых книг (10)!");
            }
        }

        private void GiveButton_Click(object sender, EventArgs e)
        {
            if (TableTextBox.Text == "Текущая таблица: Клиент")
            {
                GiveBookForm giveBookForm = new GiveBookForm();
                giveBookForm.Show();
            }
        }

        private void ShowReminder()
        {
            string sqlQuery = "SELECT COUNT([Debt]) FROM [Clients] WHERE [Debt] = @Debt AND [ClientId] = @ClientId";
            SqlCommand command = new SqlCommand(sqlQuery, database.GetSqlConnection());
            command.Parameters.AddWithValue("ClientId", User.GetClientId(database.GetSqlConnection()));
            command.Parameters.AddWithValue("Debt", "есть");
            try
            {
                //await command.ExecuteNonQueryAsync();
                object result = command.ExecuteScalar();
                int debt = Convert.ToInt32(result);
                Console.WriteLine("Successful calculate debt...");
                if (debt > 0)
                    MessageBox.Show("Вам необходимо сдать " + debt.ToString() + " книг(у)!");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception thrown...\n" + ex.Message);
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CalculateDebt()
        {
            string sqlQuery = "UPDATE [Clients] SET [Debt] = @Debt " +
                                "WHERE DATEDIFF(day, [Date], GETDATE()) >= 5";
            SqlCommand command = new SqlCommand(sqlQuery, database.GetSqlConnection());
            command.Parameters.AddWithValue("Debt", "есть");
            //command.Parameters.AddWithValue("ClientId", User.GetClientId(database.GetSqlConnection()));
            try
            {
                await command.ExecuteNonQueryAsync();
                Console.WriteLine("Successful calculate debt...");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception thrown...\n" + ex.Message);
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetBooksCount()
        {
            string sqlQuery = "SELECT COUNT(*) FROM [Clients] WHERE [ClientId] = @ClientId";
            SqlCommand command = new SqlCommand(sqlQuery, database.GetSqlConnection());
            command.Parameters.AddWithValue("ClientId", User.GetClientId(database.GetSqlConnection()));
            int count = 0;
            try
            {
                //await command.ExecuteNonQueryAsync();
                object result = command.ExecuteScalar();
                count = Convert.ToInt32(result);
                Console.WriteLine("Successful calculate books count...");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception thrown...\n" + ex.Message);
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return count;
        }
    }
}
