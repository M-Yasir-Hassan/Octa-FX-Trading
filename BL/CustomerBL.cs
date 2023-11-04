using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSSDG.BL
{
    public class CustomerBL
    {
        public USERBL customer;
        
        public List<ITEMBL> allBuyedItems;
        
        public CustomerBL(USERBL customer, List<ITEMBL> allBuyedItems)
        {
            this.customer = customer;
            this.allBuyedItems = allBuyedItems;
        }

        //  TOTAL BILL
        public float totalBill()
        {
            float total = 0;
            foreach (ITEMBL i in allBuyedItems)
            {
                float totalofanItem = i.NewPrice * i.Quantity;
                total += totalofanItem;
            }
            return total;
        }

        // BUY ITEM
        public  void BuyItem(ITEMBL item, int quant)
        {
            bool alreadyExist = false;
            foreach (ITEMBL i in allBuyedItems)
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
                allBuyedItems.Add(temp);
            }
        }
    }
}

