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

        private void admin_dasboard_Load(object Form)
        {
            if (this.changepanel.Controls.Count > 0)
            {
                this.changepanel.Controls.RemoveAt(0);
                Form f = Form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Bottom;
                this.changepanel.Controls.Add(f);
                this.changepanel.Tag = f;
                f.Show();
            }
        }

        private void addmovie_Click(object sender, EventArgs e)
        {
            admin_dasboard_Load(new AddMovie());
        }
    }
}
