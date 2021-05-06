using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace KTHare
{
    public partial class Register : Form
    {
        private bool correctInput;
        public Register()
        {
            InitializeComponent();
            btn_register.Enabled = false;
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
        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void tb_mail_TextChanged(object sender, EventArgs e)
        {
            string inputEmail;
            correctInput = false;
            while (correctInput != true)
            {
                inputEmail = tb_mail.Text;
                correctInput = emailControl(inputEmail);
                btn_register.Enabled = false;
                break;
            }
            while (true)
            {
                if (correctInput == true )
                {
                    errorProvider1.Clear();
                    if (!string.IsNullOrEmpty(tb_password.Text) && !string.IsNullOrEmpty(tb_name.Text))
                    {
                        btn_register.Enabled = true;
                        break;
                    }
                    break;
                }
                else if (string.IsNullOrEmpty(tb_mail.Text))
                {
                    errorProvider1.SetError(this.tb_mail, "Enter your KTH email");
                    break;
                }
                else
                {
                    errorProvider1.SetError(this.tb_mail, "You are not KTH:are, please try again");
                    break;
                }
            }
        }
        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            while (correctInput == true)
            {
                if ((string.IsNullOrEmpty(tb_name.Text) || string.IsNullOrEmpty(tb_password.Text)))
                {
                    btn_register.Enabled = false;
                    break;
                }
                else
                {
                    btn_register.Enabled = true;
                    break;
                }
            }
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            while (correctInput == true)
            {
                if (string.IsNullOrEmpty(tb_password.Text) || string.IsNullOrEmpty(tb_name.Text))
                {
                    btn_register.Enabled = false;
                    break;
                }
                else
                {
                    btn_register.Enabled = true;
                    break;
                }
            }
            while (correctInput != true && string.IsNullOrEmpty(tb_name.Text))
            {
                btn_register.Enabled = false;
                break;
            }
        }
        /*
         * ################ Help functions ###########
         */
        /**
         *@return true if the user has a kth-email, false otherwise 
         */
        public bool emailControl(String userMail)
        {
            return Regex.IsMatch(userMail, @"^([\w\.\-]+)@((?i)[kth]+)((\.(\w)(?i)[se])+)$");
        }
    }
}
