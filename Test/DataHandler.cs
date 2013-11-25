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

        public void SaveGoods(List<Goods> items)
        {
            using (StreamWriter writer = new StreamWriter("../../data/Goods.txt", false))
            {
                foreach (var item in items)
                {
                    writer.WriteLine(item);
                }
            }
        }
    }
}
