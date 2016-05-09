using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using System.Data.SqlClient;

namespace 酒店管理系统
{
    public partial class Formyewu : Skin_Mac
    {
       
        public Formyewu()
        {
            InitializeComponent();
            Listview();
        }

        public void Listview()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hotel;Integrated Security=True");
            string sql = "select * from  RoomID";
            con.Open(); //打开链接
            //执行con对象的函数，返回一个SqlCommand类型的对象
            SqlCommand cmd = con.CreateCommand();
            //把输入的数据拼接成sql语句，并交给cmd对象
            cmd.CommandText = sql;
            //用cmd的函数执行语句，返回SqlDataReader类型的结果dr,dr就是返回的结果集（也就是数据库中查询到的表数据）
            SqlDataReader dr = cmd.ExecuteReader();
            //用dr的read函数，每执行一次，返回一个包含下一行数据的集合dr
            this.skinListView1.LargeImageList = this.imageList1;

            this.skinListView1.BeginUpdate();  
            while (dr.Read())
            {
                //构建一个ListView的数据，存入数据库数据，以便添加到listView1的行数据中
                ListViewItem lt = new ListViewItem();
                //将数据库数据转变成ListView类型的一行数据
                lt.Text = dr["RoomID"].ToString();
                //判断图片
                string  type=dr["RoomState"].ToString().TrimEnd();
                switch (type)
                {
                    case "清扫":
                        lt.ImageIndex = 0;
                        break;
                    case "锁定":
                        lt.ImageIndex = 1;
                        break;
                    case "空闲":
                        lt.ImageIndex = 2;
                        break;
                    case "占用":
                        lt.ImageIndex = 3;
                        break;
                    case "维护":
                        lt.ImageIndex = 4;
                        break;
                    default:
                        lt.ImageIndex = 4;
                        break;

                }
              
                //将lt数据添加到listView1控件中
                skinListView1.Items.Add(lt);
            }
           
          

           
            //for (int i = 0; i < 10; i++)
            //{
            //    ListViewItem lvi = new ListViewItem();

            //    lvi.ImageIndex = i;

            //    lvi.Text = "";

            //    this.skinListView1.Items.Add(lvi);
            //}
            con.Close();
        }

        private void skinListView1_Click(object sender, EventArgs e)
        {
            if (skinListView1.SelectedIndices != null && skinListView1.SelectedIndices.Count > 0)
            {
                ListView.SelectedIndexCollection c = skinListView1.SelectedIndices;
              //  lblTitle.Text = listview.Items[c[0]].Text;
                //MessageBox.Show("选中");
                if (skinListView1.Items[c[0]].ImageIndex == 0)
                {
                    Formkaifang f = new Formkaifang(this);
                    f.Show();
                }
                if (skinListView1.Items[c[0]].ImageIndex == 1)
                {
                   
                }
            }
        }
    }
}
