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

namespace AX_APP_RS
{
    public partial class frmDocnoCond : frmReportCondition
    {
        public string strconn;
        public string brand;
        public TextBox txtWhname = new TextBox();
        public TextBox txtWhcode = new TextBox();
        public TextBox txtBL = new TextBox();
        public TextBox txtBLR = new TextBox();
        public TextBox txtSQL = new TextBox();


        public frmDocnoCond()
        {
            InitializeComponent();

            strconn = "Data Source=192.168.1.220;Initial Catalog=cmd-bx;User ID=sa;password=0211";
            brand = "BB";
            txtSQL.Text = "";
            txtBLR.Text = "false";
        }

        public frmDocnoCond(string _strconn, string _brand, ref TextBox _txtSQL,  ref TextBox _txtBLR)
        {
            InitializeComponent();

            strconn = _strconn;
            brand = _brand;
            txtSQL = _txtSQL;
            txtBLR = _txtBLR;
        }

        protected override void OnLoad(EventArgs e)
        {
            //base.OnLoad(e);
        }

        private void btnAddWhcode_Click(object sender, EventArgs e)
        {
            setlsv();
        }

        private void frmDocnoCond_Load(object sender, EventArgs e)
        {
            lsvWhcode.Items.Clear();
            txtBLR.Text = "false";
        }

        public override void btnSubmit_Click(object sender, EventArgs e)
        {
            //base.btnSubmit_Click(sender, e);

            try
            {
                setSql();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setlsv()
        {
            try
            {
                frmWhcode frm = new frmWhcode(strconn, brand, ref txtWhcode, ref txtWhname, ref txtBL);
                frm.ShowDialog();

                if (txtBL.Text == "true")
                {
                    string[] Awhcode;
                    string[] Awhname;

                    Awhcode = txtWhcode.Text.Split(',');
                    Awhname = txtWhname.Text.Split(',');

                    ListViewItem lvitem = new ListViewItem();

                    for (int i = 0; i <= Awhcode.Length - 1; i++)
                    {
                        lvitem = lsvWhcode.Items.Add((i + 1).ToString());
                        int idx = lsvWhcode.Items.IndexOf(lvitem);
                        lsvWhcode.Items[idx].SubItems.Add(Awhcode[i]);
                        lsvWhcode.Items[idx].SubItems.Add(Awhname[i]);
                    }

                  

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด\n" + ex.Message);
            }
        }

        private void setSql()
        {
            string sql="";
            string chk ="";
            string whcode="";
            string svr = "";

            //frmWhcode frm = new frmWhcode(strconn,brand,ref txtWhcode,ref txtWhname,ref txtBL);
            //frm.ShowDialog();


            if (chkNonApproved.Checked == true)
                {
                    chk = " and  isnull(b.DOCFLAG,0) = 0 ";
                }
                else
                {
                    chk = "";
                }
                
                if(lsvWhcode.Items.Count> 0 )
                {
                    for(int i =0;i<= lsvWhcode.Items.Count-1; i++)
                    {
                        if(i==0)
                        {
                            whcode = lsvWhcode.Items[i].SubItems[1].Text;
                        }
                        else
                        {
                            whcode = whcode + "," + lsvWhcode.Items[i].SubItems[1].Text;
                        }
                    }

                    whcode = " and a.whcode in (" + whcode + ") ";
                }
                else
                {
                    whcode = "";
                }

           

                if(brand.ToLower() == "bb")
                {
                    svr = "[BEAUTYAX.DYNDNS.INFO].[interfaceBBPrd].dbo.";
                                  
                }
                else
                {
                    svr = "[192.168.10.199].[interfaceBBPrd].dbo.";
                }

                sql = "select ROW_NUMBER() over(order by a.whname)as rw ,a.whcode,a.WHNAME,a.DOCNO,convert(varchar(10),a.DOCDATE,103) docdate,sum(a.QTY) qty,sum(a.AMT) amt, isnull(b.APPCODE,'') as appcode , " +
                    " case when isnull(b.DOCFLAG,0) = 1 then 'อนุมัติเรียบร้อยแล้ว'  else  '***ยังไม่อนุมัติเอกสาร***' end as docflag, " +
                    " isnull(b.docremark, '') as docremark " +
                    " from " + svr + "INVENTORDER a " +
                    " left join " + svr + "INVENTORDER_APP b on a.DOCNO = b.docno " +
                    " where a.DOCNO is not null " + whcode + chk +
                    " and a.docdate between '" + dtpSdate.getDateOnlyForSql() + "' and  '" + dtpFdate.getDateOnlyForSql() + "' " +
                    " group by a.whcode,a.WHNAME,a.DOCNO,a.DOCDATE,b.APPCODE,b.DOCFLAG,b.docremark";

                txtSQL.Text = sql;
                txtBLR.Text = "true";

                this.Close();
            


        }
    }
}
