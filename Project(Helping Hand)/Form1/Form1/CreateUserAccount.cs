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
    public partial class CreateUserAccount : Form
    {
        public CreateUserAccount()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=LAPTOP-RHJ3VEUS\\SQLEXPRESS;Initial Catalog=Helping_hand;Integrated Security=True";//change

        SqlConnection Con = new SqlConnection("Data Source=LAPTOP-RHJ3VEUS\\SQLEXPRESS;Initial Catalog=Helping_hand;Integrated Security=True");//changess


        private void label4_Click(object sender, EventArgs e)
        {
            IdTb.Text = "";
            UnameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text[2] == '-')
            {
                if (IdTb.Text == "" || UnameTb.Text == "" || PasswordTb.Text == "")
                {
                    MessageBox.Show("Missing information");

                }
                else
                {
                    try
                    {
                        Con.Open();
                        string query = "insert into UserTbl values(" + IdTb.Text + ",'" + UnameTb.Text + "','" + PasswordTb.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account Successfully Created");
                        Con.Close();


                    }
                    catch (Exception Myex)
                    {
                        MessageBox.Show(Myex.Message);
                    }
                }
            }
            else 
            {
                MessageBox.Show("Please Enter UserId with Right Syntex\n Syntex of UserId =**-*****......\nPlease put a - in the 3rd position of UserId");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }
    }
}
