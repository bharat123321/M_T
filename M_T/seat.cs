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
    public partial class seat : Form
    {

        private int counter = 0;
        private List<string> seat_id = new List<string>(); // Declare as a List instead of an array
        private List<string> seat_value = new List<string>();
        List<string> movieNames = new List<string>();
        private bool increasePerformed = false;
        private bool seatinsert = false;
        private static bool seatchecks = false;
         
        public seat()
        {
            InitializeComponent();
            price_l.Text = "0";
            this.Load += seat_Load;
            
        }
        
        private void DecreraseCounterBy(int value)
        {
            counter -= value;
            price_l.Text = counter.ToString();
        }
        public void seatcheck()
        {
            MySqlConnection mysql = new MySqlConnection("server=localhost;database=c#_project;username=root;password=");
            string moviename;
            try
            {
                mysql.Open();
                string sql = "select * from seat where movie_name = @movie and user_id = @user_id";
                MySqlCommand comm = new MySqlCommand(sql, mysql);
                comm.Parameters.AddWithValue("@movie", Movieclass.movie);
                comm.Parameters.AddWithValue("@user_id", Useridclass.UserId);
                MySqlDataReader dr;
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    seatchecks = true;
                    
                }
                 
            }
            catch(Exception ex)
            {

            }
            finally
            {
                mysql.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!seatchecks)
            {
                pictureBox1.Visible = false;
                pictureBox32.Visible = true;
                label15.Visible = true;
                counter += 100;
                price_l.Text = counter.ToString();
                seat_id.Add("1"); // Add seat ID to the list
                 
            }
            else
            {
                
                pictureBox1.Visible = false;
                pictureBox32.Visible = false;
                label15.Visible = true;
                a1_sold.Visible = true;
            }
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            pictureBox32.Visible = false;
            pictureBox1.Visible = true;
            label15.Visible = false;
            if (counter >= 100)
            {
                
                increasePerformed = false;
                seat_id.Remove("1");
                DecreraseCounterBy(100);
            }
            else
            {
                MessageBox.Show("Counter cannot be decreased further.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            pictureBox33.Visible = false;
            pictureBox2.Visible = true;
            a2.Visible = false;
            if (counter >= 100)
            {

                increasePerformed = false;
                seat_id.Remove("2");
                DecreraseCounterBy(100);
            }
            else
            {
                MessageBox.Show("Counter cannot be decreased further.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (!seatchecks)
            {
                pictureBox2.Visible = false;
                pictureBox33.Visible = true;
                a2.Visible = true;
                counter += 100;
                price_l.Text = counter.ToString();
                seat_id.Add("2"); // Add seat ID to the list
            }
            else
            {
                pictureBox2.Visible = false;
                pictureBox33.Visible = false;
                label15.Visible = true;
                a1_sold.Visible = true;
            }
            }
        private void IncreaseCounterBy(int value)
        {
            if (!increasePerformed)
            {
                counter += value;
                increasePerformed = true;
                price_l.Text = counter.ToString();
            }
            else
            {
                MessageBox.Show("Increase already performed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void seat_Load(object sender, EventArgs e)
        {
            
            MySqlConnection mysql = new MySqlConnection("server=localhost;database=c#_project;username=root;password=");
            string moviename;
            try
            {
                
                mysql.Open();
                string query = "select * from user where email=@userEmail";
                MySqlCommand command = new MySqlCommand(query, mysql);
                command.Parameters.AddWithValue("@userEmail", EmailManager.UserEmail);
                int userid = -1;
                using (MySqlDataReader drs = command.ExecuteReader())
                {
                    if (drs.Read())
                    {
                        userid = drs.GetInt32(drs.GetOrdinal("id"));
                        Useridclass.SetId(userid);
                    }
                    drs.Close();
                }

                string sql = "SELECT * FROM seat WHERE movie_name = @movie AND user_id = @user_id ORDER BY Buy_date";
                MySqlCommand comm = new MySqlCommand(sql, mysql);
                
                comm.Parameters.AddWithValue("@movie", Movieclass.movie);       
                comm.Parameters.AddWithValue("@user_id", Useridclass.UserId);
                MySqlDataReader dr;
                dr = comm.ExecuteReader();
                int seatid;
                DateTime currentDate = DateTime.Now.Date;
                if (dr.HasRows)
                {
                    // Rows found, iterate through them
                    while (dr.Read())
                    {
                        MessageBox.Show("found");
                        seatid = dr.GetInt32(dr.GetOrdinal("seat"));
                        seatchecks = true;
                    }

                    if (seatchecks)
                    {
                        DateTime BuyDate = dr.GetDateTime("Release_Date");
                   
                        TimeSpan difference = currentDate - BuyDate;
                        int daysDifference = (int)difference.TotalDays;

                        // Check if the movie is available within 30 days of release
                        if (daysDifference >= -2 && daysDifference <= 30)
                        {
                            a1_sold.Visible = true;
                            pictureBox1.Visible = false;
                            pictureBox32.Visible = false;
                            label15.Visible = true;
                        }
                       
                    }
                }
                else
                {
                    // No rows found
                    pictureBox1.Visible = true;
                    pictureBox32.Visible = false;
                    label15.Visible =false;
                    
                }

                dr.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                mysql.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                int userid = -1;
                using (MySqlDataReader dr = command.ExecuteReader())
                {


                    if (dr.Read())
                    {
                        userid = dr.GetInt32(dr.GetOrdinal("id"));
                        Useridclass.SetId(userid);
                    }
                    if (userid != -1)
                    {
                        dr.Close();
                        foreach (string seat in seat_id)
                        {
                            seat_value.Add(seat);
                            string checkseat = "select * from seat where seat =@seat and user_id= @user_id and movie_name =@movie";

                            using (MySqlCommand checkcommand = new MySqlCommand(checkseat, conn))
                            {
                                string seatsString = string.Join(",", seat_value);
                                checkcommand.Parameters.AddWithValue("@seat", seat);
                                checkcommand.Parameters.AddWithValue("@user_id", userid);
                                checkcommand.Parameters.AddWithValue("@movie", Movieclass.movie);
                                MySqlDataReader sdr;
                                sdr = checkcommand.ExecuteReader();
                                while (sdr.Read())
                                {
                                    
                                    MessageBox.Show("found");
                                    seatinsert = true;
                                }

                                sdr.Close();
                            }
                            if (!seatinsert)
                            {
                               /* string seatsString = string.Join(",", seat_value);
                                MessageBox.Show(seatsString);*/
                                string sql = "insert into seat values(null,@seat,@movie_name,@user_id,@buydate)";
                                MySqlCommand comm = new MySqlCommand(sql, conn);
                                comm.Parameters.AddWithValue("@seat", seat);
                                comm.Parameters.AddWithValue("@movie_name", Movieclass.movie);
                                comm.Parameters.AddWithValue("@user_id", userid);
                                comm.Parameters.AddWithValue("@buydate", DateTime.Now);
                                comm.ExecuteNonQuery();
                                MessageBox.Show("Seats inserted Successfully");
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("not inserted");
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

                conn.Close();
            }
        }
        /*private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=c#_project;username=root;password=");
            try
            {
                conn.Open();
                string query = "select * from user where email=@userEmail";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@userEmail", EmailManager.UserEmail);
                int userid = -1;
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        userid = dr.GetInt32(dr.GetOrdinal("id"));
                        Useridclass.SetId(userid);
                    }
                    dr.Close();
                }
                
                if (userid != -1)
                {
                    foreach (string seat in seat_id)
                    {
                        string checkseat = "select * from seat where seat = @seat and user_id = @user_id and movie_name = @movie";
                        using (MySqlCommand checkcommand = new MySqlCommand(checkseat, conn))
                        {
                            checkcommand.Parameters.AddWithValue("@seat", seat);
                            checkcommand.Parameters.AddWithValue("@user_id", userid);
                            checkcommand.Parameters.AddWithValue("@movie", Movieclass.movie);
                            using (MySqlDataReader sdr = checkcommand.ExecuteReader())
                            {
                                if (!sdr.Read())
                                {
                                    string sql = "insert into seat (seat, movie_name, user_id, buydate) values (@seat, @movie_name, @user_id, @buydate)";
                                    using (MySqlCommand comm = new MySqlCommand(sql, conn))
                                    {
                                        comm.Parameters.AddWithValue("@seat", seat);
                                        comm.Parameters.AddWithValue("@movie_name", Movieclass.movie);
                                        comm.Parameters.AddWithValue("@user_id", userid);
                                        comm.Parameters.AddWithValue("@buydate", DateTime.Now);
                                        comm.ExecuteNonQuery();
                                    }
                                    
                                }
                                sdr.Close();
                            }
                        }
                    }
                    MessageBox.Show("Seats inserted successfully");
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }*/


        private void price_l_Click(object sender, EventArgs e)
        {

        }
        
    }
}
