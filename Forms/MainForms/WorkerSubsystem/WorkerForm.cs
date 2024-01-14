using build42820.Forms.MainForms.AdminSubsystem.BooksQueries;
using build42820.Forms.MainForms.WorkerSubsystem.Functions;
using build42820.Forms.SystemForms;
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

namespace build42820.Forms.MainForms.WorkerSubsystem
{
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        Database database;

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            database = new Database();
            database.OpenConnection();
            EditButton.Enabled = false;
            InsertButton.Enabled = false;
            UpdateButton.Enabled = false;
            DeleteButton.Enabled = false;
            DetailButton.Enabled = false;
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
            string sqlQuery = "SELECT * FROM [Users] WHERE [WorkerId] = @WorkerId";
            SqlCommand command = new SqlCommand(sqlQuery, database.GetSqlConnection());
            command.Parameters.AddWithValue("WorkerId", User.UserLogin);
            try
            {
                sqlDataReader = await command.ExecuteReaderAsync();
                await sqlDataReader.ReadAsync();
                UserListBox.Items.Add("Вы авторизованы как работник");
                UserListBox.Items.Add("Логин работника: " + Convert.ToString(sqlDataReader["WorkerId"]));
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
            GetData(sqlQuery);
            TableTextBox.Text = "Текущая таблица: Книги";
            EditButton.Enabled = true;
            InsertButton.Enabled = true;
            UpdateButton.Enabled = true;
            DeleteButton.Enabled = true;
            DetailButton.Enabled = false;
        }

        private void GetAllOperations()
        {
            string sqlQuery = "SELECT * FROM [Operations]";
            GetData(sqlQuery);
            TableTextBox.Text = "Текущая таблица: Операции";
            EditButton.Enabled = false;
            InsertButton.Enabled = false;
            UpdateButton.Enabled = false;
            DeleteButton.Enabled = false;
            DetailButton.Enabled = false;
        }

        private void GetAllClients()
        {
            string sqlQuery = "SELECT * FROM [Clients]";
            GetData(sqlQuery);
            TableTextBox.Text = "Текущая таблица: Клиенты";
            EditButton.Enabled = false;
            InsertButton.Enabled = false;
            UpdateButton.Enabled = false;
            DeleteButton.Enabled = false;
            DetailButton.Enabled = true;
        }

        private void GetData(string sqlQuery)
        {
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
        }

        private void BooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetAllBooks();
        }

        private void HistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetAllOperations();
        }

        private void ClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetAllClients();
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TableTextBox.Text == "Текущая таблица: Клиенты")
            {
                GetAllClients();
            }
            if (TableTextBox.Text == "Текущая таблица: Книги")
            {
                GetAllBooks();
            }
            if (TableTextBox.Text == "Текущая таблица: Операции")
            {
                GetAllOperations();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (TableTextBox.Text == "Текущая таблица: Книги")
            {
                EditCopiesForm editCopiesForm = new EditCopiesForm();
                editCopiesForm.Show();
            }
        }

        private void DetailButton_Click(object sender, EventArgs e)
        {
            if (TableTextBox.Text == "Текущая таблица: Клиенты")
            {
                DetailClientForm detailClientForm = new DetailClientForm();
                detailClientForm.Show();
            }
        }

        private void ReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // save
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (TableTextBox.Text == "Текущая таблица: Книги")
            {
                UpdateBookForm updateUserForm = new UpdateBookForm();
                updateUserForm.Show();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (TableTextBox.Text == "Текущая таблица: Книги")
            {
                DeleteBookForm deleteBookForm = new DeleteBookForm();
                deleteBookForm.Show();
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (TableTextBox.Text == "Текущая таблица: Книги")
            {
                InsertBookForm insertBookForm = new InsertBookForm();
                insertBookForm.Show();
            }
        }
    }
}
