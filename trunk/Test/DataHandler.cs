namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Handles warehouse data operations. Implementation of the Singleton design pattern.
    /// </summary>
    public class DataHandler
    {
        /// <summary>
        /// The path to the file where the list of goods on stock is stored.
        /// </summary>
        private const string PathToGoodsFile = "../../data/Goods.txt";

        /// <summary>
        /// The path to the file where the warehouse clients' list is stored.
        /// </summary>
        private const string PathToClientsFile = "../../data/Clients.txt";

        /// <summary>
        /// The path to the file where the warehouse providers' list is stored.
        /// </summary>
        private const string PathToProvidersFile = "../../data/Providers.txt";

        /// <summary>
        /// The path to the file where the warehouse sales' list is stored.
        /// </summary>
        private const string PathToSalesFile = "../../data/Sales.txt";

        /// <summary>
        /// The path to the file where the warehouse purchases' list is stored.
        /// </summary>
        private const string PathToPurchasesFile = "../../data/Purchases.txt";

        private static DataHandler instance;

        /// <summary>
        /// The single instance of the DataHandler class
        /// </summary>
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

        /// <summary>
        /// Gets data from a source. For each line from the source file sets all properties of 
        /// any object with values extracted from that line. Each string value is converted to the corresponding property type.
        /// </summary>
        /// <param name="source">The path to the source file.</param>
        /// <param name="obj">An instance of the type to set the properties of.</param>
        /// <returns></returns>
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

                    for (int i = 0; i < properties.Length; i++)
                    {
                        var currentProperty = properties[i];

                        if (currentProperty.CanWrite)
                        {
                            var currentPropertyType = currentProperty.PropertyType;
                            // Nullable properties have to be treated differently, since we 
                            // use their underlying property to set the value in the object
                            if (currentPropertyType.IsGenericType && currentPropertyType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
                            {
                                if (values[i] == null)
                                {
                                    currentProperty.SetValue(obj, null);
                                }

                                // Get the underlying type property instead of the nullable generic
                                currentPropertyType = new NullableConverter(properties[i].PropertyType).UnderlyingType;
                            }
                            properties[i].SetValue(obj, Convert.ChangeType(values[i], currentPropertyType));
                        }
                    }

                    data.Add(obj.Clone());
                    line = reader.ReadLine();
                }
            }

            return data as IEnumerable<object>;
        }

        /// <summary>
        /// Loads goods' list from storage.
        /// </summary>
        /// <returns>A list of goods on stock.</returns>
        public IEnumerable<Goods> LoadGoods()
        {
            var goods = new Goods(0, null, null, 0m, 0m, 0m, null, 0m);
            return this.LoadData(PathToGoodsFile, goods).Cast<Goods>();
        }

        /// <summary>
        /// Loads clients' list from storage.
        /// </summary>
        /// <returns>A list of all warehouse clients.</returns>
        public IEnumerable<Client> LoadClients()
        {
            var client = new Client(0, null, null, null, null, null, null, null);
            return this.LoadData(PathToClientsFile, client).Cast<Client>();
        }

        /// <summary>
        /// Loads providers' list from storage.
        /// </summary>
        /// <returns>A list of all warehouse providers.</returns>
        public IEnumerable<Provider> LoadProviders()
        {
            var provider = new Provider(0, null, null, null, null, null, null, null);
            return this.LoadData(PathToProvidersFile, provider).Cast<Provider>();
        }

        /// <summary>
        /// Loads sales' list from storage.
        /// </summary>
        /// <returns>A list of all warehouse sales.</returns>
        public IEnumerable<Sale> LoadSales()
        {
            var sale = new Sale(default(DateTime), 0);
            return this.LoadData(PathToSalesFile, sale).Cast<Sale>();
        }

        /// <summary>
        /// Loads purchases' from storage.
        /// </summary>
        /// <returns>A list of all warehouse purchases.</returns>
        public IEnumerable<Purchase> LoadPurchases()
        {
            var purchase = new Purchase(default(DateTime), 0);
            return this.LoadData(PathToPurchasesFile, purchase).Cast<Purchase>();
        }

        /// <summary>
        /// Saves goods' list to storage.
        /// </summary>
        /// <param name="items">The list of goods to be saved.</param>
        public void SaveGoods(IEnumerable<Goods> items)
        {
            this.SaveData(items, PathToGoodsFile);
        }

        /// <summary>
        /// Saves clients' list to storage.
        /// </summary>
        /// <param name="clients">The list of clients to be saved.</param>
        public void SaveClients(IEnumerable<Client> clients)
        {
            this.SaveData(clients, PathToClientsFile);
        }

        /// <summary>
        /// Saves providers' list to storage.
        /// </summary>
        /// <param name="providers">The list of providers to be saved.</param>
        public void SaveProviders(IEnumerable<Provider> providers)
        {
            this.SaveData(providers, PathToProvidersFile);
        }

        /// <summary>
        /// Saves sales' list to storage.
        /// </summary>
        /// <param name="sales">The list of sales to be saved.</param>
        public void SaveSales(IEnumerable<Sale> sales)
        {
            this.SaveData(sales, PathToSalesFile);
        }

        /// <summary>
        /// Saves purchases' list to storage.
        /// </summary>
        /// <param name="purchases">The list of purchases to be saved.</param>
        public void SavePurchases(IEnumerable<Purchase> purchases)
        {
            this.SaveData(purchases, PathToPurchasesFile);
        }

        /// <summary>
        /// Saves a list of objects to a destination file.
        /// Each line of the file is populated sequentially with each object's property values.
        /// </summary>
        /// <param name="items">The list of objects to be saved.</param>
        /// <param name="destination">The path to the destination file.</param>
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