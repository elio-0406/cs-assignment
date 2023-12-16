using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class XuLyDatabase
    {
        static readonly string servername = "TRUNG-LAPTOP\\ELIO";
        static readonly string dbName = "cs-assignment";
        static readonly string username = "";
        static readonly string password = "";
        static readonly string connectionString = $"Data Source={servername};Initial Catalog={dbName};Integrated Security=True;Encrypt=False";
        //static readonly string connectionString = @"Data Source={servername};Initial Catalog={dbName};User ID={username};Password={password};Encrypt=True;Trust Server Certificate=True";

        public static DataTable ExecuteQuery(string query, SqlParameter[]? parameters = null)
        {
            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(query, connection);
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            DataTable dataTable = new();
            try
            {
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                dataTable.Load(dataReader);
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi khi thực hiện truy vấn SQL: " + ex.Message);
            }
            return dataTable;
        }

        public static int ExecuteNonQuery(string query, SqlParameter[]? parameters = null)
        {
            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(query, connection);
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            int rowsAffected = 0;
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi khi thực hiện câu lệnh SQL: " + ex.Message);
            }
            return rowsAffected;
        }
    }
}
