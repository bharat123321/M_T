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
    public partial class movielist : Form
    {
        public movielist()
        {
            InitializeComponent();
        }

        private void movielist_Load(object sender, EventArgs e)
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
                movie_list.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
