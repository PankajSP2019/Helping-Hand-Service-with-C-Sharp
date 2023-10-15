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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=LAPTOP-RHJ3VEUS\\SQLEXPRESS;Initial Catalog=Helping_hand;Integrated Security=True";//change
        SqlConnection Con = new SqlConnection("Data Source=LAPTOP-RHJ3VEUS\\SQLEXPRESS;Initial Catalog=Helping_hand;Integrated Security=True");//changess
        private void populate()
        {
            SqlConnection con = new SqlConnection(conString);// new connection
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from CustomerTbl", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CustomerDGV.DataSource = dt;
            Con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           //Application.Exit();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
           // Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform main = new Mainform();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CustId.Text == "" || CustName.Text == "" || CustAdd.Text == "" || Phone.Text == "")
            {
                MessageBox.Show("Missing information");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CustomerTbl values(" + CustId.Text + ",'" + CustName.Text + "','" + CustAdd.Text + "','" + Phone.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Succesfully Added");
                    Con.Close();
                    populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CustId.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from CustomerTbl where CustId=" + CustId.Text + "; ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer deleted successfully");
                    Con.Close();
                    populate();
                }

                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustId.Text = CustomerDGV.SelectedRows[0].Cells[0].Value.ToString();
            CustName.Text = CustomerDGV.SelectedRows[0].Cells[1].Value.ToString();
            CustAdd.Text = CustomerDGV.SelectedRows[0].Cells[2].Value.ToString();
            Phone.Text = CustomerDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CustId.Text == "" || CustName.Text == "" ||   CustAdd.Text == "" || Phone.Text == "")
            {
                MessageBox.Show("Missing information");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update CustomerTbl set CustName= '" + CustName.Text + "',CustAdd='" + CustAdd.Text + "',Phone =" +Phone.Text+ " where CustId ='" + CustId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Succesfully Updated");
                    Con.Close();
                    populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }
    }
}
