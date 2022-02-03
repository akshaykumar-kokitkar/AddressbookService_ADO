using System.Data.SqlClient;

namespace AddressbookServiceADO
{
    public class AdrressbookRepo
    {
        public static string connectionString = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = addressbook_serviceDB; Integrated Security = True";
        SqlConnection connection = new SqlConnection(connectionString);

        public void coonectionString()
        {
            try
            {
                using (this.connection)
                {
                    this.connection.Open();
                    Console.WriteLine($"connection established successfully at {DateTime.Now} ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void GetAllContact()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                AddressbookModel model = new AddressbookModel();
                using (connection)
                {
                    string query = @"select * from address_book";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            model.id = reader.GetInt32(0);
                            model.first_name = reader.GetString(1);
                            model.last_name = reader.GetString(2);
                            model.address = reader.GetString(3);
                            model.city = reader.GetString(4);
                            model.state = reader.GetString(5);
                            model.zip = reader.GetString(6);
                            model.phone = reader.GetString(7);
                            model.email = reader.GetString(8);
                            model.type = reader.GetString(9);
                            model.name = reader.GetString(10);

                            Console.WriteLine($"{model.id}, {model.first_name}, {model.last_name}, {model.address}, {model.city}, {model.state}, {model.zip}, {model.phone}, {model.email}, {model.type}, {model.name}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No data found");
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
