using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=103.200.23.139;Database=ntddevte_demoyoga;Uid=ntddevte_abc;Pwd=abc;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string sqlQuery = "SELECT * FROM users";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string name;
                        if (!reader.IsDBNull(reader.GetOrdinal("name")))
                        {
                            name = reader.GetString("name");
                            Console.WriteLine($"Name: {name}");
                        }
                        else
                        {
                            name = "";
                        }
                        string email = reader.GetString("email");

                        Console.WriteLine($"ID: {id}, name: {name}, Email: {email}");
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadLine();
                connection.Close();
            }
        }
    }
}