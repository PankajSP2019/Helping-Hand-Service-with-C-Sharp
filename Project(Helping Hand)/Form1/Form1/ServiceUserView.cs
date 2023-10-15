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
    public partial class ServiceUserView : Form
    {
        public ServiceUserView()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=LAPTOP-RHJ3VEUS\\SQLEXPRESS;Initial Catalog=Helping_hand;Integrated Security=True";//change
        SqlConnection Con = new SqlConnection("Data Source=LAPTOP-RHJ3VEUS\\SQLEXPRESS;Initial Catalog=Helping_hand;Integrated Security=True");//changess
        private void populate()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from HandTbl", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            ServiceUserViewDGV.DataSource = dt;
        }

        private void ServiceUserView_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserView uv = new UserView();
            uv.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
