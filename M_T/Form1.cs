using MySql.Data.MySqlClient;

namespace M_T
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void log_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " " || textBox2.Text == "")
            {
                MessageBox.Show("Please fill the box");
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=c#_project;username=root;password=");
                try
                {
                    conn.Open();

                    String query = "select * from user where email = '" + textBox1.Text + "' and password ='" + textBox2.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader da;

                    da = cmd.ExecuteReader();
                    if (da.Read())
                    {
                        this.Hide();

                        dashboard d = new dashboard();
                        d.SetEmail(textBox1.Text);
                        EmailManager.SetEmail(textBox1.Text);
                        d.Show();

                    }
                    else if (textBox1.Text == "admin" && textBox2.Text == "admin")
                    {
                        this.Hide();
                        admin_dasboard d = new admin_dasboard();
                        d.Show();
                    }

                    else
                    {
                        MessageBox.Show("Invalid Username and Password ");
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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void reg_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Register r = new Register();
            r.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
