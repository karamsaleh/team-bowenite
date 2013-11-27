namespace Test
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines a sale financial operation.
    /// </summary>
    [Serializable]
    public class Sale : FinancialOperation
    {
        public new const string Category = "sale";

        /// <summary>
        /// The list of goods to be sold.
        /// </summary>
        private readonly List<Goods> currentSaleGoodsList;

        /// <summary>
        /// The list of services to be sold.
        /// </summary>
        private readonly List<Service> currentSaleServicesList;

        /// <summary>
        /// Initializes a new instance of the <see cref="Sale" /> class.
        /// </summary>
        /// <param name="dateAndTime">The date and time.</param>
        /// <param name="id">The id.</param>
        public Sale(DateTime dateAndTime, int id) : base(dateAndTime, id)
        {
            currentSaleGoodsList = new List<Goods>();
            currentSaleServicesList = new List<Service>();
        }

        /// <summary>
        /// Adds the item to sale list.
        /// </summary>
        /// <param name="item">The item.</param>
        public void AddItemToSaleList(Item item)
        {
            if (item is Goods)
            {
                currentSaleGoodsList.Add(item as Goods);
            }
            else if (item is Service)
            {
                currentSaleServicesList.Add(item as Service);
            }
        }
    }
}