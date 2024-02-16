using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M_T
{
    public partial class A_Movie : Form
    {
        public A_Movie()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            string f = "C:\\check.mp4";
            axWindowsMediaPlayer1.URL = f;



        }
    }
}