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
namespace db
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cn = "Data Source=.\\SQLEXPRESS;Initial Catalog=MySchool;uid=sa;pwd=123";

            using (conn = new SqlConnection(cn))
            {
                string sql =string.Format("select count(*) from Student where LoginId='{0}' and LoginPwd='{1}'",textBox1.Text,textBox2.Text);
                conn.Open();
                SqlCommand cm = new SqlCommand(sql, conn);
                if ((int)cm.ExecuteScalar()>=1)
                {
                    MessageBox.Show("登录成功");
                    
                }
                else MessageBox.Show("失败");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
