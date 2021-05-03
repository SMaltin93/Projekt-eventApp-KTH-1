using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KTHare
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            string mail = tb_mail.Text;
            string password = tb_password.Text;

            using var con = new MySqlConnection(db.cs);
            con.Open();

            var sql = "SELECT * FROM login_table WHERE mail='"+mail+"'";
            using var cmd = new MySqlCommand(sql, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                if (rdr.GetString("password") == password)
                {
                    MessageBox.Show("Welcome " + rdr.GetString("name") + "!");
                    
                    User.mail = rdr.GetString("mail");
                    User.name = rdr.GetString("name");

                    var form = new EventsMenu();
                    this.Hide();
                    form.Show();
                } else
                {
                    MessageBox.Show("Wrong password!");
                }

            } else
            {
                MessageBox.Show("Account not found. Try again!");
            }

        }

        private void linklbl_createaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new Register();
            this.Hide();
            form.Show();
        }
    }
}
