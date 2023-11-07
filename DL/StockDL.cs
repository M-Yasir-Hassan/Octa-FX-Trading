using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSSDG.BL;

namespace OSSDG.DL
{
    internal class StockDL
    {
        private static List<StockBL> allstocks = new List<StockBL>();
        internal static List<StockBL> AllSTOCKS { get => allstocks; set => allstocks = value; }

        // ADD INTO LIST
        public static void add_stock(StockBL stock)
        {
            allstocks.Add(stock);
        }

        public static StockBL find_stock(string userName, string passWord)
        {
            foreach (StockBL stock in allstocks)
            {
                if (stock.stock.UserNames == userName && stock.stock.PassWords == passWord)
                {
                    return stock;
                }
            }
            return null;
        }
    }
}
