using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using k.libary;
using System.Data.SqlClient;

namespace AX_APP_RS
{
    public partial class frmMain : frmSub
    {

        public string strconn;
        public string brand;
        public TextBox txtBL = new TextBox();
        public TextBox txtSQL = new TextBox();
        public DataSet ds ;

       public frmMain()
        {
            InitializeComponent();
            strconn = "Data Source=192.168.1.220;Initial Catalog=cmd-bx;User ID=sa;password=0211";
            brand = "BB";
        }

        public frmMain(string _strconn,string _brand)
        {
            InitializeComponent();

            strconn = _strconn;
            brand = _brand;
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsBtnCondi_Click(object sender, EventArgs e)
        {
            frmDocnoCond frm = new frmDocnoCond(strconn, brand, ref txtSQL, ref txtBL);
            frm.ShowDialog();
            ds.Clear();
            setLsv();
        }

        private void setLsv()
        {
           

            if(txtBL.Text == "true")
            {
                pb.Visible = true;
                bgw.RunWorkerAsync();

            }

           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ds = new DataSet();

            bgw.WorkerReportsProgress = true;
            CheckForIllegalCrossThreadCalls = false;
        }

        private void tsBtnApp_Click(object sender, EventArgs e)
        {
            if (lv.Items.Count > 0)
            {
                string user = "";
                TextBox _txt = new TextBox();

                frmUser frm = new frmUser(strconn,ref _txt);
                frm.ShowDialog();

                if (_txt.Text == "")
                {

                }
                else
                {

                    AppDoc(_txt.Text);
                    setLsv();


                }
            }
            
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            ds = cData.getDataSetWithSqlCommand(strconn, txtSQL.Text, 1000000, true);

        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lv.Items.Clear();

            ListViewItem lvitem = new ListViewItem();

            for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                lvitem = lv.Items.Add(ds.Tables[0].Rows[i]["rw"].ToString());
                int idx = lv.Items.IndexOf(lvitem);
                lv.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["whcode"].ToString());
                lv.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["whname"].ToString());
                lv.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["docno"].ToString());
                lv.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["docdate"].ToString());
                lv.Items[idx].SubItems.Add(decimal.Parse(ds.Tables[0].Rows[i]["QTY"].ToString()).ToString("#,##0"));
                lv.Items[idx].SubItems.Add(decimal.Parse(ds.Tables[0].Rows[i]["AMT"].ToString()).ToString("#,##0.00"));
                lv.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["appcode"].ToString());
                lv.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["docflag"].ToString());
                lv.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["docremark"].ToString());
            }

            klv.Items.Clear();

            ListViewItem kitem = new ListViewItem();

            for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                kitem = klv.Items.Add(ds.Tables[0].Rows[i]["rw"].ToString());
                int idx = klv.Items.IndexOf(kitem);
                klv.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["whcode"].ToString());
                klv.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["whname"].ToString());
                klv.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["docno"].ToString());
                klv.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["docdate"].ToString());
                klv.Items[idx].SubItems.Add(decimal.Parse(ds.Tables[0].Rows[i]["QTY"].ToString()).ToString("#,##0"));
                klv.Items[idx].SubItems.Add(decimal.Parse(ds.Tables[0].Rows[i]["AMT"].ToString()).ToString("#,##0.00"));
                klv.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["appcode"].ToString());
                klv.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["docflag"].ToString());
                klv.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["docremark"].ToString());
            }

            pb.Visible = false;

            MessageBox.Show("สำเร็จ");
        }

        private void AppDoc(string _usercode)
        {
            
            
            if (lv.Items.Count > 0)
            {
                for (int i = 0; i <= lv.Items.Count - 1; i++)
                {
                    if(lv.Items[i].Checked==true)
                    {
                        saveDoc(lv.Items[i].SubItems[3].Text, _usercode);
                    }
                }
            }
        }

        private void saveDoc(string _docno,string _usercode )
        {
            SqlCommand comm = new SqlCommand();
            SqlConnection srConn = new SqlConnection(strconn);

           
            string inSql = "";
            string svr = "";

            if (brand.ToLower() == "bb")
            {
                svr = "[BEAUTYAX.DYNDNS.INFO].[interfaceBBPrd].dbo.";
            }
            else
            {
                svr = "[192.168.10.199].[interfaceBBPrd].dbo.";
            }

            inSql = " insert " + svr + "INVENTORDER_APP " +
                    " select a.DOCNO,a.DOCDATE,'1' Docflag,'' Docremark,ROW_NUMBER() over(order by a.docno) roworder,a.MPCODE,'1' mpflag,'' mpremark,getdate(),'" + _usercode + "' appcode " +
                    " from " + svr + "INVENTORDER a " +
                    " left join " + svr + "INVENTORDER_APP b on a.DOCNO = b.docno " +
                    " where a.DOCNO = '" + _docno + "' and b.docno is null";

            if(srConn.State == ConnectionState.Closed)
            {
                srConn.Open();
            }

            comm.CommandText = inSql;
            comm.Connection = srConn;
            comm.CommandTimeout = 1000000;

            comm.ExecuteNonQuery();


        }


        private void lv_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                         ctm.Show(Cursor.Position);
                    }
                    break;
            }
        }

        private void ctmDetail_Click(object sender, EventArgs e)
        {
            frmDocDetail frm = new frmDocDetail(strconn, brand, lv.SelectedItems[0].SubItems[3].Text);
            frm.ShowDialog();
        }

        private void tsBtnPrint_Click(object sender, EventArgs e)
        {
           
            frmPrint frm = new frmPrint(ref klv,"ใบสั่งสินค้ารอบพิเศษ",false,false);
            frm.ShowDialog();
        }

        private void csm_CSV_Click(object sender, EventArgs e)
        {
            cExport.ExportListView(ref lv, true, "");
        }

        private void scm_Excel_Click(object sender, EventArgs e)
        {
            cExport.ExportListViewToExcel(ref lv);
        }
    }
}
