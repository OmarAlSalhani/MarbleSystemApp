using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MarbleSystemApp
{

    public class connection_class
    {
        public readonly string _connectionString = ConfigurationManager.ConnectionStrings["my_con"].ConnectionString;

        public DataTable select(string query)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable table = new DataTable();
                            table.Load(reader);
                            return table;
                        }
                    }
                }
                catch (Exception ex)
                {
                    return null;
                    // handle exception
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public DataTable selectWithoutClose(string query)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
                catch
                {
                    return null;
                }
            }
        }

        public string command(string query)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        var result = command.ExecuteNonQuery();
                        return "ok";
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public int commandInt(string query)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        var result = command.ExecuteNonQuery();
                        return result;
                    }
                }
                catch
                {
                    return -1;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}