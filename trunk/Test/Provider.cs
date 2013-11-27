namespace Test
{
    using System;

    /// <summary>
    /// Defines a company the warehouse purchases goods or services from.
    /// </summary>
    [Serializable]
    public class Provider : BusinessPartner
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Provider" /> class.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="name">The name.</param>
        /// <param name="city">The city.</param>
        /// <param name="address">The address.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="email">The email.</param>
        /// <param name="vatRegNumber">The vat reg number.</param>
        public Provider(int id, string name, string city, string address, string owner, string phoneNumber, string email, string vatRegNumber) : base(id, name, city, address, owner, phoneNumber, email, vatRegNumber)
        {
        }
    }
}