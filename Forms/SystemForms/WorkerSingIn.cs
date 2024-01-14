using build42820.Forms.MainForms.AdminSubsystem;
using build42820.Forms.MainForms.WorkerSubsystem;
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

namespace build42820.Forms.SystemForms
{
    public partial class WorkerSingIn : Form
    {
        public WorkerSingIn()
        {
            InitializeComponent();
        }

        Database database;

        private void WorkerSingIn_Load(object sender, EventArgs e)
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

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            database.CloseConnection();
            //this.Hide()
            //AuthorizationForm authorizationForm = new AuthorizationForm();
            //authorizationForm.Show();
            AuthorizationForm.form.Show();
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void SignInButton_Click(object sender, EventArgs e)
        {
            if (ExceptionLabel.Visible)
                ExceptionLabel.Visible = false;

            if (!string.IsNullOrEmpty(WorkerTextBox.Text) &&
                !string.IsNullOrWhiteSpace(WorkerTextBox.Text))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM [Users] WHERE [WorkerId] = @WorkerId", database.GetSqlConnection());
                command.Parameters.AddWithValue("WorkerId", WorkerTextBox.Text);

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                try
                {
                    await command.ExecuteNonQueryAsync(); //--
                    adapter.SelectCommand = command;
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        User.UserLogin = WorkerTextBox.Text;
                        Console.WriteLine("Successful authorization as {0}", User.UserLogin);
                        database.CloseConnection();
                        //this.Hide();
                        if (WorkerTextBox.Text == "admin")
                        {
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                        }
                        else
                        {
                            WorkerForm workerForm = new WorkerForm();
                            workerForm.Show();
                        }
                        this.Close();
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
                ExceptionLabel.Text = "Заполните поле!";
            }
        }
    }
}
