using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Library.Data
{
    internal class DatabaseConnection
    {
        public static readonly string СonnectionString = "Host=localhost;Port=5432;Database=Library;Username=postgres;Password=1234";

        private static void ShowConnectionError(Exception ex)
        {
            MessageBox.Show(
                $"Ошибка подключения к базе данных:\n{ex.Message}\n\nПроверьте:\n1. Доступность сервера\n2. Правильность учетных данных\n3. Сетевое подключение",
                "Ошибка подключения",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public static bool IsConnect()
        {
            try
            {
                using (var connection = new NpgsqlConnection(СonnectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                ShowConnectionError(ex);
                return false;
            }
        }

        public static DataTable ExecuteQuery(string query, NpgsqlParameter[] parameters = null)
        {
            using (var connection = new NpgsqlConnection(СonnectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public static int ExecuteNonQuery(string query, NpgsqlParameter[] parameters = null)
        {
            using (var connection = new NpgsqlConnection(СonnectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    return command.ExecuteNonQuery();
                }
            }
        }

        public static object ExecuteScalar(string query, NpgsqlParameter[] parameters = null)
        {
            using (var connection = new NpgsqlConnection(СonnectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    
                    return command.ExecuteScalar();
                }
            }
        }
    }
}
