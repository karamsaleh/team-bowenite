namespace Test
{
    using System;
    using System.Collections.Generic;

    public class Sale : FinancialOperations
    {
        private readonly SortedSet<Goods> currentSaleGoodsList;
        private readonly SortedSet<Service> currentSaleServicesList;

        public Sale(DateTime dateAndTime, int id) : base(dateAndTime, id)
        {
            currentSaleGoodsList = new SortedSet<Goods>();
            currentSaleServicesList = new SortedSet<Service>();
        }

        public void AddItemToSalesList(Item item)
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