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
using System.Configuration;
namespace bank
{
    public partial class Form1 : Form
    {
        static SqlConnection sc;
        static SqlCommand cmd;
        static string con =ConfigurationManager.ConnectionStrings["con"].ConnectionString ;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select SUM(Cost) from CardRecord where CardNo='{0}';", textBox1.Text);
            using (sc = new SqlConnection(con))
            {
                sc.Open();
                cmd = new SqlCommand(sql, sc);
                string show = string.Format("积分总共为{0}", Convert.ToString(cmd.ExecuteScalar()));
                MessageBox.Show(show);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            using (sc = new SqlConnection(con))
            {
                sc.Open();
                cmd = new SqlCommand(sql, sc);
                cmd.Parameters.AddWithValue("@num", textBox1.Text);
                string show = string.Format("使用了{0}次", Convert.ToString(cmd.ExecuteScalar()));
                MessageBox.Show(show);
            }
        }
    }
}
