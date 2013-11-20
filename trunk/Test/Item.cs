namespace Test
{
    using System;
    using System.Text;

    public abstract class Item : ISellable
    {
        protected Item(string category, decimal salesPrice, decimal discount = 0, decimal value, int code)
        {
            this.Category = category;
            this.SalesPrice = salesPrice;
            this.Discount = discount;
            this.Value = value;
            this.Code = code;
        }

        public virtual string Category { get; protected set; }

        public decimal SalesPrice { get; protected set; }

        public decimal Discount { get; protected set; }

        public decimal Value { get; protected set; }

        public int Code { get; protected set; }

        public decimal FinalPrice
        {
            get
            {
                return this.SalesPrice - (this.SalesPrice * (this.Discount / 100));
            }
        }

        public virtual void Sell()
        {
            //
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + ((Category != null) ? this.Category.GetHashCode() : 0);
                result = result * 23 + this.SalesPrice.GetHashCode();
                result = result * 23 + this.Discount.GetHashCode();
                result = result * 23 + this.Value.GetHashCode();
                result = result * 23 + this.Code.GetHashCode();
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
            return Equals(this.Category, value.Category) &&
                   this.SalesPrice == value.SalesPrice &&
                   this.Discount == value.Discount &&
                   this.Value == value.Value &&
                   this.Code == value.Code;
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
                itemInfo.AppendFormat("{0}: {1} ", property.Name, property.GetValue(this));
            }

            return itemInfo.ToString();
        }
    }
}