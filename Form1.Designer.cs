namespace 鼠标测试工具
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            windowBar1 = new AntdUI.WindowBar();
            label_xy = new AntdUI.Label();
            button_github = new AntdUI.Button();
            label_left = new AntdUI.Label();
            label_right = new AntdUI.Label();
            panel_run = new AntdUI.Panel();
            button_clear = new AntdUI.Button();
            tableLayoutPanel_clickStatus = new TableLayoutPanel();
            panel_rightClick = new AntdUI.Panel();
            panel_leftClick = new AntdUI.Panel();
            tableLayoutPanel_wheel = new TableLayoutPanel();
            panel_wheeldown = new AntdUI.Panel();
            label_wheelDown = new AntdUI.Label();
            panel_wheelUp = new AntdUI.Panel();
            label_wheelUp = new AntdUI.Label();
            label1 = new AntdUI.Label();
            panel_run.SuspendLayout();
            tableLayoutPanel_clickStatus.SuspendLayout();
            panel_rightClick.SuspendLayout();
            panel_leftClick.SuspendLayout();
            tableLayoutPanel_wheel.SuspendLayout();
            panel_wheeldown.SuspendLayout();
            panel_wheelUp.SuspendLayout();
            SuspendLayout();
            // 
            // windowBar1
            // 
            windowBar1.Dock = DockStyle.Top;
            windowBar1.Font = new Font("Microsoft YaHei UI", 15F);
            windowBar1.IconSvg = resources.GetString("windowBar1.IconSvg");
            windowBar1.Location = new Point(0, 0);
            windowBar1.Name = "windowBar1";
            windowBar1.Size = new Size(1206, 71);
            windowBar1.SubText = "by ZeroDeng";
            windowBar1.TabIndex = 0;
            windowBar1.Text = "鼠标测试工具";
            // 
            // label_xy
            // 
            label_xy.AutoSizeMode = AntdUI.TAutoSize.Auto;
            label_xy.BackColor = Color.Transparent;
            label_xy.ForeColor = Color.FromArgb(153, 204, 102);
            label_xy.Location = new Point(23, 596);
            label_xy.Name = "label_xy";
            label_xy.Size = new Size(0, 0);
            label_xy.TabIndex = 1;
            label_xy.Text = "";
            // 
            // button_github
            // 
            button_github.AutoSizeMode = AntdUI.TAutoSize.Auto;
            button_github.Dock = DockStyle.Right;
            button_github.Font = new Font("Microsoft YaHei UI", 16F);
            button_github.ImageSvg = resources.GetString("button_github.ImageSvg");
            button_github.Location = new Point(1132, 6);
            button_github.Name = "button_github";
            button_github.Shape = AntdUI.TShape.Circle;
            button_github.Size = new Size(68, 68);
            button_github.TabIndex = 27;
            button_github.Click += button_github_Click;
            // 
            // label_left
            // 
            label_left.Dock = DockStyle.Fill;
            label_left.Font = new Font("Microsoft YaHei UI", 15F);
            label_left.ForeColor = Color.White;
            label_left.Location = new Point(0, 0);
            label_left.Name = "label_left";
            label_left.Prefix = "左键点击：";
            label_left.Size = new Size(557, 131);
            label_left.Suffix = "次";
            label_left.TabIndex = 30;
            label_left.Text = "0";
            label_left.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_right
            // 
            label_right.Dock = DockStyle.Fill;
            label_right.Font = new Font("Microsoft YaHei UI", 15F);
            label_right.ForeColor = Color.White;
            label_right.Location = new Point(0, 0);
            label_right.Name = "label_right";
            label_right.Prefix = "右键点击：";
            label_right.Size = new Size(557, 131);
            label_right.Suffix = "次";
            label_right.TabIndex = 31;
            label_right.Text = "0";
            label_right.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_run
            // 
            panel_run.Back = Color.FromArgb(18, 64, 171);
            panel_run.Controls.Add(label_xy);
            panel_run.Controls.Add(button_clear);
            panel_run.Controls.Add(button_github);
            panel_run.Controls.Add(tableLayoutPanel_clickStatus);
            panel_run.Controls.Add(label1);
            panel_run.Dock = DockStyle.Fill;
            panel_run.Location = new Point(0, 71);
            panel_run.Name = "panel_run";
            panel_run.Shadow = 5;
            panel_run.Size = new Size(1206, 769);
            panel_run.TabIndex = 32;
            panel_run.Text = "操作区";
            // 
            // button_clear
            // 
            button_clear.AutoSizeMode = AntdUI.TAutoSize.Auto;
            button_clear.Dock = DockStyle.Right;
            button_clear.Font = new Font("Microsoft YaHei UI", 16F);
            button_clear.ImageSvg = resources.GetString("button_clear.ImageSvg");
            button_clear.Location = new Point(1064, 6);
            button_clear.Name = "button_clear";
            button_clear.RespondRealAreas = true;
            button_clear.Shape = AntdUI.TShape.Circle;
            button_clear.Size = new Size(68, 68);
            button_clear.TabIndex = 28;
            button_clear.Click += button_clear_Click;
            // 
            // tableLayoutPanel_clickStatus
            // 
            tableLayoutPanel_clickStatus.BackColor = Color.Transparent;
            tableLayoutPanel_clickStatus.ColumnCount = 3;
            tableLayoutPanel_clickStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_clickStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel_clickStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_clickStatus.Controls.Add(panel_rightClick, 2, 0);
            tableLayoutPanel_clickStatus.Controls.Add(panel_leftClick, 0, 0);
            tableLayoutPanel_clickStatus.Controls.Add(tableLayoutPanel_wheel, 1, 0);
            tableLayoutPanel_clickStatus.Dock = DockStyle.Bottom;
            tableLayoutPanel_clickStatus.Location = new Point(6, 632);
            tableLayoutPanel_clickStatus.Margin = new Padding(0);
            tableLayoutPanel_clickStatus.Name = "tableLayoutPanel_clickStatus";
            tableLayoutPanel_clickStatus.RowCount = 1;
            tableLayoutPanel_clickStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_clickStatus.Size = new Size(1194, 131);
            tableLayoutPanel_clickStatus.TabIndex = 2;
            // 
            // panel_rightClick
            // 
            panel_rightClick.Back = Color.FromArgb(70, 113, 213);
            panel_rightClick.Controls.Add(label_right);
            panel_rightClick.Dock = DockStyle.Fill;
            panel_rightClick.Location = new Point(637, 0);
            panel_rightClick.Margin = new Padding(0);
            panel_rightClick.Name = "panel_rightClick";
            panel_rightClick.Radius = 0;
            panel_rightClick.Size = new Size(557, 131);
            panel_rightClick.TabIndex = 1;
            panel_rightClick.Text = "panel2";
            // 
            // panel_leftClick
            // 
            panel_leftClick.Back = Color.FromArgb(70, 113, 213);
            panel_leftClick.Controls.Add(label_left);
            panel_leftClick.Dock = DockStyle.Fill;
            panel_leftClick.Location = new Point(0, 0);
            panel_leftClick.Margin = new Padding(0);
            panel_leftClick.Name = "panel_leftClick";
            panel_leftClick.Radius = 0;
            panel_leftClick.Size = new Size(557, 131);
            panel_leftClick.TabIndex = 0;
            panel_leftClick.Text = "panel1";
            // 
            // tableLayoutPanel_wheel
            // 
            tableLayoutPanel_wheel.ColumnCount = 1;
            tableLayoutPanel_wheel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_wheel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_wheel.Controls.Add(panel_wheeldown, 0, 1);
            tableLayoutPanel_wheel.Controls.Add(panel_wheelUp, 0, 0);
            tableLayoutPanel_wheel.Dock = DockStyle.Fill;
            tableLayoutPanel_wheel.Location = new Point(560, 0);
            tableLayoutPanel_wheel.Margin = new Padding(3, 0, 3, 0);
            tableLayoutPanel_wheel.Name = "tableLayoutPanel_wheel";
            tableLayoutPanel_wheel.RowCount = 2;
            tableLayoutPanel_wheel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_wheel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_wheel.Size = new Size(74, 131);
            tableLayoutPanel_wheel.TabIndex = 2;
            // 
            // panel_wheeldown
            // 
            panel_wheeldown.Back = Color.FromArgb(70, 113, 213);
            panel_wheeldown.Controls.Add(label_wheelDown);
            panel_wheeldown.Dock = DockStyle.Fill;
            panel_wheeldown.Location = new Point(0, 65);
            panel_wheeldown.Margin = new Padding(0);
            panel_wheeldown.Name = "panel_wheeldown";
            panel_wheeldown.Radius = 0;
            panel_wheeldown.Size = new Size(74, 66);
            panel_wheeldown.TabIndex = 2;
            panel_wheeldown.Text = "panel1";
            // 
            // label_wheelDown
            // 
            label_wheelDown.Dock = DockStyle.Fill;
            label_wheelDown.Font = new Font("Microsoft YaHei UI", 13F);
            label_wheelDown.ForeColor = Color.White;
            label_wheelDown.Location = new Point(0, 0);
            label_wheelDown.Name = "label_wheelDown";
            label_wheelDown.Prefix = "";
            label_wheelDown.Size = new Size(74, 66);
            label_wheelDown.Suffix = "";
            label_wheelDown.TabIndex = 34;
            label_wheelDown.Text = "0";
            label_wheelDown.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_wheelUp
            // 
            panel_wheelUp.Back = Color.FromArgb(70, 113, 213);
            panel_wheelUp.Controls.Add(label_wheelUp);
            panel_wheelUp.Dock = DockStyle.Fill;
            panel_wheelUp.Location = new Point(0, 0);
            panel_wheelUp.Margin = new Padding(0);
            panel_wheelUp.Name = "panel_wheelUp";
            panel_wheelUp.Radius = 0;
            panel_wheelUp.Size = new Size(74, 65);
            panel_wheelUp.TabIndex = 1;
            panel_wheelUp.Text = "panel1";
            // 
            // label_wheelUp
            // 
            label_wheelUp.Dock = DockStyle.Fill;
            label_wheelUp.Font = new Font("Microsoft YaHei UI", 13F);
            label_wheelUp.ForeColor = Color.White;
            label_wheelUp.Location = new Point(0, 0);
            label_wheelUp.Name = "label_wheelUp";
            label_wheelUp.Prefix = "";
            label_wheelUp.Size = new Size(74, 65);
            label_wheelUp.Suffix = "";
            label_wheelUp.TabIndex = 33;
            label_wheelUp.Text = "0";
            label_wheelUp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSizeMode = AntdUI.TAutoSize.Auto;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft YaHei UI", 13F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(320, 31);
            label1.TabIndex = 0;
            label1.Text = "将鼠标指针移入此区域进行测试";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1206, 840);
            Controls.Add(panel_run);
            Controls.Add(windowBar1);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "鼠标测试工具";
            Load += Form1_Load;
            panel_run.ResumeLayout(false);
            panel_run.PerformLayout();
            tableLayoutPanel_clickStatus.ResumeLayout(false);
            panel_rightClick.ResumeLayout(false);
            panel_leftClick.ResumeLayout(false);
            tableLayoutPanel_wheel.ResumeLayout(false);
            panel_wheeldown.ResumeLayout(false);
            panel_wheelUp.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.WindowBar windowBar1;
        private AntdUI.Button button_github;
        private AntdUI.Label label_left;
        private AntdUI.Label label_right;
        private AntdUI.Panel panel_run;
        private AntdUI.Label label1;
        private AntdUI.Label label_wheelUp;
        private AntdUI.Label label_wheelDown;
        private AntdUI.Label label_xy;
        private TableLayoutPanel tableLayoutPanel_clickStatus;
        private AntdUI.Panel panel_rightClick;
        private AntdUI.Panel panel_leftClick;
        private TableLayoutPanel tableLayoutPanel_wheel;
        private AntdUI.Panel panel_wheeldown;
        private AntdUI.Panel panel_wheelUp;
        private AntdUI.Button button_clear;
    }
}
