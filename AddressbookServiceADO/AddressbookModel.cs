using System;


namespace AddressbookServiceADO
{
    public class AddressbookModel
    {

        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public  string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string type { get; set; }
        public string name { get; set; }
    }
}
