using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;



namespace KTHare
{
    
    public partial class CodeVerification : Form
    {
        public Register read;
        public CodeVerification(Register read)
        {
            this.read = read;
            InitializeComponent();
        }

        private void tb_verification_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_verify_Click(object sender, EventArgs e)
        {

        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(Register.GetVerfication + "\n"  + Register.GetEmail + "\n" + Register.GetPassword + "\n" + Register.GetName);
            
            if ( read.GetVerfication == tb_verification.Text )
            {

            Database db = new Database();
            string name = read.GetName; //tb_name.Text;
            string mail = read.GetEmail; ;//  password tb_mail.Text;
            string password = read.GetPassword; ; //tb_password.Text;
                

            var sql = "INSERT INTO login_table(id, name, mail, password) VALUES(NULL, @name, @mail, @password)";
            using var cmd = new MySqlCommand(sql, db.con);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            MessageBox.Show("Konto " + name + " skapades!");
            //  Register.GetVerfication = ""; Kanske behövs 
            var form = new Login();
            this.Hide();
            form.Show();


            }else if (string.IsNullOrEmpty(tb_verification.Text))
            {
                MessageBox.Show(" Enter your password! ");

            } else
            {
                MessageBox.Show(" Incorrect password! \n Try agin! (: ");
            }


        }
    }
}
