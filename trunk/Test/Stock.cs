namespace Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public static class Stock
    {
        private static readonly SortedSet<Goods> goodsInStock;

        static Stock()
        {
            goodsInStock = new SortedSet<Goods>();
        }

        public static void AddGoods(Goods item)
        {
            goodsInStock.Add(item);
        }

        public static void RemoveGoods(Goods item)
        {
            goodsInStock.Remove(item);
        }

        public static SortedSet<Goods> GetAllGoods()
        {
            return goodsInStock;
        }

        //public static ICollection<Goods> GetAllGoods()
        //{
        //    return goodsInStock as ICollection<Goods>;
        //}

        public static Goods GetGoodsByID(int id)
        {
            return goodsInStock.First(g => g.ID == id);
            // return goodsInStock.FirstOrDefault(g => g.ID == id);
        }

        public static Goods GetGoodsByName(string name)
        {
            return goodsInStock.First(g => g.Name == name);
            // return goodsInStock.FirstOrDefault(g => g.Name == name);
        }

        public static void SaveGoodsListToDB()
        {
            try
            {
                var writer = new StreamWriter("../../Goods.txt", false, Encoding.UTF8);

                using (writer)
                {
                    foreach (var item in goodsInStock)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}