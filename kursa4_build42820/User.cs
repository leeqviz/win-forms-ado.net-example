using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursa4_build42820
{
    class User
    {
        public static string UserLogin;

        public static int GetClientId(SqlConnection sqlConnection)
        {
            string sqlQuery = "SELECT [Id] FROM [Users] WHERE [Login] = @Login";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Login", UserLogin);
            int ClientId = -1;
            try
            {
                object result = sqlCommand.ExecuteScalar();
                ClientId = Convert.ToInt32(result);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception thrown...\n" + ex.Message);
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ClientId;
        }
    }
}
