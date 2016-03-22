using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
namespace ch8
{
    public partial class add : Form
    {
        //static string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        Form1 f1;
        public add()
        {
            InitializeComponent();
        }
        public add(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            Database db = DatabaseFactory.CreateDatabase("con");
            string sql = "select GradeName, GradeId from Grade";
            DbCommand cmd = db.GetSqlStringCommand(sql);

            DataSet ds = db.ExecuteDataSet(cmd);
            comboBox1.DisplayMember = "GradeName";
            comboBox1.ValueMember = "GradeId";
            comboBox1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into Class(ClassName,GradeId) values('{0}',{1})", textBox1.Text, comboBox1.SelectedValue.ToString());
            Database db = DatabaseFactory.CreateDatabase("con");
            DbCommand cmd = db.GetSqlStringCommand(sql);
            if ((int)db.ExecuteNonQuery(cmd) > 0)
            {
                MessageBox.Show("插入成功");
            }
            else            
                MessageBox.Show("失败");
                      
        }

        private void add_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form1 f1 =(Form1) this.Owner;
            f1.reload();
        }

        private void add_FormClosing(object sender, FormClosingEventArgs e)
        {

            f1.reload();
        }


    }
}
