using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace KTHare
{
    class Database
    {
        public string cs = @"server=155.4.6.242;userid=username;password=password;database=kthare";
        public MySqlConnection con;

        public Database()
        {
            con = new MySqlConnection(cs);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error!\n" + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
