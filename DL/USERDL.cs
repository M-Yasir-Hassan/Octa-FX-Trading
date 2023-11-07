using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSSDG.BL;

namespace OSSDG.DL
{
    internal class USERDL
    {
        private static List<USERBL> USERS_LIST = new List<USERBL>();

       internal static List<USERBL> USERS_LISTS { get => USERS_LIST; set => USERS_LIST = value; }

        // ADD INTO USER LIST
        public static void Add_User_List(USERBL s)
        {
            USERS_LIST.Add(s);
        }

        // SEARCH USER LIST
        public static bool Search_user_List(string name)
        {
            if (USERS_LIST.Count != 0)
            {
                foreach (USERBL s in USERS_LIST)
                {
                    if (name == s.UserNames)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // VALID USER
        public static USERBL isUserValid(string userNames, string passWords, string roles)
        {
            foreach (USERBL i in USERS_LIST)
            {
                if (userNames == i.UserNames && passWords == i.PassWords && roles == i.Roles)
                {
                    return i;
                }
            }
            return null;
        }

        // LOAD USER
        public static void loadUser()
        {
            string path = "user.txt";
            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);
                string record = "";
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string userNames = splittedRecord[0];
                    string passWords = splittedRecord[1];
                    string roles = splittedRecord[2];

                    USERBL u = new USERBL(userNames, passWords, roles);
                    Add_User_List(u);
                }
                f.Close();
            }
        }

        // STORE USER
        public static void storeUser()
        {
            string path = "user.txt";
            if (File.Exists(path))
            {
                StreamWriter f = new StreamWriter(path);
                for (int i = 0; i < USERS_LIST.Count; i++)
                {
                    if (i != 0) f.WriteLine();
                    f.Write(USERS_LIST[i].UserNames + "," + USERS_LIST[i].PassWords + "," + USERS_LIST[i].Roles);
                    f.Flush();
                }
                f.Close();
            }
        }

        //_________RETURN USER____________
        public static USERBL returnUser(string name)
        {
            foreach (USERBL u in USERS_LIST)
            {
                if (name == u.UserNames)
                {
                    return u;
                }
            }
            return null;
        }

        //____EDIT USER_________
        public static void EditUser_List(USERBL previous, USERBL update)
        {
            foreach (USERBL user in USERS_LIST)
            {
                if (user.UserNames == previous.UserNames && user.PassWords == previous.PassWords)
                {
                    user.UserNames = update.UserNames;
                    user.PassWords = update.PassWords;
                    user.Roles = update.Roles;
                }
            }

        }

        //__________DELETE USER______________
        public static void deleteuser(USERBL u)
        {
            for(int i =0; i< USERS_LIST.Count; i++)
            {
                if(USERS_LIST[i].UserNames == u.UserNames && USERS_LIST[i].PassWords == u.PassWords && USERS_LIST[i].Roles == u.Roles)
                {
                    USERS_LIST.RemoveAt(i);
                }
            }
        }
    }
}

