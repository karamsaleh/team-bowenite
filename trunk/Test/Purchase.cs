namespace Test
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines a purchase financial operation.
    /// </summary>
    [Serializable]
    public class Purchase : FinancialOperation
    {
        public new const string Category = "purchase";

        /// <summary>
        /// The list of goods to be purchased.
        /// </summary>
        private readonly List<Goods> currentPurchaseGoodsList;

        /// <summary>
        /// The list of services to be purchased.
        /// </summary>
        private readonly List<Service> currentPurchaseServicesList;

        /// <summary>
        /// Initializes a new instance of the <see cref="Purchase" /> class.
        /// </summary>
        /// <param name="dateAndTime">The date and time.</param>
        /// <param name="id">The id.</param>
        public Purchase(DateTime dateAndTime, int id) : base(dateAndTime, id)
        {
            currentPurchaseGoodsList = new List<Goods>();
            currentPurchaseServicesList = new List<Service>();
        }

        /// <summary>
        /// Adds the item to purchase list.
        /// </summary>
        /// <param name="item">The item.</param>
        public void AddItemToPurchaseList(Item item)
        {
            if (item is Goods)
            {
                currentPurchaseGoodsList.Add(item as Goods);
            }
            else if (item is Service)
            {
                currentPurchaseServicesList.Add(item as Service);
            }
        }
    }
}