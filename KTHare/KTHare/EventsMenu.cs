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
    public partial class EventsMenu : Form
    {
        public EventsMenu()
        {
            InitializeComponent();
        }

        private void EventsMenu_Load(object sender, EventArgs e)
        {
            Database db = new Database();

            var sql = "SELECT * FROM event_table";
            using var cmd = new MySqlCommand(sql, db.con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                lbl_welcome.Text += "\n" + rdr.GetString(1) + " - " + rdr.GetString(2) + " (" + (rdr.GetInt32(3)).ToString() + ")";
            }
        }
    }
}
