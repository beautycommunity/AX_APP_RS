using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AX_APP_RS
{
    public partial class frmQTY : Form
    {
        TextBox _txt = new TextBox();

        public frmQTY(ref TextBox _txtQty )
        {
            InitializeComponent();

            _txt = _txtQty;
        }

        private void txtQTY_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:

                   if(txtQTY.Text == "")
                    {
                        _txt.Text = "0";
                    }
                    else
                    {
                        _txt.Text = txtQTY.Text;
                    }

                    this.Close();

                    break;
            }

        }

        private void frmQTY_Load(object sender, EventArgs e)
        {
            txtQTY.Text = _txt.Text;
        }
    }
}
