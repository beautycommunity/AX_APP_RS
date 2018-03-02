namespace AX_APP_RS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ts = new System.Windows.Forms.ToolStrip();
            this.tsBtnApp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnCondi = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDoc = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnPrint = new System.Windows.Forms.ToolStripButton();
            this.tsBtnExport = new System.Windows.Forms.ToolStripDropDownButton();
            this.csm_CSV = new System.Windows.Forms.ToolStripMenuItem();
            this.scm_Excel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnClose = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pb = new System.Windows.Forms.PictureBox();
            this.lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.ctm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.klv = new k.libary.kListView(this.components);
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ts.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.ctm.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts
            // 
            this.ts.AutoSize = false;
            this.ts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnApp,
            this.toolStripSeparator1,
            this.tsBtnCondi,
            this.tsBtnDoc,
            this.toolStripButton4,
            this.tsBtnPrint,
            this.tsBtnExport,
            this.toolStripButton7,
            this.tsBtnClose});
            this.ts.Location = new System.Drawing.Point(0, 0);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(1140, 54);
            this.ts.TabIndex = 0;
            // 
            // tsBtnApp
            // 
            this.tsBtnApp.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnApp.Image")));
            this.tsBtnApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnApp.Name = "tsBtnApp";
            this.tsBtnApp.Size = new System.Drawing.Size(121, 51);
            this.tsBtnApp.Text = "อนุมัติเอกสาร";
            this.tsBtnApp.Click += new System.EventHandler(this.tsBtnApp_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // tsBtnCondi
            // 
            this.tsBtnCondi.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnCondi.Image")));
            this.tsBtnCondi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnCondi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCondi.Name = "tsBtnCondi";
            this.tsBtnCondi.Size = new System.Drawing.Size(85, 51);
            this.tsBtnCondi.Text = "เงือนไข";
            this.tsBtnCondi.Click += new System.EventHandler(this.tsBtnCondi_Click);
            // 
            // tsBtnDoc
            // 
            this.tsBtnDoc.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDoc.Image")));
            this.tsBtnDoc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDoc.Name = "tsBtnDoc";
            this.tsBtnDoc.Size = new System.Drawing.Size(102, 51);
            this.tsBtnDoc.Text = "ดึงเอกสาร";
            this.tsBtnDoc.Visible = false;
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(6, 54);
            // 
            // tsBtnPrint
            // 
            this.tsBtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPrint.Image")));
            this.tsBtnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPrint.Name = "tsBtnPrint";
            this.tsBtnPrint.Size = new System.Drawing.Size(73, 51);
            this.tsBtnPrint.Text = "พิมพ์";
            this.tsBtnPrint.Click += new System.EventHandler(this.tsBtnPrint_Click);
            // 
            // tsBtnExport
            // 
            this.tsBtnExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csm_CSV,
            this.scm_Excel});
            this.tsBtnExport.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnExport.Image")));
            this.tsBtnExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnExport.Name = "tsBtnExport";
            this.tsBtnExport.Size = new System.Drawing.Size(127, 51);
            this.tsBtnExport.Text = "ส่งออกข้อมูล";
            // 
            // csm_CSV
            // 
            this.csm_CSV.Name = "csm_CSV";
            this.csm_CSV.Size = new System.Drawing.Size(181, 26);
            this.csm_CSV.Text = "CSV";
            this.csm_CSV.Click += new System.EventHandler(this.csm_CSV_Click);
            // 
            // scm_Excel
            // 
            this.scm_Excel.Name = "scm_Excel";
            this.scm_Excel.Size = new System.Drawing.Size(181, 26);
            this.scm_Excel.Text = "Excel";
            this.scm_Excel.Click += new System.EventHandler(this.scm_Excel_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(6, 54);
            // 
            // tsBtnClose
            // 
            this.tsBtnClose.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnClose.Image")));
            this.tsBtnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnClose.Name = "tsBtnClose";
            this.tsBtnClose.Size = new System.Drawing.Size(110, 51);
            this.tsBtnClose.Text = "ปิดหน้าต่าง";
            this.tsBtnClose.Click += new System.EventHandler(this.tsBtnClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1140, 501);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.klv);
            this.tabPage1.Controls.Add(this.pb);
            this.tabPage1.Controls.Add(this.lv);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1132, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "รายละเอียด";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.White;
            this.pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb.Image = ((System.Drawing.Image)(resources.GetObject("pb.Image")));
            this.pb.Location = new System.Drawing.Point(351, 105);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(304, 231);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb.TabIndex = 190;
            this.pb.TabStop = false;
            this.pb.Visible = false;
            // 
            // lv
            // 
            this.lv.CheckBoxes = true;
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.Location = new System.Drawing.Point(3, 3);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(1126, 463);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ลำดับ";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "รหัสสาขา";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "สาขา";
            this.columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "เอกสาร";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "วันที่";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ปริมาณสั่ง";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "มูลค่าสั่ง";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ผู้อนุมัติ";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "สถานะ";
            this.columnHeader9.Width = 212;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "หมายเหตุ";
            this.columnHeader10.Width = 331;
            // 
            // bgw
            // 
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // ctm
            // 
            this.ctm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmDetail});
            this.ctm.Name = "ctm";
            this.ctm.Size = new System.Drawing.Size(142, 28);
            // 
            // ctmDetail
            // 
            this.ctmDetail.Name = "ctmDetail";
            this.ctmDetail.Size = new System.Drawing.Size(141, 24);
            this.ctmDetail.Text = "รายละเอียด";
            this.ctmDetail.Click += new System.EventHandler(this.ctmDetail_Click);
            // 
            // klv
            // 
            this.klv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20});
            this.klv.Location = new System.Drawing.Point(8, 388);
            this.klv.Name = "klv";
            this.klv.Size = new System.Drawing.Size(1089, 97);
            this.klv.TabIndex = 191;
            this.klv.UseCompatibleStateImageBehavior = false;
            this.klv.View = System.Windows.Forms.View.Details;
            this.klv.Visible = false;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "ลำดับ";
            this.columnHeader11.Width = 50;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "รหัสสาขา";
            this.columnHeader12.Width = 81;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "สาขา";
            this.columnHeader13.Width = 86;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "เอกสาร";
            this.columnHeader14.Width = 150;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "วันที่";
            this.columnHeader15.Width = 100;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "ปริมาณสั่ง";
            this.columnHeader16.Width = 104;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "มูลค่าสั่ง";
            this.columnHeader17.Width = 97;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "ผู้อนุมัติ";
            this.columnHeader18.Width = 100;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "สถานะ";
            this.columnHeader19.Width = 212;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "หมายเหตุ";
            this.columnHeader20.Width = 239;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1140, 555);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ts);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "อนุมัติใบสั่งเอกสารรอบเสริม";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ctm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripButton tsBtnApp;
        private System.Windows.Forms.ToolStripButton tsBtnDoc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnCondi;
        private System.Windows.Forms.ToolStripSeparator toolStripButton4;
        private System.Windows.Forms.ToolStripButton tsBtnPrint;
        private System.Windows.Forms.ToolStripDropDownButton tsBtnExport;
        private System.Windows.Forms.ToolStripSeparator toolStripButton7;
        private System.Windows.Forms.ToolStripButton tsBtnClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        internal System.Windows.Forms.PictureBox pb;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.ContextMenuStrip ctm;
        private System.Windows.Forms.ToolStripMenuItem ctmDetail;
        private System.Windows.Forms.ToolStripMenuItem csm_CSV;
        private System.Windows.Forms.ToolStripMenuItem scm_Excel;
        private k.libary.kListView klv;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
    }
}

