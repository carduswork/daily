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
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
namespace ch8
{
    public partial class update : Form
    {
        //static string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        int classid;
        string classname;
        string grade;
        Form1 f1;
        public update()
        {
            InitializeComponent();
        }
        public update(int classid,string classname,string grade,Form1 f1)
        {
            InitializeComponent();
            this.classid = classid;
            this.classname = classname;
            this.grade = grade;
            this.f1 = f1;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            textBox2.Text = classid.ToString();
            textBox1.Text = classname;
            string sql = "select GradeName, GradeId from Grade";
            Database db = DatabaseFactory.CreateDatabase("con");
            DbCommand cmd = db.GetSqlStringCommand(sql);

            DataSet ds = db.ExecuteDataSet(cmd);
            comboBox1.DisplayMember = "GradeName";
            comboBox1.ValueMember = "GradeId";
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.Text = grade;
            //using (SqlConnection connection = new SqlConnection(con))
            //{
            //    connection.Open();
            //    DataSet ds = new DataSet();
            //    SqlDataAdapter sda = new SqlDataAdapter(sql, connection);
            //    sda.Fill(ds);

            //    comboBox1.DisplayMember = "GradeName";
            //    comboBox1.ValueMember = "GradeId";
            //    comboBox1.DataSource = ds.Tables[0];
            //    comboBox1.Text = grade;
            //}
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("update Class set ClassName='{0}',GradeId={1} where ClassId={2}", textBox1.Text, comboBox1.SelectedValue.ToString(), textBox2.Text);
            Database db = DatabaseFactory.CreateDatabase("con");
            DbCommand cmd = db.GetSqlStringCommand(sql);
            if ((int)db.ExecuteNonQuery(cmd) > 0)
            {
                MessageBox.Show("修改成功");
            }
            else
                MessageBox.Show("失败");            
        }

        private void update_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.reload();
        }
    }
}
