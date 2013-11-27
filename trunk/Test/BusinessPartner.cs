namespace Test
{
    using System;
    using System.Text;

    /// <summary>
    /// The base class of all warehouse business partners. 
    /// All types the warehouse has business relationship with inherit this class.
    /// </summary>
    [Serializable]
    public abstract class BusinessPartner
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessPartner" /> class.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="name">The name.</param>
        /// <param name="city">The city.</param>
        /// <param name="address">The address.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="email">The email.</param>
        /// <param name="vatRegNumber">The vat reg number.</param>
        protected BusinessPartner(int id, string name, string city, string address, string owner, string phoneNumber, string email,
            string vatRegNumber = null)
        {
            this.ID = id;
            this.Name = name;
            this.VatRegNumber = vatRegNumber;
            this.City = city;
            this.Address = address;
            this.Owner = owner;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

        public int ID { get; protected set; }

        public string Name { get; protected set; }

        public string VatRegNumber { get; protected set; }

        public string City { get; protected set; }

        public string Address { get; protected set; }

        public string Owner { get; protected set; }

        public string PhoneNumber { get; protected set; }

        public string Email { get; protected set; }

        /// <summary>
        /// Serves as a hash function for a particular type.
        /// </summary>
        /// <returns>A hash code for the current <see cref="T:System.Object" />.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + this.ID.GetHashCode();
                result = result * 23 + ((Name != null) ? this.Name.GetHashCode() : 0);
                result = result * 23 + ((VatRegNumber != null) ? this.VatRegNumber.GetHashCode() : 0);
                result = result * 23 + ((City != null) ? this.City.GetHashCode() : 0);
                result = result * 23 + ((Address != null) ? this.Address.GetHashCode() : 0);
                result = result * 23 + ((Owner != null) ? this.Owner.GetHashCode() : 0);
                result = result * 23 + ((PhoneNumber != null) ? this.PhoneNumber.GetHashCode() : 0);
                result = result * 23 + ((Email != null) ? this.Email.GetHashCode() : 0);
                return result;
            }
        }

        /// <summary>
        /// Equalses the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public bool Equals(BusinessPartner value)
        {
            if (ReferenceEquals(null, value))
            {
                return false;
            }
            if (ReferenceEquals(this, value))
            {
                return true;
            }
            return this.ID == value.ID &&
                   Equals(this.Name, value.Name) &&
                   Equals(this.VatRegNumber, value.VatRegNumber) &&
                   Equals(this.City, value.City) &&
                   Equals(this.Address, value.Address) &&
                   Equals(this.Owner, value.Owner) &&
                   Equals(this.PhoneNumber, value.PhoneNumber) &&
                   Equals(this.Email, value.Email);
        }

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object" /> is equal
        /// to the current <see cref="T:System.Object" />.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>
        /// true if the specified object  is equal to the current object; otherwise,
        /// false.
        /// </returns>
        public override bool Equals(object obj)
        {
            BusinessPartner temp = obj as BusinessPartner;
            if (temp == null)
                return false;
            return this.Equals(temp);
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            var partnerInfo = new StringBuilder();

            foreach (var property in this.GetType().GetProperties())
            {
                partnerInfo.AppendFormat("{0};", property.GetValue(this));
            }

            return partnerInfo.ToString();
        }
    }
}