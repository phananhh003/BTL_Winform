
namespace TestBaiTapLonWinform2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.panelPictureIcon = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panelHomeBtn = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.panelDashBoardBtn = new System.Windows.Forms.Panel();
            this.DashBoardBtn = new System.Windows.Forms.Button();
            this.panelCookBtn = new System.Windows.Forms.Panel();
            this.CookBtn = new System.Windows.Forms.Button();
            this.panelChartBtn = new System.Windows.Forms.Panel();
            this.ChartBtn = new System.Windows.Forms.Button();
            this.panelSettingBtn = new System.Windows.Forms.Panel();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.panelNavBarContent = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelNavBar.SuspendLayout();
            this.panelPictureIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHomeBtn.SuspendLayout();
            this.panelDashBoardBtn.SuspendLayout();
            this.panelCookBtn.SuspendLayout();
            this.panelChartBtn.SuspendLayout();
            this.panelSettingBtn.SuspendLayout();
            this.panelNavBarContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Dashboard_active_Ic.png");
            this.imageList1.Images.SetKeyName(1, "Dashboard_Ic.png");
            this.imageList1.Images.SetKeyName(2, "exit_Ic.png");
            this.imageList1.Images.SetKeyName(3, "home_active_Ic.png");
            this.imageList1.Images.SetKeyName(4, "home_Ic.png");
            this.imageList1.Images.SetKeyName(5, "pie_chart_Ic.png");
            this.imageList1.Images.SetKeyName(6, "ppl_active_Ic.png");
            this.imageList1.Images.SetKeyName(7, "ppl_Ic.png");
            this.imageList1.Images.SetKeyName(8, "setting_Ic.png");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelNavBar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1382, 977);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tableLayoutPanel1_ControlAdded);
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.panelNavBar.Controls.Add(this.panelNavBarContent);
            this.panelNavBar.Controls.Add(this.panelPictureIcon);
            this.panelNavBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNavBar.Location = new System.Drawing.Point(0, 0);
            this.panelNavBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.panelNavBar.Size = new System.Drawing.Size(100, 977);
            this.panelNavBar.TabIndex = 1;
            // 
            // panelPictureIcon
            // 
            this.panelPictureIcon.Controls.Add(this.pictureBox1);
            this.panelPictureIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPictureIcon.Location = new System.Drawing.Point(5, 10);
            this.panelPictureIcon.Name = "panelPictureIcon";
            this.panelPictureIcon.Size = new System.Drawing.Size(90, 100);
            this.panelPictureIcon.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::TestBaiTapLonWinform2.Properties.Resources.Icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(103, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 971);
            this.panel1.TabIndex = 2;
            this.panel1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tableLayoutPanel1_ControlAdded);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitBtn.Image = global::TestBaiTapLonWinform2.Properties.Resources.exit_Ic;
            this.ExitBtn.Location = new System.Drawing.Point(0, 795);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(90, 72);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            this.ExitBtn.MouseEnter += new System.EventHandler(this.ExitBtn_MouseEnter);
            this.ExitBtn.MouseLeave += new System.EventHandler(this.ExitBtn_MouseLeave);
            // 
            // panelHomeBtn
            // 
            this.panelHomeBtn.Controls.Add(this.HomeBtn);
            this.panelHomeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHomeBtn.Location = new System.Drawing.Point(0, 170);
            this.panelHomeBtn.Name = "panelHomeBtn";
            this.panelHomeBtn.Size = new System.Drawing.Size(90, 100);
            this.panelHomeBtn.TabIndex = 1;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.HomeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HomeBtn.Image = global::TestBaiTapLonWinform2.Properties.Resources.home_Ic;
            this.HomeBtn.Location = new System.Drawing.Point(0, 0);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(90, 100);
            this.HomeBtn.TabIndex = 1;
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.MouseEnter += new System.EventHandler(this.HomeBtn_MouseEnter);
            this.HomeBtn.MouseLeave += new System.EventHandler(this.HomeBtn_MouseLeave);
            // 
            // panelDashBoardBtn
            // 
            this.panelDashBoardBtn.Controls.Add(this.DashBoardBtn);
            this.panelDashBoardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDashBoardBtn.Location = new System.Drawing.Point(0, 270);
            this.panelDashBoardBtn.Name = "panelDashBoardBtn";
            this.panelDashBoardBtn.Size = new System.Drawing.Size(90, 100);
            this.panelDashBoardBtn.TabIndex = 2;
            // 
            // DashBoardBtn
            // 
            this.DashBoardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.DashBoardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DashBoardBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashBoardBtn.FlatAppearance.BorderSize = 0;
            this.DashBoardBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.DashBoardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.DashBoardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.DashBoardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashBoardBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DashBoardBtn.Image = global::TestBaiTapLonWinform2.Properties.Resources.Dashboard_Ic;
            this.DashBoardBtn.Location = new System.Drawing.Point(0, 0);
            this.DashBoardBtn.Margin = new System.Windows.Forms.Padding(0);
            this.DashBoardBtn.Name = "DashBoardBtn";
            this.DashBoardBtn.Size = new System.Drawing.Size(90, 100);
            this.DashBoardBtn.TabIndex = 1;
            this.DashBoardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.DashBoardBtn.UseVisualStyleBackColor = false;
            this.DashBoardBtn.Click += new System.EventHandler(this.DashBoardBtn_Click);
            this.DashBoardBtn.MouseEnter += new System.EventHandler(this.DashBoardBtn_MouseEnter);
            this.DashBoardBtn.MouseLeave += new System.EventHandler(this.DashBoardBtn_MouseLeave);
            // 
            // panelCookBtn
            // 
            this.panelCookBtn.Controls.Add(this.CookBtn);
            this.panelCookBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCookBtn.Location = new System.Drawing.Point(0, 370);
            this.panelCookBtn.Name = "panelCookBtn";
            this.panelCookBtn.Size = new System.Drawing.Size(90, 100);
            this.panelCookBtn.TabIndex = 3;
            // 
            // CookBtn
            // 
            this.CookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.CookBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CookBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CookBtn.FlatAppearance.BorderSize = 0;
            this.CookBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.CookBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.CookBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.CookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CookBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CookBtn.Image = global::TestBaiTapLonWinform2.Properties.Resources.ppl_Ic;
            this.CookBtn.Location = new System.Drawing.Point(0, 0);
            this.CookBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CookBtn.Name = "CookBtn";
            this.CookBtn.Size = new System.Drawing.Size(90, 100);
            this.CookBtn.TabIndex = 1;
            this.CookBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CookBtn.UseVisualStyleBackColor = false;
            this.CookBtn.Click += new System.EventHandler(this.CookBtn_Click);
            this.CookBtn.MouseEnter += new System.EventHandler(this.CookBtn_MouseEnter);
            this.CookBtn.MouseLeave += new System.EventHandler(this.CookBtn_MouseLeave);
            // 
            // panelChartBtn
            // 
            this.panelChartBtn.Controls.Add(this.ChartBtn);
            this.panelChartBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChartBtn.Location = new System.Drawing.Point(0, 470);
            this.panelChartBtn.Name = "panelChartBtn";
            this.panelChartBtn.Size = new System.Drawing.Size(90, 100);
            this.panelChartBtn.TabIndex = 4;
            // 
            // ChartBtn
            // 
            this.ChartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.ChartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ChartBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartBtn.FlatAppearance.BorderSize = 0;
            this.ChartBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ChartBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.ChartBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.ChartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChartBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ChartBtn.Image = global::TestBaiTapLonWinform2.Properties.Resources.pie_chart_Ic;
            this.ChartBtn.Location = new System.Drawing.Point(0, 0);
            this.ChartBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ChartBtn.Name = "ChartBtn";
            this.ChartBtn.Size = new System.Drawing.Size(90, 100);
            this.ChartBtn.TabIndex = 1;
            this.ChartBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ChartBtn.UseVisualStyleBackColor = false;
            this.ChartBtn.Click += new System.EventHandler(this.ChartBtn_Click);
            this.ChartBtn.MouseEnter += new System.EventHandler(this.ChartBtn_MouseEnter);
            this.ChartBtn.MouseLeave += new System.EventHandler(this.ChartBtn_MouseLeave);
            // 
            // panelSettingBtn
            // 
            this.panelSettingBtn.Controls.Add(this.SettingBtn);
            this.panelSettingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSettingBtn.Location = new System.Drawing.Point(0, 570);
            this.panelSettingBtn.Name = "panelSettingBtn";
            this.panelSettingBtn.Size = new System.Drawing.Size(90, 100);
            this.panelSettingBtn.TabIndex = 5;
            // 
            // SettingBtn
            // 
            this.SettingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.SettingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SettingBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingBtn.FlatAppearance.BorderSize = 0;
            this.SettingBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.SettingBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.SettingBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.SettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SettingBtn.Image = global::TestBaiTapLonWinform2.Properties.Resources.setting_Ic;
            this.SettingBtn.Location = new System.Drawing.Point(0, 0);
            this.SettingBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(90, 100);
            this.SettingBtn.TabIndex = 1;
            this.SettingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SettingBtn.UseVisualStyleBackColor = false;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            this.SettingBtn.MouseEnter += new System.EventHandler(this.Setting_MouseEnter);
            this.SettingBtn.MouseLeave += new System.EventHandler(this.Setting_MouseLeave);
            // 
            // panelNavBarContent
            // 
            this.panelNavBarContent.Controls.Add(this.panelSettingBtn);
            this.panelNavBarContent.Controls.Add(this.panelChartBtn);
            this.panelNavBarContent.Controls.Add(this.panelCookBtn);
            this.panelNavBarContent.Controls.Add(this.panelDashBoardBtn);
            this.panelNavBarContent.Controls.Add(this.panelHomeBtn);
            this.panelNavBarContent.Controls.Add(this.ExitBtn);
            this.panelNavBarContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNavBarContent.Location = new System.Drawing.Point(5, 110);
            this.panelNavBarContent.Name = "panelNavBarContent";
            this.panelNavBarContent.Padding = new System.Windows.Forms.Padding(0, 170, 0, 0);
            this.panelNavBarContent.Size = new System.Drawing.Size(90, 867);
            this.panelNavBarContent.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 977);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelNavBar.ResumeLayout(false);
            this.panelPictureIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHomeBtn.ResumeLayout(false);
            this.panelDashBoardBtn.ResumeLayout(false);
            this.panelCookBtn.ResumeLayout(false);
            this.panelChartBtn.ResumeLayout(false);
            this.panelSettingBtn.ResumeLayout(false);
            this.panelNavBarContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Panel panelPictureIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelNavBarContent;
        private System.Windows.Forms.Panel panelSettingBtn;
        private System.Windows.Forms.Button SettingBtn;
        private System.Windows.Forms.Panel panelChartBtn;
        private System.Windows.Forms.Button ChartBtn;
        private System.Windows.Forms.Panel panelCookBtn;
        private System.Windows.Forms.Button CookBtn;
        private System.Windows.Forms.Panel panelDashBoardBtn;
        private System.Windows.Forms.Button DashBoardBtn;
        private System.Windows.Forms.Panel panelHomeBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

