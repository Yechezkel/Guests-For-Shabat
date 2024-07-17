using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GuestForShabat.DAL
{
    public class DBContext
    {


        private readonly string _connectionString;



        public DBContext()
        {
            _connectionString = "Server=DESKTOP-248A3K8;Database=GuestForShabat;User Id=sa;Password=1234;";
        }





        public DataTable MakeQueryDT(string queryStr)
        {
            DataTable output = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryStr, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(output);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("The Error is: " + ex.Message);
                        //Console.WriteLine("The Error is: " + ex.Message);
                    }
                }
                return output;
            }
        }



        public DataTable MakeQueryDT(string queryStr, SqlParameter[] parameters)
        {
            DataTable output = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryStr, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    try
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(output);
                        }
                    }
                    catch (SqlException ex)
                    {
                        //MessageBox.Show("The Error is: " + ex.Message);
                        Console.WriteLine("The Error is: " + ex.Message);
                    }
                }
            }
            return output;
        }



        public SqlCommand MakeQueryCMD(string queryStr)
        {
            SqlCommand output = new SqlCommand();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryStr, conn))
                {
                    try
                    {
                        conn.Open();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("The Error is: " + ex.Message);
                        //Console.WriteLine("The Error is: " + ex.Message);
                    }
                }
                return output;
            }
        }



        public SqlCommand MakeQueryCMD(string queryStr, SqlParameter[] parameters)
        {
            SqlCommand output = new SqlCommand();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryStr, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    try
                    {
                        conn.Open();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("The Error is: " + ex.Message);
                        //Console.WriteLine("The Error is: " + ex.Message);
                    }
                }
                return output;
            }
        }


        public void CheckConnection()
        {
            // Try to connect to the database and execute a simple query
            DataTable result = ExecuteQuery("SELECT 1+1 AS test", null);
            if (Convert.ToInt32(result.Rows[0][0]) != 2)
                throw new Exception("Failed to connect to the database.");  
           
        }
        public void CheckConnectionToDefaultDB(string dbName)
        {
            CheckConnection();
            // Construct the query to check for the existence of the database by name in the system catalog
            string query = $"SELECT db_id('{SqlEscape(dbName)}');";

            DataTable result = ExecuteQuery(query, null);
            if (result == null || result.Rows.Count == 0 || result.Rows[0][0] == DBNull.Value)
                throw new Exception($"Database {dbName} is not defined.");
        }

        public int ExecuteNonQuery(string queryStr, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryStr, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    try
                    {
                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Debug.WriteLine("An error occurred: " + ex.Message);
                        return -1;
                    }
                }
            }
        }

        public DataTable ExecuteQuery(string queryStr, SqlParameter[] parameters)
        {
            DataTable output = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryStr, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    try
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(output);
                        }
                    }
                    catch (SqlException ex)
                    {
                        Debug.WriteLine("An error occurred: " + ex.Message);
                    }
                }
            }
            return output;
        }
        /// <summary>
        /// Executes a SQL command and returns the first column of the first row in the result set returned by the query.
        /// Additional columns or rows are ignored.
        /// </summary>
        /// <param name="query">The SQL query to execute.</param>
        /// <param name="parameters">SQL parameters to avoid SQL injection.</param>
        /// <returns>The value of the first column of the first row in the result set.</returns>
        public object ExecuteScalar(string query, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters to the command.
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    try
                    {
                        conn.Open();
                        return cmd.ExecuteScalar();
                    }
                    catch (SqlException ex)
                    {
                        Debug.WriteLine($"SQL Error: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"General Error: {ex.Message}");
                    }
                    return null;
                }
            }
        }

        private string SqlEscape(string input)
        {
            // Simple SQL escape method to avoid basic SQL injection
            return input.Replace("'", "''");
        }

        
    }
}
