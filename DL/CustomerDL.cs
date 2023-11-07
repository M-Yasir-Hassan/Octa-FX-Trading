using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSSDG.BL;

namespace OSSDG.DL
{
    internal class CustomerDL
    {
        public static List<CustomerBL> allCustomers = new List<CustomerBL>();
       // int static List<CustomerBL> AllCustomers { get => allCustomers; set => allCustomers = value; }

        // FIND CUSTOMER
        public static CustomerBL findCust(string username, string password ,string roles)
        {
            foreach (CustomerBL cust in allCustomers)
            {
                if (cust.customer.UserNames == username && cust.customer.PassWords == password && cust.customer.Roles == roles)
                {
                    return cust;
                }
            }
            return null;
        }

        // ADD INTO LIST
        public static void add_list(CustomerBL cust)
        {
            allCustomers.Add(cust);
        }

        // STORE CUSTOMER
        public static void storeCustomer()
        {
            string path = "customers.txt";
            int i = 0;
            if (File.Exists(path))
            {
                StreamWriter file = new StreamWriter(path);
                foreach (CustomerBL c in CustomerDL.allCustomers)
                {
                    if (i != 0) file.WriteLine();
                    file.Write(c.customer.UserNames + ",");
                    int j = 0;
                    foreach (ITEMBL item in c.allBuyedItems)
                    {
                        file.Write(item.Item + ";" + item.Quantity);
                        if (j != c.allBuyedItems.Count - 1) file.Write('|');
                        j++;
                    }
                    i++;
                }
                file.Close();
            }
        }

        // LOAD CUSTOMER
        public static void loadCustomer()
        {
            string path = "customers.txt";
            string record = "";
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                while ((record = file.ReadLine()) != null)
                {
                    string[] firstSplit = record.Split(',');
                    USERBL user = USERDL.returnUser(firstSplit[0]);
                    CustomerBL c = new CustomerBL(user, new List<ITEMBL>());
                    string[] items = firstSplit[1].Split('|');
                    foreach (string item in items)
                    {
                        string[] products = item.Split(';');
                        ITEMBL i = ITEMDL.Search_list(products[0]);
                        i.Quantity = int.Parse(products[1]);
                        c.allBuyedItems.Add(i);
                    }
                }
                file.Close();
            }
        }

    }
}

