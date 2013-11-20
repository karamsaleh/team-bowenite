namespace Test
{
    using System;
    using System.Text;

    public abstract class BusinessPartner
    {
        protected BusinessPartner(string name, string id, string address = null, string phoneNumber = null, string email = null)
        {
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.ID = id;
        }

        public string Name { get; protected set; }

        public string Address { get; protected set; }

        public string PhoneNumber { get; protected set; }

        public string Email { get; protected set; }

        public string ID { get; protected set; }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + ((Name != null) ? this.Name.GetHashCode() : 0);
                result = result * 23 + ((Address != null) ? this.Address.GetHashCode() : 0);
                result = result * 23 + ((PhoneNumber != null) ? this.PhoneNumber.GetHashCode() : 0);
                result = result * 23 + ((Email != null) ? this.Email.GetHashCode() : 0);
                result = result * 23 + ((ID != null) ? this.ID.GetHashCode() : 0);
                return result;
            }
        }

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
            return Equals(this.Name, value.Name) &&
                   Equals(this.Address, value.Address) &&
                   Equals(this.PhoneNumber, value.PhoneNumber) &&
                   Equals(this.Email, value.Email) &&
                   Equals(this.ID, value.ID);
        }

        public override bool Equals(object obj)
        {
            BusinessPartner temp = obj as BusinessPartner;
            if (temp == null)
                return false;
            return this.Equals(temp);
        }

        public override string ToString()
        {
            var partnerInfo = new StringBuilder();

            foreach (var property in this.GetType().GetProperties())
            {
                partnerInfo.AppendFormat("{0}: {1} ", property.Name, property.GetValue(this));
            }

            return partnerInfo.ToString();
        }
    }
}