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
            
            if ( read.GetVerfication == tb_verification.Text )
            {

            Database db = new Database();
            string name = read.GetName;
            string mail = read.GetEmail; 
            string password = read.GetPassword; 
                

            var sql = "INSERT INTO login_table(id, name, mail, password) VALUES(NULL, @name, @mail, AES_ENCRYPT('" + password + "', '" + KTHare.Properties.Settings.Default.HashPassword + "'))";
            using var cmd = new MySqlCommand(sql, db.con);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            MessageBox.Show("Konto " + name + " skapades!");
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
