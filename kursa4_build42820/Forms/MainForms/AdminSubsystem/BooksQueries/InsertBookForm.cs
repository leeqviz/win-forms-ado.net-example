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

namespace kursa4_build42820.Forms.MainForms.AdminSubsystem.BooksQueries
{
    public partial class InsertBookForm : Form
    {
        public InsertBookForm()
        {
            InitializeComponent();
        }

        Database database;

        private void InsertBookForm_Load(object sender, EventArgs e)
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
            if (IsBookExists())
                return;

            if (ExceptionLabel.Visible)
                ExceptionLabel.Visible = false;

            if (!string.IsNullOrEmpty(AutorTextBox.Text) &&
                !string.IsNullOrWhiteSpace(AutorTextBox.Text) &&
                !string.IsNullOrEmpty(ThemeTextBox.Text) &&
                !string.IsNullOrWhiteSpace(ThemeTextBox.Text) &&
                !string.IsNullOrEmpty(NameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(NameTextBox.Text) &&
                !string.IsNullOrEmpty(PublisherTextBox.Text) &&
                !string.IsNullOrWhiteSpace(PublisherTextBox.Text) &&
                !string.IsNullOrEmpty(PlaceOfPublicationTextBox.Text) &&
                !string.IsNullOrWhiteSpace(PlaceOfPublicationTextBox.Text) &&

                !string.IsNullOrEmpty(YearTextBox.Text) &&
                !string.IsNullOrWhiteSpace(YearTextBox.Text) &&
                IsNumber(YearTextBox.Text) && YearTextBox.Text.Length == 4)
            {
                string sqlQuery;
                if (!string.IsNullOrEmpty(CopiesTextBox.Text) && 
                    !string.IsNullOrWhiteSpace(CopiesTextBox.Text) && IsNumber(CopiesTextBox.Text))
                    sqlQuery = "INSERT INTO [Books] (Name, Autor, Year, PlaceOfPublication, Publisher, Theme, Copies) " +
                                "VALUES (@Name, @Autor, @Year, @PlaceOfPublication, @Publisher, @Theme, @Copies)";
                else
                    sqlQuery = "INSERT INTO [Books] (Name, Autor, Year, PlaceOfPublication, Publisher, Theme) " +
                                "VALUES (@Name, @Autor, @Year, @PlaceOfPublication, @Publisher, @Theme)";

                SqlCommand command = new SqlCommand(sqlQuery, database.GetSqlConnection());

                if (!string.IsNullOrEmpty(CopiesTextBox.Text) && 
                    !string.IsNullOrWhiteSpace(CopiesTextBox.Text) && IsNumber(CopiesTextBox.Text))
                    command.Parameters.AddWithValue("Copies", CopiesTextBox.Text);

                command.Parameters.AddWithValue("Name", NameTextBox.Text);
                command.Parameters.AddWithValue("Autor", AutorTextBox.Text);
                command.Parameters.AddWithValue("Year", YearTextBox.Text);
                command.Parameters.AddWithValue("PlaceOfPublication", PlaceOfPublicationTextBox.Text);
                command.Parameters.AddWithValue("Publisher", PublisherTextBox.Text);
                command.Parameters.AddWithValue("Theme", ThemeTextBox.Text);
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

        private bool IsBookExists()
        {
            string sqlQuery = "SELECT * FROM [Books] " +
                                "WHERE [Name] = @Name AND [Autor] = @Autor";
            SqlCommand command = new SqlCommand(sqlQuery, database.GetSqlConnection());
            command.Parameters.AddWithValue("Name", NameTextBox.Text);
            command.Parameters.AddWithValue("Autor", AutorTextBox.Text);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Книга с таким названием и автором уже существует!");
                Console.WriteLine("This book already exists");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
