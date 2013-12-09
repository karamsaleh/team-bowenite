namespace Test
{
    /// <summary>
    /// Defines a service item in the warehouse.
    /// </summary>
    public class Service : Item
    {
        public Services TypesOfServices { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Service" /> class.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="category">The category.</param>
        /// <param name="name">The name.</param>
        /// <param name="salesPrice">The sales price.</param>
        /// <param name="discount">The discount.</param>
        /// <param name="value">The value.</param>
        public Service(int id, string category, string name, decimal salesPrice,
            decimal discount, decimal value, Services typesOfServices = Services.StockSafeKeeping) 
            : base(id, category, name, salesPrice, discount, value)
        {
            this.TypesOfServices = typesOfServices;
        }
    }
}