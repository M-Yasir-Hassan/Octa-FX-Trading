using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSSDG.BL;

namespace OSSDG.BL
{
    public class StockBL
    {
        public USERBL stock;

        public List<ITEMBL> allorderItems;
        
        public StockBL(USERBL stock, List<ITEMBL> allorderItems)
        {
            this.stock = stock;
            this.allorderItems = allorderItems;
        }

        // Order ITEM
        public void ORDERItem(ITEMBL item, int quant)
        {
            bool alreadyExist = false;
            foreach (ITEMBL i in allorderItems)
            {
                if (item == i)
                {
                    i.Quantity = quant;
                    alreadyExist = true;
                }
            }
            if (alreadyExist != true)
            {
                ITEMBL temp = new ITEMBL(item.Item, item.Price, item.Discount, quant);
                allorderItems.Add(temp);
            }
        }
    }
}
