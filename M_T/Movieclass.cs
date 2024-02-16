using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_T
{
    public static class Movieclass
    {
        public static string movie { get; private set; }

        public static void SetMovie(string film)
        {
            movie = film;
        }
    }

}
