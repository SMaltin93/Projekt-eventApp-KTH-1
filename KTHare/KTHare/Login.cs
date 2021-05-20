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
        Register check = new Register(); 
        public Login()
        {
            InitializeComponent();
            btn_login.Enabled = false;
        }

        /*
         * Check if the user is registerd and show an appropriate message
         */ 
        private void btn_login_Click(object sender, EventArgs e)
        {        
            Database db = new Database();

            string mail = tb_mail.Text;
            string password = tb_password.Text;

            var sql = "SELECT id,mail,name,AES_DECRYPT(password, '" + KTHare.Properties.Settings.Default.HashPassword + "') AS 'password' FROM login_table WHERE mail='" + mail + "'";
            using var cmd = new MySqlCommand(sql, db.con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                if (rdr.GetString("password") == password)
                {
                    User.id = rdr.GetInt32("id");
                    User.mail = rdr.GetString("mail");
                    User.name = rdr.GetString("name");

                    var form = new EventsMenu();
                    this.Hide();
                    form.Show();
                } else
                {
                    MessageBox.Show("Fel lösenord!");
                }

            } else
            {
                MessageBox.Show("Konto hittades inte. Försök igen!");
            }

        }

        private void linklbl_createaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new Register();
            this.Hide();
            form.Show();
        }
        /*
         * Show the password by clicking on show button 
         */
        private void cb_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showPassword.Checked == true)
            {
                tb_password.UseSystemPasswordChar = false;
            } else
            {
                tb_password.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Database db = new Database(); //Check if the database is available.
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        /*
         * Unable the login button if the email is an KTH-email, disable otherwise
         */
        private void tb_mail_TextChanged(object sender, EventArgs e)
        {
            while ( true)
            {
                if (check.emailControl(tb_mail.Text) == true)
                {
                    errorProvider1.Clear();
                    btn_login.Enabled = true;
                    break;
                }
                errorProvider1.SetError(this.tb_mail, "Skriv in din KTH-mail");
                btn_login.Enabled = false;
                break;
            }
        }
    }
}
