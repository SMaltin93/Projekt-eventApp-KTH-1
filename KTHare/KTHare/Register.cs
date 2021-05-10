using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Net.Mail;
namespace KTHare
{

   
    public partial class Register : Form
    {
        public string GetEmail;
        public string GetPassword;
        public string GetName;
        public string GetVerfication;
        public string GetHashedPassword;
        


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
           
            GetEmail = this.tb_mail.Text;
            GetName = this.tb_name.Text;
            GetPassword = this.tb_password.Text;
            
           
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient smto = new SmtpClient("smtp.gmail.com", 587);
                    mail.From = new MailAddress("globala.kthare@gmail.com");
                    mail.To.Add(tb_mail.Text);
                    mail.Subject = "Your password";
                    mail.Body =  "Your verfication code is : " + getGeneratePassword(); ;
                    smto.Credentials = new System.Net.NetworkCredential("globala.kthare@gmail.com", "kthare2021");
                    smto.EnableSsl = true;
                    smto.Send(mail);
                    MessageBox.Show("Your verification code has sent to :\n" + this.tb_mail.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

          //  }

            var form = new CodeVerification(this);
            GetHashedPassword = new Hashing(this).getHashed;
            MessageBox.Show(GetHashedPassword);
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
                    errorProvider1.SetError(this.tb_mail, "Enter your KTH-email");
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
        /**
         *Generate password
         *@return a random password
         */
        public string getGeneratePassword()
        {
            Random rand = new Random();
            string send_rand = "";
            for (int i = 1; i <= 9; i++)
            {
                send_rand += rand.Next(0, 9).ToString();
            }
            GetVerfication = send_rand;
            return send_rand;
        }
      
       
    }


}
