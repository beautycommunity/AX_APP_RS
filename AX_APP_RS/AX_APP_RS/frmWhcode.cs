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
    public partial class frmWhcode : frmReportCondition
    {
        public string strconn;
        public string brand;
        public TextBox txtWhname = new TextBox();
        public TextBox txtWhcode = new TextBox();
        public TextBox txtBL = new TextBox();

        public frmWhcode()
        {
            InitializeComponent();

            strconn = "Data Source=192.168.1.220;Initial Catalog=cmd-bx;User ID=sa;password=0211";
            brand = "BB";
            txtWhcode.Text = "";
            txtWhname.Text = "";
            txtBL.Text = "false";
        }

        public frmWhcode(string _strconn,string _brand,ref TextBox _txtWhcode ,ref TextBox _txtWhname,ref TextBox _txtBL)
        {
            InitializeComponent();

            strconn = _strconn;
            brand = _brand;
            txtWhcode = _txtWhcode;
            txtWhname = _txtWhname;
            txtBL = _txtBL;
        }

        protected override void OnLoad(EventArgs e)
        {
            //base.OnLoad(e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            WhcodeSearch();
        }

        public override void btnSubmit_Click(object sender, EventArgs e)
        {
            //base.btnSubmit_Click(sender, e);
            WhcodeSend();

            if(txtBL.Text == "true")
            {
                this.Close();
            }
        }

        private void WhcodeSearch()
        {
            string sql = " select row_number() over(order by whcode) as rw, whcode ,abbname whname from [cmd-bx]..mas_wh ";

            if (brand.ToLower() == "bb")
            {
                sql = sql + " where (whcode like '1%' or whcode like '3%' ) and addr_row2 = 0 and ( whcode like '%"+ txtSearch.Text + "%' or abbname like '%" + txtSearch.Text + "%') ";
            }
            else if (brand.ToLower() == "bc")
            {
                sql = sql + " where whcode like '5%' and addr_row2 = 0 and ( whcode like '%" + txtSearch.Text + "%' or abbname like '%" + txtSearch.Text + "%') ";
            }
            else
            {
                sql = sql + " where whcode like '7%' and addr_row2 = 0 and ( whcode like '%" + txtSearch.Text + "%' or abbname like '%" + txtSearch.Text + "%') ";
            }

            DataSet ds = new DataSet();

            ds = cData.getDataSetWithSqlCommand(strconn, sql, 100000, true);

            lsvWhcode.Items.Clear();

            ListViewItem lvitem = new ListViewItem();

            for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                lvitem = lsvWhcode.Items.Add(ds.Tables[0].Rows[i]["rw"].ToString());
                int idx = lsvWhcode.Items.IndexOf(lvitem);
                lsvWhcode.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["whcode"].ToString());
                lsvWhcode.Items[idx].SubItems.Add(ds.Tables[0].Rows[i]["whname"].ToString());
                
            }


        }

        private void WhcodeSend()
        {
            txtBL.Text = "false";
            string Whcode = "";
            string Whname = "";
            try
            {
                if (lsvWhcode.Items.Count > 0)
                {
                    for (int i = 0; i <= lsvWhcode.Items.Count - 1; i++)
                    {
                        if (lsvWhcode.Items[i].Checked == true)
                        {
                            if (Whcode == "")
                            {
                                Whcode = lsvWhcode.Items[i].SubItems[1].Text;
                                Whname = lsvWhcode.Items[i].SubItems[2].Text;
                            }
                            else
                            {
                                Whcode = Whcode + "," + lsvWhcode.Items[i].SubItems[1].Text;
                                Whname = Whname + "," + lsvWhcode.Items[i].SubItems[2].Text;
                            }
                        }
                    }

                    txtBL.Text = "true";
                    txtWhcode.Text = Whcode;
                    txtWhname.Text = Whname;


                }
            }
            catch
            {
                txtBL.Text = "false";
            }
        }
    }
}
