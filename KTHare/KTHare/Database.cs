using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace KTHare
{
    /**
    * Checks if the database is on or not.
    */
    class Database
    {
        public string cs = @KTHare.Properties.Settings.Default.ConnectionString;
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
                MessageBox.Show("Anslutningsfel!\n" + ex.Message);
            }
        }
    }
}
