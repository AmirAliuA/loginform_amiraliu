using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginForm_AmirAliu
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            // Make the form non-resizaBLE
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        // Logout Button
        private void button1_Click(object sender, EventArgs e)
        {
            // Hide the 'Main' form
            this.Hide();

            // Show 'Form1'
            Form1 form = new Form1();
            form.ShowDialog();
        }

        // Fetch Data button
        private void button2_Click(object sender, EventArgs e)
        {
            /*
            label7.Text = reader["id"].ToString();
            label2.Text = reader["user_name"].ToString();
            label4.Text = reader["password"].ToString();
            */

            string connectionString = @"Data Source=.;Initial Catalog=LoginForm_AmirAliu;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.login", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellContentClick1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        // Change the previous name of the app to the one given below.
        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = "User Management - Show Users";
        }

    }
}
