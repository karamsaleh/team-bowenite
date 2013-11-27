namespace Test
{
    using System;

    /// <summary>
    /// Defines a stock item in the warehouse.
    /// </summary>
    [Serializable]
    public class Goods : Item
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Goods" /> class.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="category">The category.</param>
        /// <param name="name">The name.</param>
        /// <param name="salesPrice">The sales price.</param>
        /// <param name="discount">The discount.</param>
        /// <param name="value">The value.</param>
        /// <param name="measurement">The measurement.</param>
        /// <param name="quantity">The quantity.</param>
        public Goods(int id, string category, string name, decimal salesPrice, decimal discount,
            decimal value, string measurement, decimal quantity)
            : base(id, category, name, salesPrice, discount, value)
        {
            this.Measurement = measurement;
            this.Quantity = quantity;
        }

        /// <summary>
        /// The measurement used by the current object.
        /// </summary>
        /// <value>The measurement of the current object.</value>
        public string Measurement { get; set; }

        /// <summary>
        /// The quantity the current object comes in.
        /// </summary>
        /// <value>The quantity.</value>
        /// <remarks>The quantity is evaluated by the measurement of the object.</remarks>
        public decimal Quantity { get; set; }
    }
}