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
    public partial class CashBookInfo : Form
    {
        public CashBookInfo()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=LAPTOP-RHJ3VEUS\\SQLEXPRESS;Initial Catalog=Helping_hand;Integrated Security=True";//change
        SqlConnection Con = new SqlConnection("Data Source=LAPTOP-RHJ3VEUS\\SQLEXPRESS;Initial Catalog=Helping_hand;Integrated Security=True");//changess

        private void fillcombo()
        {
            Con.Open();
           
            string query = "Select ProductNum from HandTbl where Available='"+"Yes"+"'";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductNum",typeof(string));
            dt.Load(rdr);
            HandRegAvailableCb.ValueMember = "ProductNum";
            HandRegAvailableCb.DataSource = dt;
            
            Con.Close();
        }

        private void fillCustomer()
        {
            Con.Open();

            string query = "Select CustId from CustomerTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustId", typeof(int));
            dt.Load(rdr);
            CustIdAvailableCb.ValueMember = "CustId";
            CustIdAvailableCb.DataSource = dt;

            Con.Close();
        }

        private void fetchCustName()
        {
            Con.Close();//an Runtime error shows,connection still open
                            //thats why we close connection first
            
            Con.Open();
            

            string query = "Select * from CustomerTbl where CustId="+CustIdAvailableCb.SelectedValue.ToString()+"";
            SqlCommand cmd = new SqlCommand(query,Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CashCustNameTb.Text = dr["CustName"].ToString();
            }
            Con.Close();
        }

        private void populate()
        {
            Con.Close();

            SqlConnection con = new SqlConnection(conString);// new connection
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from FixTbl", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CashBookInfoDGV.DataSource = dt;
            Con.Close();
        }
        
        private void UpdateonCashBookInfo() //
        {
            Con.Open();
            string query = "update HandTbl set Available= '" + "No" + "' where ProductNum='" + HandRegAvailableCb.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
           // MessageBox.Show("Hand Succesfully Updated");
            Con.Close();
        }

        private void UpdateonCashBookInfoDelete() //
        {
            Con.Open();
            string query = "update HandTbl set Available= '" + "Yes" + "' where ProductNum='" + HandRegAvailableCb.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            // MessageBox.Show("Hand Succesfully Updated");
            Con.Close();
        }

        private void CashBookInfo_Load(object sender, EventArgs e)
        {
            fillcombo();
            fillCustomer();
            populate();
        }

        private void HandRegAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustIdAvailableCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchCustName();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CustId.Text == "" || CashCustNameTb.Text == "" || FixFeeTb.Text == "")
            {
                MessageBox.Show("Missing information");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into FixTbl values(" + CustId.Text + ",'" + HandRegAvailableCb.SelectedValue.ToString() + "','" + CashCustNameTb.Text + "','" + Convert.ToDateTime(FixDate.Text) + "','"+ FixFeeTb.Text + "')";

                    //Convert.ToDateTime(FixDate.Text)
                    //we convert the input date by this into txt
                    //ref(https://www.codeproject.com/Questions/751464/Date-Input-textbox-dd-MM-yyyy)

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Succesfully Added To Fix Table");
                    Con.Close();
                    UpdateonCashBookInfo();
                    populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform main = new Mainform();
            main.Show();
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
                    string query = "delete from FixTbl where FixId=" + CustId.Text + "; ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deleted From Cash Book Info");
                    Con.Close();
                    populate();
                    UpdateonCashBookInfoDelete();
                }

                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void CashBookInfoDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           CustId.Text = CashBookInfoDGV.SelectedRows[0].Cells[0].Value.ToString();
            HandRegAvailableCb.SelectedValue = CashBookInfoDGV.SelectedRows[0].Cells[1].Value.ToString();
            CashCustNameTb.Text = CashBookInfoDGV.SelectedRows[0].Cells[3].Value.ToString();
            FixFeeTb.Text= CashBookInfoDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
