
namespace AddressbookServiceADO
{
    public class Program
    {
        static void Main(string[] args)
        {
            AdrressbookRepo repo = new AdrressbookRepo();
            repo.coonectionString();
            repo.GetAllContact();
        }
    }
}