namespace AX_APP_RS
{
    partial class frmDocDetail
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctm_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctm_cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.ctm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(1178, 671);
            // 
            // tabPage2
            // 
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1170, 639);
            // 
            // lsvReport
            // 
            this.lsvReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lsvReport.FullRowSelect = true;
            this.lsvReport.Location = new System.Drawing.Point(4, 5);
            this.lsvReport.Size = new System.Drawing.Size(1162, 629);
            this.lsvReport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsvReport_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "เอกสาร";
            this.columnHeader1.Width = 137;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "วันที่";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ลำดับ";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "รหัสสินค้า";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ชื่อสินค้า";
            this.columnHeader5.Width = 350;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ปริมาณ";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 70;
            // 
            // ctm
            // 
            this.ctm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctm_edit,
            this.ctm_cancel});
            this.ctm.Name = "ctm";
            this.ctm.Size = new System.Drawing.Size(160, 52);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ราคา/หน่วย";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "มูลค่า";
            this.columnHeader8.Width = 100;
            // 
            // ctm_edit
            // 
            this.ctm_edit.Name = "ctm_edit";
            this.ctm_edit.Size = new System.Drawing.Size(175, 24);
            this.ctm_edit.Text = "แก้ไขจำนวน";
            this.ctm_edit.Click += new System.EventHandler(this.ctm_edit_Click);
            // 
            // ctm_cancel
            // 
            this.ctm_cancel.Name = "ctm_cancel";
            this.ctm_cancel.Size = new System.Drawing.Size(175, 24);
            this.ctm_cancel.Text = "ยกเลิกรายการ";
            this.ctm_cancel.Click += new System.EventHandler(this.ctm_cancel_Click);
            // 
            // frmDocDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 710);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "frmDocDetail";
            this.Text = "รายละเอียด";
            this.Load += new System.EventHandler(this.frmDocDetail_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ctm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ContextMenuStrip ctm;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ToolStripMenuItem ctm_edit;
        private System.Windows.Forms.ToolStripMenuItem ctm_cancel;
    }
}