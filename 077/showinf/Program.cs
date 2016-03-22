using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace showinf
{
    class Program
    {
        static void Main(string[] args)
        {
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            string sql1= ConfigurationManager.ConnectionStrings["sql1"].ConnectionString;
            string sql2 = ConfigurationManager.ConnectionStrings["sql2"].ConnectionString;
            string sql3 = ConfigurationManager.ConnectionStrings["sql3"].ConnectionString;

            using (SqlConnection sc=new SqlConnection(con))
            {
                sc.Open();
                SqlCommand cmd = new SqlCommand(sql1,sc);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(Convert.ToString(reader[0]) + " " + Convert.ToString(reader[1]));

                }
                reader.Close();

                cmd = new SqlCommand(sql2, sc);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    
                    Console.WriteLine(Convert.ToString(reader[0]) + " " + Convert.ToString(reader[1]));
                }
                reader.Close();

                cmd = new SqlCommand(sql3, sc);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(Convert.ToString(reader[0]) + " " + Convert.ToString(reader[1]));

                }
                reader.Close();
                Console.ReadKey();
            }
        }
    }
}
