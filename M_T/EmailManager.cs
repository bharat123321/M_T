using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_T
{
    public static class  EmailManager
    {
        public static string UserEmail { get; private set; }

        public static void SetEmail(string email)
            {
                UserEmail = email;  
            }

            
        

    }
}
