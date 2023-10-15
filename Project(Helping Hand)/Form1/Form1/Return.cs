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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=LAPTOP-RHJ3VEUS\\SQLEXPRESS;Initial Catalog=Helping_hand;Integrated Security=True";//change
        SqlConnection Con = new SqlConnection("Data Source=LAPTOP-RHJ3VEUS\\SQLEXPRESS;Initial Catalog=Helping_hand;Integrated Security=True");//changess


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

        private void populateReturn()
        {
            Con.Close();

            SqlConnection con = new SqlConnection(conString);// new connection
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from ReturnTbl", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReturnDGV.DataSource = dt;
            Con.Close();
        }

        private void Deleteonreturn()
        {
          //  int cashBookId;
           // cashBookId = Convert.ToInt32(CashBookInfoDGV.SelectedRows[1].Cells[1].Value.ToString());


            Con.Open();
            string query = "delete from FixTbl where FixId='"+ ReturnHandRegTb.Text + "'; ";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Successfully Deleted From Cash Book Info");
            Con.Close();
            populate();
           // UpdateonCashBookInfoDelete();
        }

        private void CashBookInfoDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ReturnHandRegTb.Text = CashBookInfoDGV.SelectedRows[0].Cells[1].Value.ToString();
            ReturnCustNameTb.Text = CashBookInfoDGV.SelectedRows[0].Cells[2].Value.ToString();
            ReturnDate.Text = CashBookInfoDGV.SelectedRows[0].Cells[3].Value.ToString();

            DateTime d1 = ReturnDate.Value.Date;
            DateTime d2 = DateTime.Now;
            TimeSpan t = d2 - d1;
            int NrOfDays = Convert.ToInt32(t.TotalDays);

            if (NrOfDays <= 0)
            {
                DelayTb.Text = "NO Dlay";
                FineFeeTb.Text = "0";
            }
            else
            {
                DelayTb.Text = "" + NrOfDays;
                FineFeeTb.Text = "" + (NrOfDays*250); //for 1 day delay 250 refunded
            }

        }

        private void Return_Load(object sender, EventArgs e)
        {
            populate();
            populateReturn();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform main = new Mainform();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CustId.Text == "" || ReturnCustNameTb.Text == "" || FineFeeTb.Text == "" || DelayTb.Text=="")
            {
                MessageBox.Show("Missing information");

            }
            else
            {
                try
                {
                    //FineFeeTb.Text = "(Convert.ToInt32(DelayTb) * 250)";

                    Con.Open();
                    string query = "insert into ReturnTbl values(" + CustId.Text + ",'" + ReturnHandRegTb.Text+ "','" + ReturnCustNameTb.Text + "','" + Convert.ToDateTime(ReturnDate.Text) + "','"+FineFeeTb.Text+"')";

                    //Convert.ToDateTime(FixDate.Text)
                    //we convert the input date by this into txt
                    //ref(https://www.codeproject.com/Questions/751464/Date-Input-textbox-dd-MM-yyyy)

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Succesfully Returned");
                    Con.Close();
                    // UpdateonCashBookInfo();
                    populateReturn();
                    Deleteonreturn();

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
