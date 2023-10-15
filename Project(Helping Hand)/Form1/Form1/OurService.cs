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
    public partial class OurService : Form
    {
        public OurService()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=LAPTOP-RHJ3VEUS\\SQLEXPRESS;Initial Catalog=Helping_hand;Integrated Security=True";//change
        SqlConnection Con = new SqlConnection("Data Source=LAPTOP-RHJ3VEUS\\SQLEXPRESS;Initial Catalog=Helping_hand;Integrated Security=True");//changess
        private void populate()
        {
            SqlConnection con = new SqlConnection(conString);// new connection
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from HandTbl", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            HandDGV.DataSource = dt;
            Con.Close();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             if(ProductNum.Text == "" || Brand.Text == "" || Model.Text == "" || Cost.Text == "")
            {
                MessageBox.Show("Missing information");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into HandTbl values('" +ProductNum.Text+ "','" +Brand.Text+ "','" +Model.Text+ "','" + Available.SelectedItem.ToString()+ "','" + Cost.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product Succesfully Added");
                        Con.Close();
                        populate();

                }
                catch(Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void OurService_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (product.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from HandTbl where ProductNum='" + ProductNum.Text + "'; ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product deleted successfully");
                    Con.Close();
                    populate();
                }

                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void HandDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            product.Text = HandDGV.SelectedRows[0].Cells[0].Value.ToString();
            BrandTb.Text = HandDGV.SelectedRows[0].Cells[1].Value.ToString();
            ModelTb.Text = HandDGV.SelectedRows[0].Cells[2].Value.ToString();
           Available.Text = HandDGV.SelectedRows[0].Cells[3].Value.ToString();
           CostTb.Text = HandDGV.SelectedRows[0].Cells[4].Value.ToString();


        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform main = new Mainform();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ProductNum.Text == "" || Brand.Text == "" || Model.Text == "" || Cost.Text == "")
            {
                MessageBox.Show("Missing information");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update HandTbl set Brand= '" + Brand.Text + "',Model='" + Model.Text + "',Available ='" + Available.SelectedItem.ToString() + "', Cost=" + Cost.Text + " where ProductNum='" + ProductNum.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hand Succesfully Updated");
                    Con.Close();
                    populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Available_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
