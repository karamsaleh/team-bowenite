namespace Test
{
    public class Client : BusinessPartner
    {
        public Client(string iD, string name, string city, string address, string owner, string phoneNumber, string email, string vatRegNumber) 
            : base(iD, name, city, address, owner, phoneNumber, email, vatRegNumber)
        {
        }
    }
}