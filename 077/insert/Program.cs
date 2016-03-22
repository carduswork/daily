using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace insert
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("输入插入的数字Id");
            //string id=Console.ReadLine();
            #region 插入功能
            #endregion
            //Console.WriteLine("输入插入的组名");
            //string name=Console.ReadLine();
            //string sql =string.Format("insert into Class values('{0}',null);",name);
            string con="Data Source=.\\SQLEXPRESS;Initial Catalog=MySchool;uid='sa';pwd='123'";
            //using (SqlConnection connection = new SqlConnection(con))
            //{
            //    connection.Open();
            //    SqlCommand cmd = new SqlCommand(sql, connection);
            //    int n = cmd.ExecuteNonQuery();
            //    if (n!=1)               
            //        Console.WriteLine("插入失败");               
            //    else Console.WriteLine("插入成功");
            //}
            #region 修改功能
            #endregion
            Console.WriteLine("输入要修改的行号");
            string toup=Console.ReadLine();
            Console.WriteLine("输入新行的ClassName");
            string newname = Console.ReadLine();
            Console.WriteLine("输入新行的GroupId");
            string newid = Console.ReadLine();
            string sql2 = string.Format("update Class set ClassName='{0}',GradeId='{1}' where ClassId='{2}'",newname,newid,toup);
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql2, connection);
                int n = cmd.ExecuteNonQuery();
                if (n != 1)
                    Console.WriteLine("修改失败");
                else Console.WriteLine("修改成功");
            }
            Console.ReadKey();
            #region 删除功能
            #endregion
            Console.WriteLine("输入要删除的行号");
            string todel = Console.ReadLine();
            string sql3 =string.Format("drop * from Class where ClassId='{0}'",todel);
        }
    }
}
