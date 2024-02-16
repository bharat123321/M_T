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
        public dashboard()
        {
            InitializeComponent();
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
                String query = "select * from movie_info ";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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
                string query = "select * from movie_info where `Movie Name` like '%" + s + "%'";
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception es)
            {

            }


        }

        private void Buy_ticket_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            buypanel.Show();
        }

        private void buypanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
