using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_T
{
    internal class sqlconnection
    {
        void connect()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;database=c#_project;username=root;password=");
        }
    }
}
