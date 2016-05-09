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
    public partial class RoomWeihu : Skin_Mac
    {
        public RoomWeihu()
        {
            InitializeComponent();
        }

        private void RoomWeihu_Load(object sender, EventArgs e)
        {
            Dataview();
        }

        public void  Dataview()
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hotel;Integrated Security=True");
        string sql = "select * from  RoomID";
        con.Open(); //打开链接
        SqlDataAdapter myda = new SqlDataAdapter(sql, con);
        DataSet myds = new DataSet();
        myda.Fill(myds, "RoomID");
        ////设置skinDataGridView1控件第一列的列头文字
        //skinDataGridView1.Columns[0].HeaderText = "序号";
        ////设置skinDataGridView1控件第一列的列宽
        skinDataGridView1.DataSource = myds.Tables["RoomID"]; //表写入
        skinDataGridView1.Columns[0].Width = 80;
        skinDataGridView1.Columns[1].Width = 100;
        skinDataGridView1.Columns[2].Width = 100;
        skinDataGridView1.Columns[3].Width = 200;
        con.Close();
    }

  

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 取消ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.skinTextBox1.Text = "";
            skinComboBox1.Text ="";      
            skinComboBox2.Text ="";
            rtfRichTextBox1.Text = "";
            foreach (DataGridViewRow row in skinDataGridView1.Rows)
            {
                row.Selected = false;
            }
        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source=.;Initial Catalog=Hotel;Integrated Security=True";
            string sql = "insert into  RoomID(RoomID,RoomType,RoomState,RoomSug) values('"+skinTextBox1.Text+"','"+skinComboBox1.Text+"','"+skinComboBox2.Text+"','"+rtfRichTextBox1.Text+"')";
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
                    Dataview();
                }
                else
                {
                    MessageBox.Show("修改失败");

                }
            }
            catch
            {
                MessageBox.Show("不能添加重复的房间号");
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source=.;Initial Catalog=Hotel;Integrated Security=True";
            string sql = "delete from RoomID where RoomID='"+skinTextBox1.Text+"'";
            SqlConnection conn = new SqlConnection(connstring);//connstring链接数据库语句
            conn.Open();
            SqlCommand comd = new SqlCommand(sql, conn);
            try
            {
                int count = comd.ExecuteNonQuery();
                conn.Close();
                if (count > 0)
                {
                    MessageBox.Show("删除成功");
                    Dataview();
                }
                else
                {
                    MessageBox.Show("修改失败");

                }
            }
            catch
            {
                MessageBox.Show("未找到要删除的列");
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          DialogResult r1=  MessageBox.Show("是否保存当前修改？", "保存修改", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (r1.ToString() == "Yes")
            {
                string connstring = "Data Source=.;Initial Catalog=Hotel;Integrated Security=True";
                string sql = "update RoomID set RoomType='" + skinComboBox1.Text + "'  where RoomID='" + skinTextBox1.Text + "'";
                SqlConnection conn = new SqlConnection(connstring);//connstring链接数据库语句
                conn.Open();
                SqlCommand comd = new SqlCommand(sql, conn);
                int count = comd.ExecuteNonQuery();
                conn.Close();
                if (count > 0)
                {
                    MessageBox.Show("修改成功");
                    Dataview();
                }
                else
                {
                    MessageBox.Show("修改失败");

                }
            }
        }

        private void 删除ToolStripMenuItem_Click()
        {

        }

        private void skinDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.skinDataGridView1.SelectedRows != null && this.skinDataGridView1.SelectedRows.Count > 0)
            {
                this.skinTextBox1.Text = this.skinDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                skinComboBox1.Text = skinDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                //其它的文本框以此类推，改变Cells的索引值就可以了。
                skinComboBox2.Text = skinDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                // skinComboBox3.Text = skinDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                rtfRichTextBox1.Text = skinDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
        

      
    }
}
