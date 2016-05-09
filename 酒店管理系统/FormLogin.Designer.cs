namespace 酒店管理系统
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Login_lable1 = new CCWin.SkinControl.SkinLabel();
            this.Login_Label2 = new CCWin.SkinControl.SkinLabel();
            this.txUsername = new CCWin.SkinControl.SkinTextBox();
            this.txPassword = new CCWin.SkinControl.SkinTextBox();
            this.ENTER_login = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // Login_lable1
            // 
            this.Login_lable1.AutoSize = true;
            this.Login_lable1.BackColor = System.Drawing.Color.Transparent;
            this.Login_lable1.BorderColor = System.Drawing.Color.White;
            this.Login_lable1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_lable1.Location = new System.Drawing.Point(45, 98);
            this.Login_lable1.Name = "Login_lable1";
            this.Login_lable1.Size = new System.Drawing.Size(56, 17);
            this.Login_lable1.TabIndex = 0;
            this.Login_lable1.Text = "用户名：";
            // 
            // Login_Label2
            // 
            this.Login_Label2.AutoSize = true;
            this.Login_Label2.BackColor = System.Drawing.Color.Transparent;
            this.Login_Label2.BorderColor = System.Drawing.Color.White;
            this.Login_Label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_Label2.Location = new System.Drawing.Point(45, 161);
            this.Login_Label2.Name = "Login_Label2";
            this.Login_Label2.Size = new System.Drawing.Size(48, 17);
            this.Login_Label2.TabIndex = 1;
            this.Login_Label2.Text = "密 码：";
            // 
            // txUsername
            // 
            this.txUsername.BackColor = System.Drawing.Color.Transparent;
            this.txUsername.DownBack = null;
            this.txUsername.Icon = null;
            this.txUsername.IconIsButton = false;
            this.txUsername.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txUsername.IsPasswordChat = '\0';
            this.txUsername.IsSystemPasswordChar = false;
            this.txUsername.Lines = new string[0];
            this.txUsername.Location = new System.Drawing.Point(93, 87);
            this.txUsername.Margin = new System.Windows.Forms.Padding(0);
            this.txUsername.MaxLength = 32767;
            this.txUsername.MinimumSize = new System.Drawing.Size(28, 28);
            this.txUsername.MouseBack = null;
            this.txUsername.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txUsername.Multiline = false;
            this.txUsername.Name = "txUsername";
            this.txUsername.NormlBack = null;
            this.txUsername.Padding = new System.Windows.Forms.Padding(5);
            this.txUsername.ReadOnly = false;
            this.txUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txUsername.Size = new System.Drawing.Size(151, 28);
            // 
            // 
            // 
            this.txUsername.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txUsername.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txUsername.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txUsername.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txUsername.SkinTxt.Name = "BaseText";
            this.txUsername.SkinTxt.Size = new System.Drawing.Size(141, 18);
            this.txUsername.SkinTxt.TabIndex = 0;
            this.txUsername.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txUsername.SkinTxt.WaterText = "";
            this.txUsername.TabIndex = 2;
            this.txUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txUsername.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txUsername.WaterText = "";
            this.txUsername.WordWrap = true;
            // 
            // txPassword
            // 
            this.txPassword.BackColor = System.Drawing.Color.Transparent;
            this.txPassword.DownBack = null;
            this.txPassword.Icon = null;
            this.txPassword.IconIsButton = false;
            this.txPassword.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txPassword.IsPasswordChat = '\0';
            this.txPassword.IsSystemPasswordChar = false;
            this.txPassword.Lines = new string[0];
            this.txPassword.Location = new System.Drawing.Point(96, 150);
            this.txPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txPassword.MaxLength = 32767;
            this.txPassword.MinimumSize = new System.Drawing.Size(28, 28);
            this.txPassword.MouseBack = null;
            this.txPassword.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txPassword.Multiline = false;
            this.txPassword.Name = "txPassword";
            this.txPassword.NormlBack = null;
            this.txPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txPassword.ReadOnly = false;
            this.txPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txPassword.Size = new System.Drawing.Size(148, 28);
            // 
            // 
            // 
            this.txPassword.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txPassword.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPassword.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txPassword.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txPassword.SkinTxt.Name = "BaseText";
            this.txPassword.SkinTxt.Size = new System.Drawing.Size(138, 18);
            this.txPassword.SkinTxt.TabIndex = 0;
            this.txPassword.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txPassword.SkinTxt.WaterText = "";
            this.txPassword.TabIndex = 3;
            this.txPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txPassword.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txPassword.WaterText = "";
            this.txPassword.WordWrap = true;
            // 
            // ENTER_login
            // 
            this.ENTER_login.BackColor = System.Drawing.Color.Transparent;
            this.ENTER_login.BaseColor = System.Drawing.Color.Gray;
            this.ENTER_login.BorderColor = System.Drawing.Color.Silver;
            this.ENTER_login.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ENTER_login.DownBack = null;
            this.ENTER_login.DownBaseColor = System.Drawing.Color.Silver;
            this.ENTER_login.Location = new System.Drawing.Point(127, 211);
            this.ENTER_login.MouseBack = null;
            this.ENTER_login.MouseBaseColor = System.Drawing.Color.Silver;
            this.ENTER_login.Name = "ENTER_login";
            this.ENTER_login.NormlBack = null;
            this.ENTER_login.Size = new System.Drawing.Size(75, 31);
            this.ENTER_login.TabIndex = 4;
            this.ENTER_login.Text = "确定登录";
            this.ENTER_login.UseVisualStyleBackColor = false;
            this.ENTER_login.Click += new System.EventHandler(this.ENTER_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(322, 311);
            this.Controls.Add(this.ENTER_login);
            this.Controls.Add(this.txPassword);
            this.Controls.Add(this.txUsername);
            this.Controls.Add(this.Login_Label2);
            this.Controls.Add(this.Login_lable1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel Login_lable1;
        private CCWin.SkinControl.SkinLabel Login_Label2;
        private CCWin.SkinControl.SkinTextBox txUsername;
        private CCWin.SkinControl.SkinTextBox txPassword;
        private CCWin.SkinControl.SkinButton ENTER_login;

    }
}

