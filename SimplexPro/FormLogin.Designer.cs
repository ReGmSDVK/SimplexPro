namespace SimplexPro
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.passPanel = new System.Windows.Forms.Panel();
            this.iconEye = new FontAwesome.Sharp.IconPictureBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.SignButton = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.iconKey = new FontAwesome.Sharp.IconPictureBox();
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.exitPic = new FontAwesome.Sharp.IconPictureBox();
            this.hidePic = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            this.topPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePic)).BeginInit();
            this.SuspendLayout();
            // 
            // passPanel
            // 
            this.passPanel.BackColor = System.Drawing.Color.White;
            this.passPanel.Location = new System.Drawing.Point(130, 352);
            this.passPanel.Name = "passPanel";
            this.passPanel.Size = new System.Drawing.Size(327, 1);
            this.passPanel.TabIndex = 20;
            // 
            // iconEye
            // 
            this.iconEye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.iconEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconEye.IconColor = System.Drawing.Color.White;
            this.iconEye.IconSize = 40;
            this.iconEye.Location = new System.Drawing.Point(417, 314);
            this.iconEye.Name = "iconEye";
            this.iconEye.Size = new System.Drawing.Size(40, 40);
            this.iconEye.TabIndex = 21;
            this.iconEye.TabStop = false;
            this.iconEye.Click += new System.EventHandler(this.iconEye_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.White;
            this.loginPanel.Location = new System.Drawing.Point(130, 277);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(327, 1);
            this.loginPanel.TabIndex = 19;
            // 
            // SignButton
            // 
            this.SignButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.SignButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SignButton.FlatAppearance.BorderSize = 2;
            this.SignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignButton.ForeColor = System.Drawing.Color.White;
            this.SignButton.Location = new System.Drawing.Point(157, 412);
            this.SignButton.Name = "SignButton";
            this.SignButton.Size = new System.Drawing.Size(251, 46);
            this.SignButton.TabIndex = 18;
            this.SignButton.Text = "Sign in";
            this.SignButton.UseVisualStyleBackColor = false;
            this.SignButton.Click += new System.EventHandler(this.SignButton_Click);
            this.SignButton.MouseEnter += new System.EventHandler(this.SignButton_MouseEnter);
            this.SignButton.MouseLeave += new System.EventHandler(this.SignButton_MouseLeave);
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passBox.ForeColor = System.Drawing.Color.White;
            this.passBox.Location = new System.Drawing.Point(130, 312);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(327, 31);
            this.passBox.TabIndex = 15;
            this.passBox.UseSystemPasswordChar = true;
            this.passBox.Click += new System.EventHandler(this.passBox_Click);
            this.passBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passBox_KeyPress);
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.loginBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.ForeColor = System.Drawing.Color.White;
            this.loginBox.Location = new System.Drawing.Point(130, 237);
            this.loginBox.MaxLength = 16;
            this.loginBox.Name = "loginBox";
            this.loginBox.ShortcutsEnabled = false;
            this.loginBox.Size = new System.Drawing.Size(327, 31);
            this.loginBox.TabIndex = 14;
            this.loginBox.Click += new System.EventHandler(this.loginBox_Click);
            this.loginBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginBox_KeyPress);
            // 
            // iconKey
            // 
            this.iconKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.iconKey.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconKey.IconColor = System.Drawing.Color.White;
            this.iconKey.IconSize = 50;
            this.iconKey.Location = new System.Drawing.Point(74, 308);
            this.iconKey.Name = "iconKey";
            this.iconKey.Size = new System.Drawing.Size(50, 50);
            this.iconKey.TabIndex = 17;
            this.iconKey.TabStop = false;
            // 
            // iconUser
            // 
            this.iconUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.iconUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconUser.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconUser.IconSize = 50;
            this.iconUser.Location = new System.Drawing.Point(74, 233);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(50, 50);
            this.iconUser.TabIndex = 16;
            this.iconUser.TabStop = false;
            // 
            // logoPic
            // 
            this.logoPic.Image = global::SimplexPro.Properties.Resources.Logo;
            this.logoPic.Location = new System.Drawing.Point(172, 76);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(217, 129);
            this.logoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPic.TabIndex = 13;
            this.logoPic.TabStop = false;
            this.logoPic.Click += new System.EventHandler(this.logoPic_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.topPanel.Controls.Add(this.tableLayoutPanel1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(542, 39);
            this.topPanel.TabIndex = 22;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Controls.Add(this.exitPic, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.hidePic, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(437, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(105, 34);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // exitPic
            // 
            this.exitPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.exitPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.exitPic.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.exitPic.IconColor = System.Drawing.Color.White;
            this.exitPic.IconSize = 30;
            this.exitPic.Location = new System.Drawing.Point(71, 2);
            this.exitPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitPic.Name = "exitPic";
            this.exitPic.Size = new System.Drawing.Size(31, 30);
            this.exitPic.TabIndex = 2;
            this.exitPic.TabStop = false;
            this.exitPic.Click += new System.EventHandler(this.exitPic_Click);
            this.exitPic.MouseEnter += new System.EventHandler(this.exitPic_MouseEnter);
            this.exitPic.MouseLeave += new System.EventHandler(this.exitPic_MouseLeave);
            // 
            // hidePic
            // 
            this.hidePic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.hidePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hidePic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hidePic.IconChar = FontAwesome.Sharp.IconChar.MinusSquare;
            this.hidePic.IconColor = System.Drawing.Color.White;
            this.hidePic.IconSize = 29;
            this.hidePic.Location = new System.Drawing.Point(36, 2);
            this.hidePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hidePic.Name = "hidePic";
            this.hidePic.Size = new System.Drawing.Size(29, 30);
            this.hidePic.TabIndex = 3;
            this.hidePic.TabStop = false;
            this.hidePic.Click += new System.EventHandler(this.hidePic_Click);
            this.hidePic.MouseEnter += new System.EventHandler(this.hidePic_MouseEnter);
            this.hidePic.MouseLeave += new System.EventHandler(this.hidePic_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(534, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 497);
            this.panel1.TabIndex = 23;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 528);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(534, 8);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 489);
            this.panel2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(167, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "_____________";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(542, 536);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.passPanel);
            this.Controls.Add(this.iconEye);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.SignButton);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.iconKey);
            this.Controls.Add(this.iconUser);
            this.Controls.Add(this.logoPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.iconEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exitPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel passPanel;
        private FontAwesome.Sharp.IconPictureBox iconEye;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button SignButton;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox loginBox;
        private FontAwesome.Sharp.IconPictureBox iconKey;
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private System.Windows.Forms.PictureBox logoPic;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconPictureBox exitPic;
        private FontAwesome.Sharp.IconPictureBox hidePic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}