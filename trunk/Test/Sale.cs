namespace Test
{
    using System;
    using System.Collections.Generic;

    public class Sale : FinancialOperation
    {
        public new const string Category = "sale";

        private readonly List<Goods> currentSaleGoodsList;
        private readonly List<Service> currentSaleServicesList;

        public Sale(DateTime dateAndTime, int id) : base(dateAndTime, id)
        {
            currentSaleGoodsList = new List<Goods>();
            currentSaleServicesList = new List<Service>();
        }

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