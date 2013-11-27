namespace Test
{
    using System;

    [Serializable]
    public class Provider : BusinessPartner
    {
        public Provider(int id, string name, string city, string address, string owner, string phoneNumber, string email, string vatRegNumber) 
            : base(id, name, city, address, owner, phoneNumber, email, vatRegNumber)
        {
        }
    }
}