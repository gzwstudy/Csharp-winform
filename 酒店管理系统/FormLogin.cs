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
    public partial class Login : Skin_Mac
    {
        
            
        public Login()
        {
            InitializeComponent();
        }

        

         private void ENTER_login_Click(object sender, EventArgs e)
         {
             if (txUsername.Text =="")
             {
                 MessageBox.Show("请输入账号");
             }
             else
             {
                 SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Hotel;Integrated Security=True");

                 try
                 {
                     string sql = "select * from  Admin where Admin.Username=@username and Admin.Password=@pwd";
                     SqlCommand cmd = new SqlCommand(sql, con);
                     cmd.Parameters.AddWithValue("@username", txUsername.Text);
                     cmd.Parameters.AddWithValue("@pwd", txPassword.Text);

                     con.Open();
                     //cmd.Connection = con;

                     SqlDataAdapter da = new SqlDataAdapter(cmd);
                     DataTable dt = new DataTable();
                     da.Fill(dt);

                     if (dt.Rows.Count > 0)
                     {
                         MessageBox.Show("成功！");
                         this.Hide();
                         FormMain f2 = new FormMain();
                         f2.Show();
                     }
                     else
                     {
                         MessageBox.Show("失败！");
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
                 finally
                 {
                     con.Close();
                 }
             }
         }
    }
}
