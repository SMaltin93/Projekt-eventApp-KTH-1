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
    
    public partial class CodeVerification : Form
    {
       
        public CodeVerification()
        {
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
            MessageBox.Show(Register.GetVerfication + "\n"  + Register.GetEmail + "\n" + Register.GetPassword + "\n" + Register.GetName);
            
            if ( Register.GetVerfication == tb_verification.Text )
            {

            
            Database db = new Database();
            string name = Register.GetName; //tb_name.Text;
            string mail = Register.GetEmail; ;//  password tb_mail.Text;
            string password = Register.GetPassword; ; //tb_password.Text;

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


            }else
            {
                MessageBox.Show("fel lösenord");
            }


        }
    }
}
