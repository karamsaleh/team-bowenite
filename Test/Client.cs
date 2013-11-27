namespace Test
{
    using System;

    /// <summary>
    /// Defines a client of the warehouse.
    /// </summary>
    [Serializable]
    public class Client : BusinessPartner
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Client" /> class.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="name">The name.</param>
        /// <param name="city">The city.</param>
        /// <param name="address">The address.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="email">The email.</param>
        /// <param name="vatRegNumber">The vat reg number.</param>
        public Client(int id, string name, string city, string address, string owner, string phoneNumber, string email, string vatRegNumber) 
            : base(id, name, city, address, owner, phoneNumber, email, vatRegNumber)
        {
        }
    }
}