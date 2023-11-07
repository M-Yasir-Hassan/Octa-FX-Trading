using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSSDG.BL;

namespace OSSDG.DL
{
    internal class ITEMDL
    {
        // ITEM BL LIST
        private static List<ITEMBL> ITEM_List = new List<ITEMBL>();
        internal static List<ITEMBL> ITEM_LISTS { get => ITEM_List; set => ITEM_List = value; }

        // ADD INTO ITEM LIST
        public static void add_item_list(ITEMBL I)
        {
            ITEM_List.Add(I);
        }

        //______________REDUCE QUANTITY_____________
        public static void reduceQuantity(int quant, ITEMBL item)
        {
            item.Quantity -= quant;
            ITEMDL.storeitem();
        }

        //___________INCREASE QUANTITY_____________
        public static void increaseQuantity(int quant, ITEMBL item)
        {
            item.Quantity += quant;
            ITEMDL.storeitem();
        }
        //  SEARCH LIST
        public static ITEMBL Search_list(string del)
        {
            foreach (ITEMBL s in ITEM_List)
            {
                if (s.Item == del)
                {
                    return s;
                }
            }
            return null;
        }

        // ITEM SORTING BY ASCENDING ORDER BY NAME
        public static void sort_ascending_name()
        {
            if (ITEM_List.Count != 0)
            {
                ITEM_List = ITEM_List.OrderBy(i => i.Item).ToList();
            }

        }
        public static ITEMBL SearchanItem(string searchstring)
        {
            foreach (ITEMBL i in ITEM_List)
            {
                if (searchstring == i.Item)
                {
                    return i;
                }
            }
            return null;
        }

        // ITEM SORTING BY ASCENDING ORDER BY NAME
        public static void sort_ascending_price()
        {
            if (ITEM_List.Count != 0)
            {
                ITEM_List = ITEM_List.OrderBy(p => p.Price).ToList();
            }
        }

        // LOAD ITEM
        public static void load_item()
        {
            string path = "item.txt";

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record = "";
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string item = splittedRecord[0];
                    float price = float.Parse(splittedRecord[1]);
                    int quantity = int.Parse(splittedRecord[2]);
                    int discount = int.Parse(splittedRecord[3]);
                    //  float newPrice = float.Parse(splittedRecord[4]);

                    ITEMBL I = new ITEMBL(item, price, quantity, discount);
                    // I.newPrice = newPrice;
                    add_item_list(I);
                }
                file.Close();
            }
        }

        // STORE ITEM
        public static void storeitem()
        {
            string path = "item.txt";
            if (File.Exists(path))
            {
                StreamWriter f = new StreamWriter(path);
                for (int i = 0; i < ITEM_List.Count; i++)
                {
                    if (i != 0) f.WriteLine();
                    f.Write(ITEM_List[i].Item + "," + ITEM_List[i].Price + "," + ITEM_List[i].Quantity + "," + ITEM_List[i].Discount);
                    f.Flush();
                }
                f.Close();
            }
        }

        //____________VALID ITEM______________
        public static ITEMBL isItemValid(ITEMBL I)
        {
            foreach (ITEMBL i in ITEM_List)
            {
                if (I.Item == i.Item && I.Price == i.Price && I.Quantity == I.Quantity && I.Discount == i.Discount)
                {
                    return i;
                }
            }
            return null;
        }

        //___________EDIT ITEM___________________
        public static void EditITEM_List(ITEMBL previous, ITEMBL edit)
        {
            foreach (ITEMBL item in ITEM_List)
            {
                if (item.Item == previous.Item && item.Price == previous.Price && item.Quantity == previous.Quantity)
                {
                    item.Item = edit.Item;
                    item.Price = edit.Price;
                    item.Quantity = edit.Quantity;
                    item.Discount = edit.Discount;
                }
            }
        }

        //_____________DELETE ITEM________________
        public static void deleteITEM(ITEMBL item)
        {
            for (int i = 0; i < ITEM_List.Count; i++)
            {
                if (ITEM_List[i].Item == item.Item && ITEM_List[i].Price == item.Price && ITEM_List[i].Quantity == item.Quantity && ITEM_List[i].Discount == item.Discount)
                {
                    ITEM_List.RemoveAt(i);
                }
            }
        }

        //_________PRINT ITEM____________
        public static void PrintanItem(ITEMBL i)
        {
            Console.WriteLine(i.Item + "\t\t" + i.Price + "\t\t" + i.Quantity + "\t\t" + i.Discount + "%");
        }
    }
}

