namespace AX_APP_RS
{
    partial class frmDocnoCond
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpSdate = new k.libary.kDateTimePicker(this.components);
            this.dtpFdate = new k.libary.kDateTimePicker(this.components);
            this.chkNonApproved = new System.Windows.Forms.CheckBox();
            this.btnAddWhcode = new System.Windows.Forms.Button();
            this.btnDelWhcode = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lsvWhcode = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(456, 401);
            this.tabControl1.TabIndex = 192;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkNonApproved);
            this.tabPage1.Controls.Add(this.dtpFdate);
            this.tabPage1.Controls.Add(this.dtpSdate);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(448, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "วันที่";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lsvWhcode);
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.btnDelWhcode);
            this.tabPage2.Controls.Add(this.btnAddWhcode);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(448, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "สาขา";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "วันที่";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "ถึง วันที่";
            // 
            // dtpSdate
            // 
            this.dtpSdate.DisplayThai = true;
            this.dtpSdate.Location = new System.Drawing.Point(87, 30);
            this.dtpSdate.Name = "dtpSdate";
            this.dtpSdate.Size = new System.Drawing.Size(200, 27);
            this.dtpSdate.TabIndex = 2;
            // 
            // dtpFdate
            // 
            this.dtpFdate.DisplayThai = true;
            this.dtpFdate.Location = new System.Drawing.Point(87, 78);
            this.dtpFdate.Name = "dtpFdate";
            this.dtpFdate.Size = new System.Drawing.Size(200, 27);
            this.dtpFdate.TabIndex = 3;
            // 
            // chkNonApproved
            // 
            this.chkNonApproved.AutoSize = true;
            this.chkNonApproved.Location = new System.Drawing.Point(87, 163);
            this.chkNonApproved.Name = "chkNonApproved";
            this.chkNonApproved.Size = new System.Drawing.Size(193, 25);
            this.chkNonApproved.TabIndex = 4;
            this.chkNonApproved.Text = "เฉพาะที่ยังไม่ยืนยัน***";
            this.chkNonApproved.UseVisualStyleBackColor = true;
            // 
            // btnAddWhcode
            // 
            this.btnAddWhcode.Location = new System.Drawing.Point(337, 7);
            this.btnAddWhcode.Name = "btnAddWhcode";
            this.btnAddWhcode.Size = new System.Drawing.Size(28, 31);
            this.btnAddWhcode.TabIndex = 0;
            this.btnAddWhcode.Text = "+";
            this.btnAddWhcode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddWhcode.UseVisualStyleBackColor = true;
            this.btnAddWhcode.Click += new System.EventHandler(this.btnAddWhcode_Click);
            // 
            // btnDelWhcode
            // 
            this.btnDelWhcode.Location = new System.Drawing.Point(371, 7);
            this.btnDelWhcode.Name = "btnDelWhcode";
            this.btnDelWhcode.Size = new System.Drawing.Size(28, 31);
            this.btnDelWhcode.TabIndex = 1;
            this.btnDelWhcode.Text = "-";
            this.btnDelWhcode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelWhcode.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(405, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(35, 31);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "--";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lsvWhcode
            // 
            this.lsvWhcode.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvWhcode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvWhcode.FullRowSelect = true;
            this.lsvWhcode.GridLines = true;
            this.lsvWhcode.Location = new System.Drawing.Point(3, 44);
            this.lsvWhcode.Name = "lsvWhcode";
            this.lsvWhcode.Size = new System.Drawing.Size(442, 322);
            this.lsvWhcode.TabIndex = 3;
            this.lsvWhcode.UseCompatibleStateImageBehavior = false;
            this.lsvWhcode.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ลำดับ";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "รหัสสาขา";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "สาขา";
            this.columnHeader3.Width = 174;
            // 
            // frmDocnoCond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 440);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "frmDocnoCond";
            this.Load += new System.EventHandler(this.frmDocnoCond_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkNonApproved;
        private k.libary.kDateTimePicker dtpFdate;
        private k.libary.kDateTimePicker dtpSdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvWhcode;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelWhcode;
        private System.Windows.Forms.Button btnAddWhcode;
    }
}