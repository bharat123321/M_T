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
    public partial class admin_dasboard : Form
    {
        public admin_dasboard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

         public void admin_Load(object Form)
        {
            
        }

        private void addmovie_Click(object sender, EventArgs e)
        {
             
            if (this.changepanel.Controls.Count > 0)
            {
                this.changepanel.Controls.RemoveAt(0);
                Form f = new AddMovie();
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.changepanel.Controls.Add(f);
                this.changepanel.Tag = f;
                f.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (this.changepanel.Controls.Count > 0)
            {
                this.changepanel.Controls.RemoveAt(0);
                Form f = new Trailer();
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.changepanel.Controls.Add(f);
                this.changepanel.Tag = f;
                f.Show();
            }
        }

          
    }
}
