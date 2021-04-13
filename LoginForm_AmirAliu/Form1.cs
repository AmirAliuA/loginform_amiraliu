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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Make the form non-resizaBLE
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Login Button
        private void button1_Click(object sender, EventArgs e)
        {
            // SQL Connection
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=LoginForm_AmirAliu;Integrated Security=True");

            // SQL Command
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM dbo.login WHERE user_name='" + textBox1.Text + "' and password = '" + textBox2.Text + "'  ", conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                // Hide the current form
                this.Hide();
                Main m = new Main();

                // Show the Main form
                m.Show();
            } else {
                MessageBox.Show("Username ose passwordi i dhene nuk eshte i sakte. Provoni perseri.", "GABIM!");
            }
        }

        // Exit Button
        private void button2_Click(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }

        // Username Field
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Password Field
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // PictureBox
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Change the default app name from "Form1" to the given value.
            this.Text = "User Management - Login";
        }

        // Footer
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
