using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KTHare
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void linklbl_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new Login();
            this.Hide();
            form.Show();
        }
    }
}
