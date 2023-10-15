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
    public partial class UserView : Form
    {
        public UserView()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServiceUserView suv = new ServiceUserView();
            suv.Show();
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg= new Login();
            lg.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Login lg =new Login();

        
    }
}
