using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace build42820
{
    class Database
    {
        SqlConnection SqlConnection;

        public async void OpenConnection()
        {
            //string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=kursa4;Integrated Security=True";
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection = new SqlConnection(connectionString);
            Console.WriteLine("Connection to Microsoft SQL Server...");
            try
            {
                if (SqlConnection.State == ConnectionState.Closed)
                {
                    await SqlConnection.OpenAsync();
                    Console.WriteLine("Connection is open...");
                    Console.WriteLine("Connection properties:");
                    Console.WriteLine("\tConnectionString: {0}", SqlConnection.ConnectionString);
                    Console.WriteLine("\tDatabase: {0}", SqlConnection.Database);
                    Console.WriteLine("\tDataSource: {0}", SqlConnection.DataSource);
                    Console.WriteLine("\tServerVersion: {0}", SqlConnection.ServerVersion);
                    Console.WriteLine("\tState: {0}", SqlConnection.State);
                    Console.WriteLine("\tWorkstationld: {0}", SqlConnection.WorkstationId);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception thrown...\n" + ex.Message);
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CloseConnection()
        {
            if (SqlConnection != null && SqlConnection.State != ConnectionState.Closed)
            {
                SqlConnection.Close();
                Console.WriteLine("Connection is closed...");
            }
        }

        public SqlConnection GetSqlConnection()
        {
            return SqlConnection;
        }
    }
}
