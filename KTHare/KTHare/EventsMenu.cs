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
            loadEvents();
            timer.Start();
        }

        /**
        * Laddar in eventsen från databasen
        */
        private void loadEvents()
        {
            Database db = new Database();

            var sql = "SELECT * FROM event_table";
            using var cmd = new MySqlCommand(sql, db.con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Button newButton = new Button();
                newButton.Text = "Created Button";
                newButton.Location = new Point(70, 70);
                newButton.Size = new Size(50, 100);

                lbl_welcome.Text += "\n" + rdr.GetString(1) + " - " + rdr.GetString(2) + " (" + (rdr.GetInt32(3)).ToString() + ")"; //Only temp
            }
        }

        private void btn_createEvent_Click(object sender, EventArgs e)
        {
            var form = new CreateEvent();
            form.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbl_welcome.Text = ""; //Temporär lösning
            loadEvents();   //Ska se till att skriva om denna sen, vill skapa som olika element istället för enbart en text med all information.
        }

        private void EventsMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
