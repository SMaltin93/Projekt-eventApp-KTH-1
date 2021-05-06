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

            int y = 0;
            while (rdr.Read())
            {
                createElements(rdr, y);
                y += 50;
            }
        }

        private void createElements(MySqlDataReader rdr, int y)
        {
            string name = rdr.GetString(1);
            string participantNames = rdr.GetString(2);
            int participants = rdr.GetInt32(3);
            string location = rdr.GetString(4);
            string description = rdr.GetString(5);
            string time = rdr.GetString(6);


            Label label = new Label();
            label.AutoSize = true;
            label.Text = "\n" + name + " - " + participantNames + " (" + participants + ") - " + time;
            label.Location = new Point(10, y - 5);

            Button button = new Button();
            button.Click += new EventHandler((s, e) => button_Click(s, e, name, description, participantNames, participants, location, time));
            button.Location = new Point(320, y);
            button.Text = ">";
            button.AutoSize = true;
            button.Padding = new Padding(6);

            this.Controls.Add(label);
            this.Controls.Add(button);
        }

        private void button_Click(object sender, System.EventArgs e, string name, string description, string participantNames, int participants, string location, string time)
        {
            var form = new EventInformation(name, description, participantNames, participants, location, time);
            form.Show();
        }

        private void btn_createEvent_Click(object sender, EventArgs e)
        {
            var form = new CreateEvent();
            form.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            loadEvents();   //Ska se till att skriva om denna sen, vill skapa som olika element istället för enbart en text med all information.
        }

        private void EventsMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
