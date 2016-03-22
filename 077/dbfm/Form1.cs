using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace dbfm
{
    public partial class Form1 : Form
    {
        static string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        static string sql = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        static string sql2 =ConfigurationManager.ConnectionStrings["sql2"].ConnectionString;
        
        static SqlConnection connection;
        static SqlDataReader reader; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(con))
            {
                connection.Open();
                comboBox2.Items.Clear();
               
                SqlCommand cmd = new SqlCommand(sql2, connection);
                cmd.Parameters.AddWithValue("@cname", comboBox1.Text);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox2.Items.Add(reader[0]);
                }

                reader.Close();
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(con))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
               reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0]);
                }
                
                reader.Close();
            }
        }
    }
}
