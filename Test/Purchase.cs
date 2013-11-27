namespace Test
{
    using System;
    using System.Collections.Generic;

    [Serializable]
    public class Purchase : FinancialOperation
    {
        public new const string Category = "purchase";

        private readonly List<Goods> currentPurchaseGoodsList;
        private readonly List<Service> currentPurchaseServicesList;

        public Purchase(DateTime dateAndTime, int id) : base(dateAndTime, id)
        {
            currentPurchaseGoodsList = new List<Goods>();
            currentPurchaseServicesList = new List<Service>();
        }

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