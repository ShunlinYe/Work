namespace AnnualLottery
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ZeroLevel = new System.Windows.Forms.RadioButton();
            this.FirstLevel = new System.Windows.Forms.RadioButton();
            this.ThirdLevel = new System.Windows.Forms.RadioButton();
            this.ForthLevel = new System.Windows.Forms.RadioButton();
            this.FifthLevel = new System.Windows.Forms.RadioButton();
            this.SixthLevel = new System.Windows.Forms.RadioButton();
            this.SeventhLevel = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.MainSplit = new System.Windows.Forms.SplitContainer();
            this.LayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UpDownSliptContainer = new System.Windows.Forms.SplitContainer();
            this.SecondLevel = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).BeginInit();
            this.MainSplit.Panel1.SuspendLayout();
            this.MainSplit.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownSliptContainer)).BeginInit();
            this.UpDownSliptContainer.Panel1.SuspendLayout();
            this.UpDownSliptContainer.Panel2.SuspendLayout();
            this.UpDownSliptContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ZeroLevel
            // 
            this.ZeroLevel.Appearance = System.Windows.Forms.Appearance.Button;
            this.ZeroLevel.AutoSize = true;
            this.ZeroLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(27)))), ((int)(((byte)(0)))));
            this.ZeroLevel.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ZeroLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZeroLevel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ZeroLevel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.ZeroLevel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroLevel.Location = new System.Drawing.Point(25, 4);
            this.ZeroLevel.Name = "ZeroLevel";
            this.ZeroLevel.Size = new System.Drawing.Size(115, 56);
            this.ZeroLevel.TabIndex = 0;
            this.ZeroLevel.Text = "总经理特别奖";
            this.ZeroLevel.UseVisualStyleBackColor = false;
            this.ZeroLevel.CheckedChanged += new System.EventHandler(this.Level_CheckedChanged);
            // 
            // FirstLevel
            // 
            this.FirstLevel.Appearance = System.Windows.Forms.Appearance.Button;
            this.FirstLevel.AutoSize = true;
            this.FirstLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(27)))), ((int)(((byte)(0)))));
            this.FirstLevel.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FirstLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstLevel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FirstLevel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.FirstLevel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstLevel.Location = new System.Drawing.Point(25, 4);
            this.FirstLevel.Name = "FirstLevel";
            this.FirstLevel.Size = new System.Drawing.Size(115, 56);
            this.FirstLevel.TabIndex = 0;
            this.FirstLevel.Text = "一等奖";
            this.FirstLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FirstLevel.UseVisualStyleBackColor = false;
            this.FirstLevel.CheckedChanged += new System.EventHandler(this.Level_CheckedChanged);
            // 
            // ThirdLevel
            // 
            this.ThirdLevel.Appearance = System.Windows.Forms.Appearance.Button;
            this.ThirdLevel.AutoSize = true;
            this.ThirdLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(27)))), ((int)(((byte)(0)))));
            this.ThirdLevel.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ThirdLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThirdLevel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdLevel.Location = new System.Drawing.Point(269, 4);
            this.ThirdLevel.Name = "ThirdLevel";
            this.ThirdLevel.Size = new System.Drawing.Size(115, 56);
            this.ThirdLevel.TabIndex = 2;
            this.ThirdLevel.Text = "三等奖";
            this.ThirdLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ThirdLevel.UseVisualStyleBackColor = false;
            this.ThirdLevel.CheckedChanged += new System.EventHandler(this.Level_CheckedChanged);
            // 
            // ForthLevel
            // 
            this.ForthLevel.Appearance = System.Windows.Forms.Appearance.Button;
            this.ForthLevel.AutoSize = true;
            this.ForthLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(27)))), ((int)(((byte)(0)))));
            this.ForthLevel.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ForthLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ForthLevel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForthLevel.Location = new System.Drawing.Point(391, 4);
            this.ForthLevel.Name = "ForthLevel";
            this.ForthLevel.Size = new System.Drawing.Size(115, 56);
            this.ForthLevel.TabIndex = 3;
            this.ForthLevel.Text = "四等奖";
            this.ForthLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ForthLevel.UseVisualStyleBackColor = false;
            this.ForthLevel.CheckedChanged += new System.EventHandler(this.Level_CheckedChanged);
            // 
            // FifthLevel
            // 
            this.FifthLevel.Appearance = System.Windows.Forms.Appearance.Button;
            this.FifthLevel.AutoSize = true;
            this.FifthLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(27)))), ((int)(((byte)(0)))));
            this.FifthLevel.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FifthLevel.Checked = true;
            this.FifthLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FifthLevel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FifthLevel.Location = new System.Drawing.Point(513, 4);
            this.FifthLevel.Name = "FifthLevel";
            this.FifthLevel.Size = new System.Drawing.Size(115, 56);
            this.FifthLevel.TabIndex = 4;
            this.FifthLevel.TabStop = true;
            this.FifthLevel.Text = "五等奖";
            this.FifthLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FifthLevel.UseVisualStyleBackColor = false;
            this.FifthLevel.CheckedChanged += new System.EventHandler(this.Level_CheckedChanged);
            // 
            // SixthLevel
            // 
            this.SixthLevel.Appearance = System.Windows.Forms.Appearance.Button;
            this.SixthLevel.AutoSize = true;
            this.SixthLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(27)))), ((int)(((byte)(0)))));
            this.SixthLevel.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SixthLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SixthLevel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixthLevel.Location = new System.Drawing.Point(634, 4);
            this.SixthLevel.Name = "SixthLevel";
            this.SixthLevel.Size = new System.Drawing.Size(92, 56);
            this.SixthLevel.TabIndex = 5;
            this.SixthLevel.Text = "六等奖";
            this.SixthLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SixthLevel.UseVisualStyleBackColor = false;
            this.SixthLevel.CheckedChanged += new System.EventHandler(this.Level_CheckedChanged);
            // 
            // SeventhLevel
            // 
            this.SeventhLevel.Appearance = System.Windows.Forms.Appearance.Button;
            this.SeventhLevel.AutoSize = true;
            this.SeventhLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(27)))), ((int)(((byte)(0)))));
            this.SeventhLevel.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SeventhLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeventhLevel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeventhLevel.Location = new System.Drawing.Point(634, 4);
            this.SeventhLevel.Name = "SeventhLevel";
            this.SeventhLevel.Size = new System.Drawing.Size(92, 56);
            this.SeventhLevel.TabIndex = 5;
            this.SeventhLevel.Text = "七等奖";
            this.SeventhLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SeventhLevel.UseVisualStyleBackColor = false;
            this.SeventhLevel.CheckedChanged += new System.EventHandler(this.Level_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MainSplit);
            this.splitContainer1.Size = new System.Drawing.Size(802, 434);
            this.splitContainer1.SplitterDistance = 41;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelInfo, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(802, 41);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(644, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "停止";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(484, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.BackColor = System.Drawing.Color.Red;
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(3, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(475, 41);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainSplit
            // 
            this.MainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplit.Location = new System.Drawing.Point(0, 0);
            this.MainSplit.Name = "MainSplit";
            // 
            // MainSplit.Panel1
            // 
            this.MainSplit.Panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.MainSplit.Panel1.Controls.Add(this.LayoutPanel2);
            // 
            // MainSplit.Panel2
            // 
            this.MainSplit.Panel2.BackColor = System.Drawing.Color.LightCyan;
            this.MainSplit.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainSplit.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Onpaint);
            this.MainSplit.Size = new System.Drawing.Size(802, 389);
            this.MainSplit.SplitterDistance = 175;
            this.MainSplit.TabIndex = 0;
            // 
            // LayoutPanel2
            // 
            this.LayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.LayoutPanel2.ColumnCount = 1;
            this.LayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.LayoutPanel2.Name = "LayoutPanel2";
            this.LayoutPanel2.RowCount = 8;
            this.LayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.LayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.LayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.LayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.LayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.LayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.LayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.LayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.LayoutPanel2.Size = new System.Drawing.Size(175, 389);
            this.LayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.63157F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.15113F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.22803F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.999804F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.989468F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(802, 132);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(321, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 66);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(321, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 66);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(136, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 66);
            this.label3.TabIndex = 2;
            // 
            // UpDownSliptContainer
            // 
            this.UpDownSliptContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpDownSliptContainer.Location = new System.Drawing.Point(0, 0);
            this.UpDownSliptContainer.Name = "UpDownSliptContainer";
            this.UpDownSliptContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // UpDownSliptContainer.Panel1
            // 
            this.UpDownSliptContainer.Panel1.BackColor = System.Drawing.Color.MistyRose;
            this.UpDownSliptContainer.Panel1.BackgroundImage = global::AnnualLottery.Properties.Resources.banner;
            this.UpDownSliptContainer.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpDownSliptContainer.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // UpDownSliptContainer.Panel2
            // 
            this.UpDownSliptContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.UpDownSliptContainer.Panel2.Controls.Add(this.splitContainer1);
            this.UpDownSliptContainer.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.UpDownSliptContainer_Panel2_Paint);
            this.UpDownSliptContainer.Size = new System.Drawing.Size(802, 570);
            this.UpDownSliptContainer.SplitterDistance = 132;
            this.UpDownSliptContainer.TabIndex = 0;
            // 
            // SecondLevel
            // 
            this.SecondLevel.Appearance = System.Windows.Forms.Appearance.Button;
            this.SecondLevel.AutoSize = true;
            this.SecondLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(27)))), ((int)(((byte)(0)))));
            this.SecondLevel.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SecondLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondLevel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondLevel.Location = new System.Drawing.Point(147, 4);
            this.SecondLevel.Name = "SecondLevel";
            this.SecondLevel.Size = new System.Drawing.Size(115, 56);
            this.SecondLevel.TabIndex = 1;
            this.SecondLevel.Text = "二等奖";
            this.SecondLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SecondLevel.UseVisualStyleBackColor = false;
            this.SecondLevel.CheckedChanged += new System.EventHandler(this.Level_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(802, 570);
            this.Controls.Add(this.UpDownSliptContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "祝大家好运！！！";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.MainSplit.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).EndInit();
            this.MainSplit.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.UpDownSliptContainer.Panel1.ResumeLayout(false);
            this.UpDownSliptContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UpDownSliptContainer)).EndInit();
            this.UpDownSliptContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton ZeroLevel;
        private System.Windows.Forms.RadioButton FirstLevel;
        private System.Windows.Forms.RadioButton SecondLevel;
        private System.Windows.Forms.RadioButton ThirdLevel;
        private System.Windows.Forms.RadioButton ForthLevel;
        private System.Windows.Forms.RadioButton FifthLevel;
        private System.Windows.Forms.RadioButton SixthLevel;
        private System.Windows.Forms.RadioButton SeventhLevel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.SplitContainer MainSplit;
        private System.Windows.Forms.TableLayoutPanel LayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer UpDownSliptContainer;
    }
}

