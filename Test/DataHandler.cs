namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

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
            var goodsList = new List<Goods>();
            foreach (var line in this.LoadData("../../data/Goods.txt"))
            {
                string[] p = line.Split(';');
                goodsList.Add(new Goods(
                    int.Parse(p[0]), p[1], p[2], decimal.Parse(p[3]), decimal.Parse(p[4]), decimal.Parse(p[5]),
                    p[6], decimal.Parse(p[7])));
            }
            return goodsList;
        }

        public List<Client> LoadClients()
        {
            var clients = new List<Client>();
            foreach (var line in this.LoadData("../../data/Clients.txt"))
            {
                string[] p = line.Split(';');
                clients.Add(new Client(int.Parse(p[0]), p[1], p[2], p[3], p[4], p[5], p[6], p[7]));
            }
            return clients;
        }

        public List<Provider> LoadProviders()
        {
            var providers = new List<Provider>();
            foreach (var line in this.LoadData("../../data/Providers.txt"))
            {
                string[] p = line.Split(';');
                providers.Add(new Provider(int.Parse(p[0]), p[1], p[2], p[3], p[4], p[5], p[6], p[7]));
            }
            return providers;
        }

        public List<Sale> LoadSales()
        {
            var sales = new List<Sale>();
            foreach (var line in this.LoadData("../../data/Sales.txt"))
            {
                string[] p = line.Split(';');
                sales.Add(new Sale(DateTime.Parse(p[0]), int.Parse(p[2])));
            }
            return sales;
        }

        public List<Purchase> LoadPurchases()
        {
            var purchases = new List<Purchase>();
            foreach (var line in this.LoadData("../../data/Purchases.txt"))
            {
                string[] p = line.Split(';');
                purchases.Add(new Purchase(DateTime.Parse(p[0]), int.Parse(p[1])));
            }
            return purchases;
        }

        public void SaveGoods(IEnumerable<Goods> items)
        {
            this.SaveData(items, "../../data/Goods.txt", false);
        }

        public void SaveClients(IEnumerable<Client> clients)
        {
            this.SaveData(clients, "../../data/Clients.txt", false);
        }
        
        public void SaveProviders(IEnumerable<Provider> providers)
        {
            this.SaveData(providers, "../../data/Providers.txt", false);
        }

        public void SaveSales(IEnumerable<Sale> sales)
        {
            this.SaveData(sales, "../../data/Sales.txt", false);
        }

        public void SavePurchases(IEnumerable<Purchase> purchases)
        {
            this.SaveData(purchases, "../../data/Purchases.txt", false);
        }

        private List<string> LoadData(string source)
        {
            var lines = new List<string>();
            using (var reader = new StreamReader(source))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    lines.Add(line);
                }
            }
            return lines;
        }

        //private List<object> LoadData(string source, object obj)
        //{
        //    List<object> result = new List<object>();
        //    using (StreamReader reader = new StreamReader(source, Encoding.UTF8))
        //    {
        //        while (true)
        //        {
        //            string line = reader.ReadLine();
        //            if (line == null)
        //            {
        //                break;
        //            }
        //            string[] propertyValues = line.Split(';');
        //            int i = 0;

        //            foreach (var property in obj.GetType().GetProperties())
        //            {
        //                property.SetValue(obj, Convert.ChangeType(propertyValues[i++], property.PropertyType));
        //            }
        //            result.Add(obj);
        //        }
        //    }

        //    return result;
        //}

        private void SaveData(IEnumerable<object> items, string destination, bool append)
        {
            using (StreamWriter writer = new StreamWriter(destination, append, Encoding.UTF8))
            {
                foreach (var item in items)
                {
                    writer.WriteLine(item);
                }
            }
        }
    }
}
