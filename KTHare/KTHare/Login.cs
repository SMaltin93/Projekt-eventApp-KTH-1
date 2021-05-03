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
        string cs = @"server=155.4.6.242;userid=username;password=password;database=kthare"; 

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            /*using var con = new MySqlConnection(cs);
            con.Open();

            var sql = "SELECT * FROM login_table WHERE id=1";

            using var cmd = new MySqlCommand(sql, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                MessageBox.Show(rdr.GetString("mail"));
            }
            else
            {
                MessageBox.Show("No data found");
            }
           */
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string mail = tb_mail.Text;
            string password = tb_password.Text;

            using var con = new MySqlConnection(cs);
            con.Open();

            var sql = "SELECT * FROM login_table WHERE mail='"+ mail+"'";
            using var cmd = new MySqlCommand(sql, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                MessageBox.Show("Welcome");
            }
            else
            {
                MessageBox.Show("Account not found");
            }

        }
    }
}
