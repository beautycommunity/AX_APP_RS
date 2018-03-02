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
    public partial class frmUser : Form
    {
        public TextBox _txt = new TextBox();

        public string strconn;
        

        public frmUser(string _strconn,ref TextBox _txtUSER)
        {
            InitializeComponent();

            _txt = _txtUSER;
            strconn = _strconn;
        }

        private void txtUSER_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:

                    txtPass.Focus();

                    //if (txtUSER.Text != "")
                    //{
                    //    _txt.Text = txtUSER.Text;
                    //    this.Close();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("กรุณากรอกรหัสพนักงาน");
                    //}

                    break;
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:

                    if (txtUSER.Text != "" && txtPass.Text != "")
                    {
                        DataSet ds;

                        SqlConnection conn = new SqlConnection(strconn);
                        SqlCommand comm = new SqlCommand();

                        string sql = "SELECT  count(*) FROM MAS_US WHERE LOGONNAME = '"+ txtUSER.Text + "' and PASSWORD = '"+ txtPass.Text  + "'";

                        if(conn.State== ConnectionState.Closed)
                        {
                            conn.Open();
                        }

                        comm.Connection = conn;
                        comm.CommandTimeout= 1000000;
                        comm.CommandText = sql;

                        int cnt = 0;

                        cnt = int.Parse(Decimal.Parse( comm.ExecuteScalar().ToString()).ToString("#,##0"));

                        if (cnt> 0 )
                        {
                            _txt.Text = txtUSER.Text;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("รหัสพนักงานและรหัสผ่านผิดพลาด");

                            txtUSER.Focus();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("กรุณากรอกรหัสพนักงาน");
                    }

                    break;
            }
        }
    }
}
