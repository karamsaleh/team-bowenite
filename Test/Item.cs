namespace Test
{
    using System;
    using System.Text;

    public abstract class Item : ISellable, IPurchasable
    {
        public const string Category = "item";

        protected Item(string name, decimal salesPrice, decimal value, int id, decimal discount = 0)
        {
            this.Name = name;
            this.SalesPrice = salesPrice;
            this.Value = value;
            this.ID = id;
            this.Discount = discount;
        }

        public int ID { get; protected set; }

        public string Name { get; protected set; }

        public decimal SalesPrice { get; protected set; }

        public decimal Discount { get; protected set; }

        public decimal Value { get; protected set; }


        public decimal PriceWithDiscount
        {
            get
            {
                return this.SalesPrice - (this.SalesPrice * (this.Discount / 100));
            }
        }

        public decimal FinalPriceWithVat
        {
            get
            {
                return this.PriceWithDiscount * 1.2M;
            }
        }

        public virtual void Sell() { }

        public virtual void Buy() { }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + ((Name != null) ? this.Name.GetHashCode() : 0);
                result = result * 23 + this.SalesPrice.GetHashCode();
                result = result * 23 + this.Discount.GetHashCode();
                result = result * 23 + this.Value.GetHashCode();
                result = result * 23 + this.ID.GetHashCode();
                return result;
            }
        }

        public bool Equals(Item value)
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
                   this.SalesPrice == value.SalesPrice &&
                   this.Discount == value.Discount &&
                   this.Value == value.Value &&
                   this.ID == value.ID;
        }

        public override bool Equals(object obj)
        {
            Item temp = obj as Item;
            if (temp == null)
                return false;
            return this.Equals(temp);
        }

        public override string ToString()
        {
            var itemInfo = new StringBuilder();

            foreach (var property in this.GetType().GetProperties())
            {
                itemInfo.AppendFormat("{0} ,", property.GetValue(this));
            }

            return itemInfo.ToString();
        }
    }
}