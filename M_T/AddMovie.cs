using M_T;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace M_T
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string error;
            MySqlConnection con = new MySqlConnection("Server=localhost;database=c#_project;username=root;password=");
            try
            {
                con.Open();
                if (m_n.Text == "" || price.Text == "" || releasedate.Text == "")
                {
                    MessageBox.Show("Please Fill the blanks");
                }
                else
                {
                    String sql = "select 'Movie Name' from movie_inf where Movie_Name = '" + m_n.Text + "'";


                    MySqlCommand sqlcom = new MySqlCommand(sql, con);
                    MySqlDataReader myre;
                    myre = sqlcom.ExecuteReader();
                    if (myre.Read())
                    {

                        MessageBox.Show(m_n.Text + " already Exit");
                    }
                    else
                    {
                        myre.Close();

                     
                      
                            String query = "insert into movie_inf values(null,@movie_name,@price,@releasedate)";
                            MySqlCommand comm = new MySqlCommand(query, con);
                            comm.Parameters.AddWithValue("@movie_name", m_n.Text);
                            comm.Parameters.AddWithValue("@price", price.Text);
                            comm.Parameters.AddWithValue("@releasedate", releasedate.Text);
                             
                            comm.ExecuteNonQuery();
                            MessageBox.Show("Insert");
                        }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}




 
