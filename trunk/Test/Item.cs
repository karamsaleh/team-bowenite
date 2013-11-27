namespace Test
{
    using System;
    using System.Text;

    /// <summary>
    /// The base class of all warehouse items that can be traded. All types that can be sold or purchased inherit this class.
    /// </summary>
    [Serializable]
    public abstract class Item : ISellable, IPurchasable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="category">The category.</param>
        /// <param name="name">The name.</param>
        /// <param name="salesPrice">The sales price.</param>
        /// <param name="discount">The discount.</param>
        /// <param name="value">The value.</param>
        protected Item(int id, string category, string name, decimal salesPrice, decimal discount, decimal value)
        {
            this.ID = id;
            this.Category = category;
            this.Name = name;
            this.SalesPrice = salesPrice;
            this.Discount = discount;
            this.Value = value;
            new object().Equals(new object());
        }

        /// <summary>
        /// Gets or sets the current object's ID.
        /// </summary>
        /// <value>The ID of the current object.</value>
        public int ID { get; protected set; }

        /// <summary>
        /// Gets or sets the current object's category.
        /// </summary>
        /// <value><The category of the current object./value>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the current object's name.
        /// </summary>
        /// <value>The name of the current object.</value>
        public string Name { get; protected set; }

        /// <summary>
        /// Gets or sets the current object's sale price.
        /// </summary>
        /// <value>The sale price of the current object.</value>
        public decimal SalesPrice { get; protected set; }

        /// <summary>
        /// Gets or sets the current object's discount.
        /// </summary>
        /// <value>The discount for the current object.</value>
        public decimal Discount { get; protected set; }

        /// <summary>
        /// Gets or sets the current object's value.
        /// </summary>
        /// <value>The value of the current object.</value>
        public decimal Value { get; protected set; }


        /// <summary>
        /// Gets the price with discount.
        /// </summary>
        /// <value>The price with discount.</value>
        public decimal PriceWithDiscount
        {
            get
            {
                return this.SalesPrice - (this.SalesPrice * (this.Discount / 100));
            }
        }

        /// <summary>
        /// Gets the final price with vat.
        /// </summary>
        /// <value>The final price with vat.</value>
        public decimal FinalPriceWithVat
        {
            get
            {
                return this.PriceWithDiscount * 1.2M;
            }
        }

        /// <summary>
        /// Sells this instance.
        /// </summary>
        public virtual void Sell()
        {
            Treasury.Turnover += this.FinalPriceWithVat;
            Treasury.Profit += (this.FinalPriceWithVat - this.Value);
        }

        /// <summary>
        /// Buys this instance.
        /// </summary>
        public virtual void Buy()
        {
            Treasury.Turnover -= this.Value;
        }

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
                result = result * 23 + ((Category != null) ? this.Category.GetHashCode() : 0);
                result = result * 23 + ((Name != null) ? this.Name.GetHashCode() : 0);
                result = result * 23 + this.SalesPrice.GetHashCode();
                result = result * 23 + this.Discount.GetHashCode();
                result = result * 23 + this.Value.GetHashCode();
                return result;
            }
        }

        /// <summary>
        /// Equalses the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
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
            return this.ID == value.ID &&
                   Equals(this.Category, value.Category) &&
                   Equals(this.Name, value.Name) &&
                   this.SalesPrice == value.SalesPrice &&
                   this.Discount == value.Discount &&
                   this.Value == value.Value;
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
            Item temp = obj as Item;
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
            var itemInfo = new StringBuilder();

            foreach (var property in this.GetType().GetProperties())
            {
                // temporary solution, have to add user input categories choice
                this.GetType().GetProperty("Category").SetValue(this, "new");
                itemInfo.AppendFormat("{0};", property.GetValue(this));
            }

            return itemInfo.ToString();
        }
    }
}