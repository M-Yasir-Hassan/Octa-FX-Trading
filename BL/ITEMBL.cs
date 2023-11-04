using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSSDG.BL
{
    public class ITEMBL
    {
        private string item;
        private float price;
        private int quantity;
        private int discount;
        private float newPrice;

        public string Item { get => item; set => item = value; }
        public float Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Discount { get => discount; set => discount = value; }
        public float NewPrice { get => newPrice; set => newPrice = value; }
        
        // PARAMETR CONSTRUCTOR
        public ITEMBL(string item, float price, int quantity, int discount)
        {
            this.item = item;
            this.price = price;
            this.quantity = quantity;
            this.discount = discount;
            this.newPrice = price - (discount * price / 100f);
        }

        public ITEMBL()
        {
        }

        // PRICE DISCOUNT
        public static float priceAfterDiscount(float price, float discount)
        {
            float newPrice = (float)(price - (price * (discount / 100.0)));
            return newPrice;
        }
    }
}

