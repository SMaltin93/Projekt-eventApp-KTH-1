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

        /*
         * Create new event
         */
        private void btn_createEvent_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            string name = tb_name.Text;
            string location = tb_location.Text;
            string description = tb_description.Text;
            string time = cb_time.Text;

            // Add details to the database

            if (name != "" && location != "" && description != "" && time != "")
            {
                var sql = "INSERT INTO event_table(id, name, participantNames, location, description, time) VALUES(NULL, @name, @participantNames, @location, @description, @time)";
                using var cmd = new MySqlCommand(sql, db.con);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@participantNames", User.name);
                cmd.Parameters.AddWithValue("@location", location);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@time", time);
                cmd.Prepare();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Event: " + name + " skapades!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Behöver mer information om eventet. Försök igen!");
            }
        }
        /*
         * Load events
         */
        private void CreateEvent_Load(object sender, EventArgs e)
        {
            cb_time.DisplayMember = "Time";
            cb_time.ValueMember = "Value";

            for (int i = 0; i <= 24; i++)
            {
                if (i < 10)
                {
                    cb_time.Items.Add("0" + i + ":00");
                }
                else
                {
                    cb_time.Items.Add(i + ":00");
                }
            }
        }
    }
}
