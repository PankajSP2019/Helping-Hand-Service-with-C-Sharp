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

namespace Form1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=LAPTOP-RHJ3VEUS\\SQLEXPRESS;Initial Catalog=Helping_hand;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (Uname.Text[1]=='-')
            {

                string query = "Select count(*) from UserTbl where Uname = '" + Uname.Text + "' and Upass='" + PassTb.Text + "'";
                Con.Open();


                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Mainform mainform = new Mainform();
                    mainform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
                Con.Close();
            }
            else if (Uname.Text[2] == '-')
            {
                string query = "Select count(*) from UserTbl where Uname = '" + Uname.Text + "' and Upass='" + PassTb.Text + "'";
                Con.Open();


                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    UserView uv= new UserView();
                    uv.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
                Con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }

        }
        private void label4_Click(object sender, EventArgs e)
        {
            Uname.Text = "";
            PassTb.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateUserAccount cua = new CreateUserAccount();
            cua.Show();
        }

        public void Uname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
