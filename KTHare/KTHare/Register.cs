using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        private void btn_register_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            string name = tb_name.Text;
            string mail = tb_mail.Text;
            string password = tb_password.Text;

            var sql = "INSERT INTO login_table(id, name, mail, password) VALUES(NULL, @name, @mail, @password)";
            using var cmd = new MySqlCommand(sql, db.con);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            MessageBox.Show("Konto " + name + " skapades!");

            var form = new Login();
            this.Hide();
            form.Show();
        }

        private void cb_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showPassword.Checked == true)
            {
                tb_password.UseSystemPasswordChar = false;
            }
            else
            {
                tb_password.UseSystemPasswordChar = true;
            }
        }
    }
}
