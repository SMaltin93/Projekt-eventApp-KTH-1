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

        /*
         * Save the login details and send a verification code to the user
         * Check if the user is already registed
         */
        private void btn_register_Click(object sender, EventArgs e)
        {           
            GetEmail = this.tb_mail.Text;
            GetName = this.tb_name.Text;
            GetPassword = this.tb_password.Text;

            Database db = new Database();

            string mail = tb_mail.Text;

            var sql = "SELECT mail FROM login_table WHERE mail='" + mail + "'";
            using var cmd = new MySqlCommand(sql, db.con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (!rdr.Read())
            {
                try
                {
                    MailMessage mailM = new MailMessage();
                    SmtpClient smto = new SmtpClient("smtp.gmail.com", 587);
                    mailM.From = new MailAddress("globala.kthare@gmail.com");
                    mailM.To.Add(tb_mail.Text);
                    mailM.Subject = "Verifieringskod - KTH:are";
                    mailM.Body = "Din verifieringskod: " + getGeneratePassword() + "\nDin inloggningsinformation: \nEmail: " + this.tb_mail.Text + "\nLösenord: " + this.tb_password.Text;
                    smto.Credentials = new System.Net.NetworkCredential("globala.kthare@gmail.com", "kthare2021");
                    smto.EnableSsl = true;
                    smto.Send(mailM);
                    MessageBox.Show("Din verifieringskod har skickats till:\n" + this.tb_mail.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                var form = new CodeVerification(this);
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Kontot finns redan!");
            }               
        }
        /*
         * Show the password by clicking the show button
         */
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
                    errorProvider1.SetError(this.tb_mail, "Skriv in din KTH-emailadress.");
                    break;
                }
                else
                {
                    errorProvider1.SetError(this.tb_mail, "Ingen KTH-emailadress, försök igen!");
                    break;
                }
            }
        }
        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            while (true)
            {

                if (nameOrPassControl(tb_name.Text) == true && correctInput == true && controlLength(tb_name.Text, tb_password.Text))
                {
                    errorProvider1.Clear();
                    btn_register.Enabled = controlLength(tb_name.Text, tb_password.Text);
                    break;
                }
                else if (nameOrPassControl(tb_name.Text) != true)
                {
                    errorProvider1.SetError(this.tb_name, "Indast nummer och bokstäver är tillåtna");
                    break;
                }
                else
                {
                    errorProvider1.Clear();
                    btn_register.Enabled = false;
                    break;
                }
            }
        }
        /*
         * Conditions for accepting a password 
         */
        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            while (true)
            {
               //  the password should has letters || numbers
                if (nameOrPassControl(tb_password.Text) == true && correctInput == true && controlLength(tb_name.Text, tb_password.Text))
                {
                    errorProvider1.Clear();
                    btn_register.Enabled = controlLength(tb_name.Text, tb_password.Text);
                    break;

                }else if (nameOrPassControl(tb_password.Text) != true)
                {
                    errorProvider1.SetError(this.tb_password, "Indast nummer och bokstäver är tillåtna");
                    break;
                }
                else 
                {
                    errorProvider1.Clear();
                    btn_register.Enabled = false;
                    break;
                }
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
        *@return true if the password just has numbers or letters, false otherwise 
        */
        public bool nameOrPassControl (String input)
        {
            return Regex.IsMatch(input, @"^([a-zA-Z0-9]+)$");    
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

        public bool controlLength(string userName, string password)
        {
            if (string.IsNullOrEmpty(password) || userName.Length < 3 || password.Length < 3 || string.IsNullOrEmpty(userName) || userName.Length >= 20 || password.Length >= 20)
            {
                return false;
            }
            return true;
        }      
    }
}
