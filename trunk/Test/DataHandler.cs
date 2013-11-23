using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class DataHandler
    {
        public static List<Goods> LoadGoods()
        {
            List<Goods> result = new List<Goods>();
            using (StreamReader reader = new StreamReader("../../Goods.txt"))
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
    }
}
