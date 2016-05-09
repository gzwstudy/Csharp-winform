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
    public partial class Formkaifang : Skin_Mac
    {
       
        public Formkaifang(Formyewu f1)
        {
            InitializeComponent();
          
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            string sex = "男";
if (skinRadioButton1.Checked==true)
{
sex="男";
}
else
{
sex="女";
}
            string connstring = "Data Source=.;Initial Catalog=Hotel;Integrated Security=True";
            string sql = "insert into Cus(CusName,Paper,Phone,Gender,Grade,RoomID) values('" + skinTextBox1.Text + "','" + skinTextBox2.Text + "','" + skinTextBox3.Text + "','" + skinComboBox1.Text+ "','" + sex + "','"+sex+"')";
            SqlConnection conn = new SqlConnection(connstring);//connstring链接数据库语句
            conn.Open();
            SqlCommand comd = new SqlCommand(sql, conn);
            try
            {
                int count = comd.ExecuteNonQuery();
                conn.Close();
                if (count > 0)
                {
                    MessageBox.Show("添加成功");
                 
                }
                else
                {
                    MessageBox.Show("修改失败");

                }
            }
            catch
            {
                MessageBox.Show("用户已经开房了");
            }
        }
    }
}
