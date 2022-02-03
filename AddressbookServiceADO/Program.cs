
namespace AddressbookServiceADO
{
    public class Program
    {
        static void Main(string[] args)
        {
            AdrressbookRepo repo = new AdrressbookRepo();
            repo.coonectionString();
            repo.GetAllContact();

            AddressbookModel model = new AddressbookModel();
            model.first_name = "akshay";
            model.last_name = "kokitkar";
            model.address = "pune";
            model.city = "wagholi";
            model.state = "maharashtra";
            model.zip = "412207";
            model.phone = "9868511791";
            model.email = "ak@gmail.com";
            model.type = "colleague";
            model.name = "office";

            if (repo.AddContact(model))
                Console.WriteLine("record added successfully");
            repo.AddContact(model);
        }
    }
}