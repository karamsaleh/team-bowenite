namespace Test
{
    public abstract class Goods
    {
        protected Goods(string measurement, string category, decimal quantity, decimal salesPrice, decimal discount = 0, decimal value, int code)
        {
            this.Measurement = measurement;
            this.Category = category;
            this.Quantity = quantity;
            this.SalesPrice = salesPrice;
            this.Discount = discount;
            this.Value = value;
            this.Code = code;
        }

        public string Measurement { get; protected set; }

        public string Category { get; protected set; }

        public decimal Quantity { get; protected set; }

        public decimal SalesPrice { get; protected set; }

        public decimal Discount { get; protected set; }

        public decimal Value { get; protected set; }

        public int Code { get; protected set; }

        public decimal TotalPrice 
        {
            get
            {
                return this.SalesPrice - (this.SalesPrice * (this.Discount / 100));
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + ((Measurement != null) ? this.Measurement.GetHashCode() : 0);
                result = result * 23 + ((Category != null) ? this.Category.GetHashCode() : 0);
                result = result * 23 + this.Quantity.GetHashCode();
                result = result * 23 + this.SalesPrice.GetHashCode();
                result = result * 23 + this.Discount.GetHashCode();
                result = result * 23 + this.Value.GetHashCode();
                result = result * 23 + this.Code.GetHashCode();
                return result;
            }
        }

        public bool Equals(Goods value)
        {
            if (ReferenceEquals(null, value))
            {
                return false;
            }
            if (ReferenceEquals(this, value))
            {
                return true;
            }
            return Equals(this.Measurement, value.Measurement) &&
                   Equals(this.Category, value.Category) &&
                   this.Quantity == value.Quantity &&
                   this.SalesPrice == value.SalesPrice &&
                   this.Discount == value.Discount &&
                   this.Value == value.Value &&
                   this.Code == value.Code;
        }

        public override bool Equals(object obj)
        {
            Goods temp = obj as Goods;
            if (temp == null)
                return false;
            return this.Equals(temp);
        }

        public override string ToString()
        {
            return string.Format("Measurement: {0}, Category: {1}, Quantity: {2}, SalesPrice: {3}, Discount: {4}, Value: {5}, Code: {6}, TotalPrice: {7}", Measurement, Category, Quantity, SalesPrice, Discount, Value, Code, TotalPrice);
        }
    }
}