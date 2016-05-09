namespace 酒店管理系统
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.skinMenuStrip = new CCWin.SkinControl.SkinMenuStrip();
            this.系统维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.房间维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.业务操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.业务查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开房结账ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinMenuStrip
            // 
            this.skinMenuStrip.Arrow = System.Drawing.Color.Black;
            this.skinMenuStrip.Back = System.Drawing.Color.White;
            this.skinMenuStrip.BackRadius = 4;
            this.skinMenuStrip.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinMenuStrip.Base = System.Drawing.Color.Silver;
            this.skinMenuStrip.BaseFore = System.Drawing.Color.Black;
            this.skinMenuStrip.BaseForeAnamorphosis = false;
            this.skinMenuStrip.BaseForeAnamorphosisBorder = 4;
            this.skinMenuStrip.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinMenuStrip.BaseHoverFore = System.Drawing.Color.White;
            this.skinMenuStrip.BaseItemAnamorphosis = true;
            this.skinMenuStrip.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip.BaseItemBorderShow = true;
            this.skinMenuStrip.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip.BaseItemDown")));
            this.skinMenuStrip.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip.BaseItemMouse")));
            this.skinMenuStrip.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip.BaseItemRadius = 4;
            this.skinMenuStrip.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinMenuStrip.Fore = System.Drawing.Color.Black;
            this.skinMenuStrip.HoverFore = System.Drawing.Color.White;
            this.skinMenuStrip.ItemAnamorphosis = true;
            this.skinMenuStrip.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip.ItemBorderShow = true;
            this.skinMenuStrip.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip.ItemRadius = 4;
            this.skinMenuStrip.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统维护ToolStripMenuItem,
            this.业务操作ToolStripMenuItem,
            this.业务查询ToolStripMenuItem});
            this.skinMenuStrip.Location = new System.Drawing.Point(4, 32);
            this.skinMenuStrip.Name = "skinMenuStrip";
            this.skinMenuStrip.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip.Size = new System.Drawing.Size(747, 25);
            this.skinMenuStrip.SkinAllColor = true;
            this.skinMenuStrip.TabIndex = 0;
            this.skinMenuStrip.Text = "skinMenuStrip1";
            this.skinMenuStrip.TitleAnamorphosis = true;
            this.skinMenuStrip.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinMenuStrip.TitleRadius = 4;
            this.skinMenuStrip.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 系统维护ToolStripMenuItem
            // 
            this.系统维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.房间维护ToolStripMenuItem});
            this.系统维护ToolStripMenuItem.Name = "系统维护ToolStripMenuItem";
            this.系统维护ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统维护ToolStripMenuItem.Text = "系统维护";
            // 
            // 房间维护ToolStripMenuItem
            // 
            this.房间维护ToolStripMenuItem.Name = "房间维护ToolStripMenuItem";
            this.房间维护ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.房间维护ToolStripMenuItem.Text = "房间维护";
            this.房间维护ToolStripMenuItem.Click += new System.EventHandler(this.房间维护ToolStripMenuItem_Click);
            // 
            // 业务操作ToolStripMenuItem
            // 
            this.业务操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开房结账ToolStripMenuItem});
            this.业务操作ToolStripMenuItem.Name = "业务操作ToolStripMenuItem";
            this.业务操作ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.业务操作ToolStripMenuItem.Text = "业务操作";
            // 
            // 业务查询ToolStripMenuItem
            // 
            this.业务查询ToolStripMenuItem.Name = "业务查询ToolStripMenuItem";
            this.业务查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.业务查询ToolStripMenuItem.Text = "业务查询";
            // 
            // 开房结账ToolStripMenuItem
            // 
            this.开房结账ToolStripMenuItem.Name = "开房结账ToolStripMenuItem";
            this.开房结账ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.开房结账ToolStripMenuItem.Text = "开房结账";
            this.开房结账ToolStripMenuItem.Click += new System.EventHandler(this.开房结账ToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 451);
            this.Controls.Add(this.skinMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.skinMenuStrip;
            this.Name = "FormMain";
            this.Text = "宾馆管理系统-主界面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.skinMenuStrip.ResumeLayout(false);
            this.skinMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinMenuStrip skinMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 系统维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 业务操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 业务查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 房间维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开房结账ToolStripMenuItem;
    }
}