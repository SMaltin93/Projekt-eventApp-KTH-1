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
    public partial class CreateEvent : Form
    {
        public CreateEvent()
        {
            InitializeComponent();
        }

        private void btn_createEvent_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            string name = tb_name.Text;
            string location = tb_location.Text;
            string description = tb_description.Text;

            var sql = "INSERT INTO event_table(id, name, participantNames, location, description) VALUES(NULL, @name, @participantNames, @location, @description)";
            using var cmd = new MySqlCommand(sql, db.con);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@participantNames", User.name);
            cmd.Parameters.AddWithValue("@location", location);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            MessageBox.Show("Event: " + name + " created!");
            this.Hide();
        }
    }
}
