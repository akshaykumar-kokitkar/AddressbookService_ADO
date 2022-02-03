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
    }
}
