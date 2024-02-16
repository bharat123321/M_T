using MySql.Data.MySqlClient;
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
    public partial class dashboard : Form
    {
        List<Panel> listpanel = new List<Panel>();
        int index;
        private string email;
        public dashboard()
        {
            InitializeComponent();
            
        }
       

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetEmail()
        {
            return email;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection("server=localhost;database=c#_project;username=root;password=");
            try
            {
                conn.Open();
                String query = "select * from movie_inf ";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection("server=localhost;database=c#_project;username=root;password=");
            try
            {
                conn.Open();
                String s = search_box.Text;
                string query = "select * from movie_inf where `Movie_Name` like '%" + s + "%'";
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView.DataSource = dt;
                conn.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }


        }

        private void Buy_ticket_Click(object sender, EventArgs e)
        {

            if (this.check.Controls.Count > 0)
            {
                this.check.Controls.RemoveAt(0);
            }
             
            Form f = new buymovie();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.check.Controls.Add(f);
            this.check.Tag = f;
            f.Show();
            
        }

        private void buypanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void trailer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void movie_trailer_Click(object sender, EventArgs e)
        {
            if (this.check.Controls.Count > 0)
            {
                this.check.Controls.RemoveAt(0);
            }

            Form f = new A_Movie();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.check.Controls.Add(f);
            this.check.Tag = f;
            f.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void movielist_Click(object sender, EventArgs e)
        {
            if (this.check.Controls.Count > 0)
            {
                this.check.Controls.RemoveAt(0);
            }

            Form f = new movielist();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.check.Controls.Add(f);
            this.check.Tag = f;
            f.Show();
        }
    }
}
