namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DataHandler
    {
        private const string PathToGoodsFile = "../../data/Goods.txt";
        private const string PathToClientsFile = "../../data/Clients.txt";
        private const string PathToProvidersFile = "../../data/Providers.txt";
        private const string PathToSalesFile = "../../data/Sales.txt";
        private const string PathToPurchasesFile = "../../data/Purchases.txt";

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

        private IEnumerable<object> LoadData(string source, object obj)
        {
            var data = new List<object>();
            var properties = obj.GetType().GetProperties();

            using (var reader = new StreamReader(source, Encoding.UTF8))
            {
                var line = reader.ReadLine();

                while (!String.IsNullOrEmpty(line))
                {
                    var values = line.Split(';');

                    // Sets all properties of obj to the correspoding values extracted from source
                    // Values are sequentially being parsed to the corresponding type of the property
                    for (int i = 0; i < properties.Length; i++)
                    {
                        var currentProperty = properties[i];
                        if (currentProperty.CanWrite)
                        {
                            properties[i].SetValue(obj, Convert.ChangeType(values[i], properties[i].PropertyType));                            
                        }
                    }

                    // Adds a deep copy of obj to data list
                    data.Add(obj.Clone());

                    line = reader.ReadLine();
                }
            }

            return data as IEnumerable<object>;
        }

        public IEnumerable<Goods> LoadGoods()
        {
            var goods = new Goods(0, null, null, 0m, 0m, 0m, null, 0m);
            return this.LoadData(PathToGoodsFile, goods).Cast<Goods>();
        }

        public IEnumerable<Client> LoadClients()
        {
            var client = new Client(0, null, null, null, null, null, null, null);
            return this.LoadData(PathToClientsFile, client).Cast<Client>();
        }

        public IEnumerable<Provider> LoadProviders()
        {
            var provider = new Provider(0, null, null, null, null, null, null, null);
            return this.LoadData(PathToProvidersFile, provider).Cast<Provider>();
        }

        public IEnumerable<Sale> LoadSales()
        {
            var sale = new Sale(default(DateTime), 0);
            return this.LoadData(PathToSalesFile, sale).Cast<Sale>();
        }

        public IEnumerable<Purchase> LoadPurchases()
        {
            var purchase = new Purchase(default(DateTime), 0);
            return this.LoadData(PathToPurchasesFile, purchase).Cast<Purchase>();
        }

        public void SaveGoods(IEnumerable<Goods> items)
        {
            this.SaveData(items, PathToGoodsFile);
        }

        public void SaveClients(IEnumerable<Client> clients)
        {
            this.SaveData(clients, PathToClientsFile);
        }

        public void SaveProviders(IEnumerable<Provider> providers)
        {
            this.SaveData(providers, PathToProvidersFile);
        }

        public void SaveSales(IEnumerable<Sale> sales)
        {
            this.SaveData(sales, PathToSalesFile);
        }

        public void SavePurchases(IEnumerable<Purchase> purchases)
        {
            this.SaveData(purchases, PathToPurchasesFile);
        }

        private void SaveData(IEnumerable<object> items, string destination)
        {
            using (var writer = new StreamWriter(destination, false, Encoding.UTF8))
            {
                foreach (var item in items)
                {
                    writer.WriteLine(item);
                }
            }
        }
    }
}