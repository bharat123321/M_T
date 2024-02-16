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
    public partial class buymovie : Form
    {
        public string email;
        List<string> movieNames = new List<string>();
        public buymovie()
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buymovie_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;database=c#_project;username=root;password=");
            try
            {
                con.Open();

                DateTime currentDate = DateTime.Now.Date;

                string query = "SELECT Release_Date, Movie_Name FROM movie_inf";

                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime releaseDate = reader.GetDateTime("Release_Date");
                            string movieName = reader.GetString("Movie_Name");

                            // Calculate the difference in days between the release date and the current date
                            TimeSpan difference = currentDate - releaseDate;
                            int daysDifference = (int)difference.TotalDays;

                            // Check if the movie is available within 30 days of release
                            if (daysDifference >= -2 && daysDifference <= 30)
                            {
                                s_movie.Items.Add(movieName);
                            }
                        }
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

        private void button1_Click(object sender, EventArgs e)
        {

            
            MySqlConnection con = new MySqlConnection("Server=localhost;database=c#_project;username=root;password=");
            try
            {
                con.Open();
                string query = "select * from movie_inf ";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@userEmail", EmailManager.UserEmail);
                string moviename;
                using (MySqlDataReader dr = command.ExecuteReader())
                {


                    while (dr.Read())
                    {
                        moviename = dr.GetString(dr.GetOrdinal("Movie_Name"));
                         
                        movieNames.Add(moviename);
                         
                    }
                    if (movieNames.Contains(s_movie.Text))
                    {
                         
                        this.Hide();
                        seat s = new seat();
                        s.Show();
                        MessageBox.Show(s_movie.Text);
                        Movieclass.SetMovie(s_movie.Text);
                        /*s.SetMovie(s_movie.Text);*/
                    }
                    else
                    {
                        MessageBox.Show("Movie not Selected: " + s_movie.Text);
                    }
                    
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;database=c#_project;username=root;password=");
            try
            {
                con.Open();
                string query = "select * from user where email=@userEmail";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@userEmail", EmailManager.UserEmail);
                int userId = -1;
                using (MySqlDataReader dr = command.ExecuteReader())
                {


                    if (dr.Read())
                    {
                        userId = dr.GetInt32(dr.GetOrdinal("id"));

                    }
                    if (userId != -1)
                    {
                        dr.Close();


                        string sql = "select price from seat where user_id=@user_id";
                        MySqlCommand comm = new MySqlCommand(sql, con);
                        comm.Parameters.AddWithValue("@user_id", userId);
                        MySqlDataReader rd;
                        rd = comm.ExecuteReader();
                        while (rd.Read())
                        {
                             rd.GetValue(0).ToString();
                        }
                    }
                    MessageBox.Show("Seats inserted Successfully");

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=c#_project;username=root;password=");
            try
            {
                conn.Open();

                string query = "select * from user where email=@userEmail";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@userEmail", EmailManager.UserEmail);
                int userId = -1;
                using (MySqlDataReader dr = command.ExecuteReader())
                {


                    if (dr.Read())
                    {
                        userId = dr.GetInt32(dr.GetOrdinal("id"));

                    }
                    if (userId != -1)
                    {
                        dr.Close();



                        string sql = "select * from seat where user_id=@user_id";
                        MySqlCommand comm = new MySqlCommand(sql, conn);
                        comm.Parameters.AddWithValue("@user_id", userId);
                        string arrayAsString = (string)comm.ExecuteScalar(); // Assuming array data is in a single column and row
                         

                        // Parse the string into an array
                        string[] dataArray = arrayAsString.Split(',');

                        // Now you can use the array data as needed
                        foreach (string item in dataArray)
                        {
                           MessageBox.Show(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
