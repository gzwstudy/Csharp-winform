using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;


namespace 酒店管理系统
{
    public partial class FormMain : Skin_Mac
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);//强制关闭程序
        }

        private void 房间维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomWeihu frm1 = new RoomWeihu();
            frm1.MdiParent = this;
              frm1.Show();
        }

        private void 开房结账ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Formyewu frm1 = new Formyewu();
            frm1.MdiParent = this;
            frm1.Show();
        }
    }
}
