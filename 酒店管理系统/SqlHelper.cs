using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;//第一步：引用与sql相关的命名空间
using System.Data;//引用表的命名空间

namespace 酒店管理系统
{
   public class SqlHelper//设置为公共类
    {
        public static string connstr = "Data Source=.;Initial Catalog=Hotel;Integrated Security=True";//公共的静态的 连接字符串
//        //执行查询，并返回查询所返回的结果集中第一行的第一列。所有其他的列和行将被忽略。
//       ExecuteScalar()方法也用来执行SQL语句，但是ExecuteScalar()执行SQL语句后的返回值与 ExecuteNonQuery()并不相同，ExecuteScalar()方法的返回值的数据类型是Object类型。
//object类型，也就是说是所有数据类型的基类，可根据select所得的第一列的数据类型转换为对应的数据类型
//例。
        public static int ExecuteScalar(string cmdText, params SqlParameter[] pms)
        {
            //params:不限长度的数组
            //第一步：创建数据库对象连接
            SqlConnection conn = new SqlConnection(connstr);
            //第二步：打开数据库
            conn.Open();
            //第三步：创建数据库命令对象和数据库查询语句
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            //第四步：创建参数对象
            //cmd.Parameters.Add(pms);//如果我们在这里直接放入pms数组，那么cmd添加进去的都是SqlParameter，而不是具体的参数。


            // int[] ii = new int[5] { 1,2,3,4,5 };
            if (pms != null)
            {

                //for (int i = 0; i <pms.Length; i++)
                //{
                //  if (pms[i]!=null)
                //  {
                //    cmd.Parameters.Add(pms[i]); 
                //  }

                //}
                foreach (SqlParameter item in pms)//第一个参数：你的数据类型 //第二个参数是值 //第三个参数：in  在什么什么里面  //第四个参数  数组的名称
                {
                    if (item != null)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
            }
            //第五步：返回结果
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            //第六步：关闭数据库
            conn.Close();
            //第六步:把最终的结果返回到外面去
            return i;
        }

       //执行增删改操作sql语句
        //ExecuteNonQuery执行一个SqlCommand返回操作影响的行数，这个多半是判断操作是否成功的，
       //例如插入删除和更新操作，如果影响行数为0的话，则证明操作是不成功的，大于0则证明操作成功。
        public static int ExecuteNonQuery(string cmdText, params SqlParameter[] pms)
        {
            //params:不限长度的数组
            //第一步：创建数据库对象连接
            SqlConnection conn = new SqlConnection(connstr);
            //第二步：打开数据库
            conn.Open();
            //第三步：创建数据库命令对象和数据库查询语句
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            //第四步：创建参数对象
            //cmd.Parameters.Add(pms);//如果我们在这里直接放入pms数组，那么cmd添加进去的都是SqlParameter，而不是具体的参数。


            // int[] ii = new int[5] { 1,2,3,4,5 };
            if (pms != null)
            {

                //for (int i = 0; i <pms.Length; i++)
                //{
                //  if (pms[i]!=null)
                //  {
                //    cmd.Parameters.Add(pms[i]); 
                //  }

                //}
                foreach (SqlParameter item in pms)//第一个参数：你的数据类型 //第二个参数是值 //第三个参数：in  在什么什么里面  //第四个参数  数组的名称
                {
                    if (item != null)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
            }
            //第五步：返回结果
            int i = Convert.ToInt32(cmd.ExecuteNonQuery());
            //第六步：关闭数据库
            conn.Close();
            //第六步:把最终的结果返回到外面去
            return i;
        }


        //返回一张表
        public static DataTable GetTable(string cmdText, params SqlParameter[] pms)
        {
            //params:不限长度的数组
            //第一步：创建数据库对象连接
            SqlConnection conn = new SqlConnection(connstr);
            //第二步：打开数据库
            conn.Open();
            //第三步：创建数据库命令对象和数据库查询语句
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            //第四步：创建参数对象
            //cmd.Parameters.Add(pms);//如果我们在这里直接放入pms数组，那么cmd添加进去的都是SqlParameter，而不是具体的参数。


            // int[] ii = new int[5] { 1,2,3,4,5 };
            if (pms != null)
            {

                //for (int i = 0; i <pms.Length; i++)
                //{
                //  if (pms[i]!=null)
                //  {
                //    cmd.Parameters.Add(pms[i]); 
                //  }

                //}
                foreach (SqlParameter item in pms)//第一个参数：你的数据类型 //第二个参数是值 //第三个参数：in  在什么什么里面  //第四个参数  数组的名称
                {
                    if (item != null)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
            }
            //5. SqlDataAdapter是.net中用于存放数组库里面取出来的数  相当于我们现实生活中的容器
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //6.去创建一个适配器 用来接受容器的
            DataSet ds = new DataSet();
            sda.Fill(ds, "aa");
            conn.Close();
            DataTable dt = ds.Tables["aa"];
            return dt;
        }
       //数据读取函数
        public static SqlDataReader GetReader(string cmdText, params SqlParameter[] pms)
        {
            SqlConnection conn = new SqlConnection(connstr);
            //第二步：打开数据库
            conn.Open();
            //第三步：创建数据库命令对象和数据库查询语句
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            //第四步：创建参数对象
            //cmd.Parameters.Add(pms);//如果我们在这里直接放入pms数组，那么cmd添加进去的都是SqlParameter，而不是具体的参数。


            // int[] ii = new int[5] { 1,2,3,4,5 };
            if (pms != null)
            {

                //for (int i = 0; i <pms.Length; i++)
                //{
                //  if (pms[i]!=null)
                //  {
                //    cmd.Parameters.Add(pms[i]); 
                //  }

                //}
                foreach (SqlParameter item in pms)//第一个参数：你的数据类型 //第二个参数是值 //第三个参数：in  在什么什么里面  //第四个参数  数组的名称
                {
                    if (item != null)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
            }
            SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);//把数据取出来以游标的形式放入sdr
            return sdr;


        }
    }
}
