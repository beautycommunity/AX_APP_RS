using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using k.libary;
using System.Data.SqlClient;

namespace AX_APP_RS
{
    public partial class frmDocDetail : frmReport
    {
        public string strconn;
        public string docno;
        public string brand;
        public string svr;

        public DataSet ds;

        public frmDocDetail()
        {
            InitializeComponent();

            strconn = "Data Source=192.168.1.220;Initial Catalog=cmd-bx;User ID=sa;password=0211";
            brand = "BB";
            docno = "1209-RS18020601'";
        }

        public frmDocDetail(string _strconn ,string _brand,string _docno)
        {
            InitializeComponent();

            strconn = _strconn;
            brand = _brand;
            docno = _docno;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void frmDocDetail_Load(object sender, EventArgs e)
        {
            //conn.ConnectionString = strconn;

            btnCondition.Visible = false;
            btnDelete.Visible = false;
            btnEdit.Visible = false;
            btnImportCSV.Visible = false;
            btnImportData.Visible = false;
            btnImportTextTab.Visible = false;
            btnNewData.Visible = false;
            btnSubmit.Visible = false;
            btnRefreshDataAll.Visible = false;
            btnRefreshDataClose.Visible = false;
            btnRefreshDataOpen.Visible = false;
            btnSaveData.Visible = false;
            btnSubmit.Visible = false;
            btnSyncData.Visible = false;
            toolStripButton1.Visible = false;
            toolStripSeparator2.Visible = false;
            toolStripSeparator4.Visible = false;
            btnAddData.Visible = false;
            btnSearch.Visible = false;
            btnRefreshData.Visible = false;

            if (brand.ToLower() == "bb")
            {
                svr = "[BEAUTYAX.DYNDNS.INFO].[interfaceBBPrd].dbo.";
            }
            else
            {
                svr = "[192.168.10.199].[interfaceBBPrd].dbo.";
            }


            //AddHandler lsvReport.MouseClick, AddressOf Me.lsvReport_MouseClick;


            load_list();
        }

        private void ctm_edit_Click(object sender, EventArgs e)
        {
            TextBox _txtqty = new TextBox();
            _txtqty.Text = lsvReport.SelectedItems[0].SubItems[5].Text;

            frmQTY frm = new frmQTY(ref _txtqty);
            frm.ShowDialog();

            edit_list(lsvReport.SelectedItems[0].SubItems[0].Text, lsvReport.SelectedItems[0].SubItems[3].Text, Decimal.Parse(lsvReport.SelectedItems[0].SubItems[6].Text), int.Parse(Decimal.Parse(_txtqty.Text).ToString("#,##0")));
        }

        private void ctm_cancel_Click(object sender, EventArgs e)
        {
            edit_list(lsvReport.SelectedItems[0].SubItems[0].Text, lsvReport.SelectedItems[0].SubItems[3].Text, Decimal.Parse( lsvReport.SelectedItems[0].SubItems[6].Text), 0);
        }

        private void load_list()
        {
            try
            {
                string sql = "";

                sql = " select  a.docno,convert(varchar(10),a.docdate,103) docdate,ROW_NUMBER() over(order by a.docno) as rw," +
                    " a.mpcode,a.mpname,FORMAT(a.QTY,'#,##0')as QTY ,FORMAT(a.PRICE,'#,##0.00') as PRICE,FORMAT(a.AMT ,'#,##0.00') as AMT  ,isnull(b.DOCFLAG,0) as Docflag " +
                    " from " + svr + "INVENTORDER a " +
                    " left join " + svr + "INVENTORDER_APP b on a.docno = b.DOCNO and a.MPCODE = b.MPCODE  " + 
                    " where a.docno = '" + docno +"'";

                ds = cData.getDataSetWithSqlCommand(strconn, sql, 1000000, true);


                lsvReport.addDataWithDataset(ds, false, true,false,5);


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void edit_list(string _docno,string _mpcode,decimal _price,int _QTY)
        {
            try
            {
                string sql = "";

                SqlCommand comm = new SqlCommand();
                SqlConnection conn = new SqlConnection(strconn);


                if(chkApp(_docno) == false)
                {
                    sql = "update " + svr + "INVENTORDER " +
                        " set QTY = " + _QTY +"," +
                        " AMT = " + _QTY * _price +
                        " where docno ='" + _docno + "' and mpcode = '" + _mpcode + "'";
                    comm.CommandText = sql;
                    comm.CommandTimeout = 1000000;
                    comm.Connection = conn;

                    if(conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    comm.ExecuteNonQuery();

                    load_list();
                }
                else
                {
                    MessageBox.Show("ไม่สามารถแก้ไขเอกสารที่ได้รับการอนุมัติแล้ว");
                }

               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool chkApp(string _docno)
        {
            bool bl = false;

            try
            {
                if(ds.Tables[0].Rows[0]["DOCFLAG"].ToString() == "1" )
                {
                    bl = true;
                }
                else
                {
                    bl = false;
                }
  
            }
            catch
            {
                bl = true;
            }

            return bl;
        }

        private void lsvReport_MouseClick(object sender, MouseEventArgs e)
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
    }
}
