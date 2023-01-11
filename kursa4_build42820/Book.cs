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
    class Book
    {
        public static int GetBookId(SqlConnection sqlConnection, string operationId)
        {
            string sqlQuery = "SELECT [BookId] FROM [Clients] WHERE [Id] = @Id";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Id", operationId);
            int BooktId = -1;
            try 
            {
                object result = sqlCommand.ExecuteScalar();
                BooktId = Convert.ToInt32(result);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception thrown...\n" + ex.Message);
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return BooktId;
        }

        public static int GetCopies(SqlConnection sqlConnection, int bookId)
        {
            string sqlQuery = "SELECT [Copies] FROM [Books] WHERE [Id] = @Id";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Id", bookId);
            int Copies = 0;
            try
            {
                object result = sqlCommand.ExecuteScalar();
                Copies = Convert.ToInt32(result);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception thrown...\n" + ex.Message);
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Copies;
        }
    }
}
