namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class DataHandler
    {
        private static DataHandler instance;

        public static DataHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataHandler();
                }
                return instance;
            }
        }

        public List<Goods> LoadGoods()
        {
            List<Goods> result = new List<Goods>();
            using (StreamReader reader = new StreamReader("../../data/Goods.txt"))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    string[] p = line.Split(';');
                    result.Add(new Goods(
                        int.Parse(p[0]), p[1], p[2], decimal.Parse(p[3]), decimal.Parse(p[4]), decimal.Parse(p[5]),
                        p[6], decimal.Parse(p[7])));
                }
            }
            return result;
        }

        public void SaveGoods(IEnumerable<Goods> items)
        {
            this.SaveData(items, "../../data/Goods.txt", false);
        }

        public void SaveClients(IEnumerable<Client> clients)
        {
            this.SaveData(clients, "../../data/Clients.txt", false);
        }

        public void SaveSales(IEnumerable<Sale> sales)
        {
            this.SaveData(sales, "../../data/Sales.txt", false);
        }

        public void SavePurchases(IEnumerable<Purchase> purchases)
        {
            this.SaveData(purchases, "../../data/Purchases.txt", false);
        }

        public void SaveProviders(IEnumerable<Provider> providers)
        {
            this.SaveData(providers, "../../data/Providers.txt", false);
        }

        private void SaveData(IEnumerable<object> items, string destination, bool append)
        {
            using (StreamWriter writer = new StreamWriter(destination, append))
            {
                foreach (var item in items)
                {
                    writer.WriteLine(item);
                }
            }
        }
    }
}
