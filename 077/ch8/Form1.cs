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
using System.Data;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
namespace ch8
{
    public partial class Form1 : Form
    {
        static string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            update f2 = new update();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reload();
        }

        public void reload()
        {
            dataGridView1.DataSource = null;
            string sql = "select ClassId,ClassName,GradeName from Class inner join Grade on Grade.GradeId=Class.GradeId";
           
            Database db = DatabaseFactory.CreateDatabase("con");
            DbCommand cmd = db.GetSqlStringCommand(sql);
            DataSet ds = db.ExecuteDataSet(cmd);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region 模糊
            #endregion
            string sql = "select classid,classname,gradename from class inner join grade on class.gradeid=grade.gradeid where classname like @classname";
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@classname", "%" + textBox1.Text + "%");
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql2 = "select COUNT(*) from Student inner join Class on Student.ClassId=Class.ClassId where Class.ClassId=@pk;";
            string sql = "delete from Class where ClassId=@id";
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql2, connection);
                int pk = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                cmd.Parameters.AddWithValue("@pk", pk);
                if ((int)cmd.ExecuteScalar() > 0)
                {
                    MessageBox.Show("不能删除");
                }
                else
                {
                    cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id", pk);
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                    sda.Fill(ds);
                    //dataGridView1.Rows.Clear();
                    reload();
                    //dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add f3 = new add(this);
            f3.Show();
            
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string t = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            update f2 = new update(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()),dataGridView1.CurrentRow.Cells[1].Value.ToString() ,dataGridView1.CurrentRow.Cells[2].Value.ToString(),this);
            //f2.Owner = this;
            f2.Show();
            
        }
    }
}
