namespace Test
{
    public class Client : BusinessPartner
    {
        public Client(int id, string name, string city, string address, string owner, string phoneNumber, string email, string vatRegNumber) 
            : base(id, name, city, address, owner, phoneNumber, email, vatRegNumber)
        {
        }
    }
}