using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace KTHare
{
    public partial class errorProvider : Form
    {
        public errorProvider()
        {
            InitializeComponent();
        }
      
      
        private void sendButt_Click(object sender, EventArgs e)
        {

            if (emailControl(mailBox.Text) == true && !(String.IsNullOrEmpty(mailBox.Text)))
            {

                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient smto = new SmtpClient("smtp.gmail.com", 587);
                    mail.From = new MailAddress("globala.kthare@gmail.com");
                    mail.To.Add(mailBox.Text);
                    mail.Subject = "Your password";
                    mail.Body = GenerateNumber();
                    smto.Credentials = new System.Net.NetworkCredential("globala.kthare@gmail.com", "kthare2021");
                    smto.EnableSsl = true;
                    smto.Send(mail);
                    MessageBox.Show("Check your email, password is sended");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                /*

                Main mainForm = new Main();
                mainForm.Show(); 
                this.Hide();  // Hide login form
                */
            }

        }

        private void mailBox_TextChanged(object sender, EventArgs e)
        {
            String input = mailBox.Text;
            bool check = emailControl(input);

            if (check == true)
            {
                errorProvider1.Clear();
            }
            else if (string.IsNullOrEmpty(mailBox.Text))
            {
                errorProvider1.SetError(this.mailBox, "Enter your KTH email");
                return;
            }
            else
            {
                errorProvider1.SetError(this.mailBox, "You are not KTH:are, please try again");
                return;
            }

        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void logButt_Click(object sender, EventArgs e)
        {

        }

        private void exiteButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /*
         * ################ Help functions ###########
         */



        /**
         *
         *@return true if the user has a kth email, false otherwise 
         */
        private bool emailControl(String userMail)
        {
            return Regex.IsMatch(userMail, @"^([\w\.\-]+)@((?i)[kth]+)((\.(\w)(?i)[se])+)$");
        }


        /**
         *Generate password
         *@return a random password
         */
        private string GenerateNumber()
        {
            Random rand = new Random();
            string send_rand = "";
            for (int i = 1; i <= 9; i++)
            {
                send_rand += rand.Next(0, 9).ToString();
            }
            return send_rand;
        }
    }
}
