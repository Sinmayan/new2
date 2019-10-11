using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aps_finance
{
    public partial class login : Form
    {
        SqlConnection con = dbc.sqlc();
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "SELECT count(*) FROM employee WHERE emp_jobref = 'Admin' and emp_username = '" + textBox1.Text + "' and emp_password = '" + textBox2.Text + "'";
            SqlCommand sc = new SqlCommand(query, con);
            int UserExist = (int)sc.ExecuteScalar();


            if (UserExist == 1)
            {
                MessageBox.Show("Welcome To Finance Handling");
                this.Hide();
                Form1 er = new Form1();
                er.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect Username and Password");
                textBox2.Clear();
                con.Close();
            }

        }
    }
}
