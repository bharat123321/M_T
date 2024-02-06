using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M_T
{

    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void reg_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;database=c#_project;username=root;password=");
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Please fill the blank");
                }
                else if (textBox2.Text == textBox3.Text)
                {
                    con.Open();
                    String users = textBox1.Text;
                    String passs = textBox2.Text;
                    String confirm_pass = textBox3.Text;
                    String address = textBox5.Text;
                    String email = textBox4.Text;
                    String gender = null;


                    if (!(comboBox1.Text == "Male" || comboBox1.Text == "Female" || comboBox1.Text == "Other"))
                    {
                        MessageBox.Show("Please Choose the gender by clicking");
                    }
                    else
                    {

                        gender = comboBox1.Text;
                        String sql = "select 'email' from users where email = '" + email + "'";
                        if (EmailIsValid(email) == true)
                        {

                            MySqlCommand sqlcom = new MySqlCommand(sql, con);
                            MySqlDataReader myre;
                            myre = sqlcom.ExecuteReader();
                            if (myre.Read())
                            {
                                MessageBox.Show("Email already Exit");
                            }
                            else
                            {
                                MessageBox.Show("Valid");
                            }



                            String query = "insert into users values(null,@user,@pass,@email,@gender,@address)";
                            MySqlCommand com = new MySqlCommand(query, con);
                            com.Parameters.AddWithValue("@user", users);
                            com.Parameters.AddWithValue("@pass", passs);
                            com.Parameters.AddWithValue("@email", email);
                            com.Parameters.AddWithValue("@gender", gender);
                            com.Parameters.AddWithValue("@address", address);
                            com.ExecuteNonQuery();
                            MessageBox.Show("Your Account is Created.");
                        }

                        else
                        {
                            MessageBox.Show("Invalid Email Address");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Password does not match");
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
            /* textBox1.Text = "";
             textBox2.Text = "";*/
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";

        }

        private void log_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
        public static bool EmailIsValid(string email)
        {
            return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void EmailDuplication(String email)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;database=c#_project;username=root;password=");
            String sql = "select 'email' from users where email = '" + email + "'";
            MySqlCommand sqlcom = new MySqlCommand(sql, con);
            MySqlDataReader myre;
            myre = sqlcom.ExecuteReader();
            if (myre.Read())
            {
                MessageBox.Show("Email already Exit");
            }
            else
            {
                MessageBox.Show("Email already E");
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
    