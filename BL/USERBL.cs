using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSSDG.BL
{
    public class USERBL
    {
        private string userNames;
        private string passWords;
        private string roles;

        // GET AND SETTERS
        
        public string UserNames { get => userNames;  set => userNames = value;}
        public string PassWords { get => passWords; set => passWords = value;}
        public string Roles { get => roles; set => roles = value;}

        // PARAMETER USER CONSTRUCTOR
        public USERBL(string userNames, string passWords, string roles)
        {
            this.userNames = userNames;
            this.passWords = passWords;
            this.roles = roles;
        }

        public USERBL()
        {

        }
    }
}
