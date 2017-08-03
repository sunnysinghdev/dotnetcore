using System;
using MySql.Data.MySqlClient;
namespace AspWebMvc.Models
{
    public class Contacts
    {
        string ConnectionString = "server=localhost;userid=root;password=root;persistsecurityinfo=True;port=3306;database=contacts";
        public Contacts()
        {

        }
        public string Connect()
        {
            string msg = "";
            try
            {
                MySqlConnection connection = new MySqlConnection(ConnectionString);
                connection.Open();
                System.Console.WriteLine("Hurray");
                msg = "herrrrr";
                MySqlCommand command = new MySqlCommand("SELECT * FROM contacts.my_contact;", connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string row = $"{reader["id"]}\t\t{reader["name"]}\t\t{reader["phone"]}";
                        msg += row;
                    }
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                msg = ex.Message;
            }
            return msg;
        }
    }
}