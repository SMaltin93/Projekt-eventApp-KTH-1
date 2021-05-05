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


            int i = 0;
            while (rdr.Read())
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Text = "\n" + rdr.GetString(1) + " - " + rdr.GetString(2) + " (" + (rdr.GetInt32(3)).ToString() + ")";
                label.Location = new Point(10, i-5);

                Button button = new Button();
                button.Click += new EventHandler(button_Click);
                button.Location = new Point(300, i);
                button.Text = ">";
                button.AutoSize = true;
                button.Padding = new Padding(6);

                this.Controls.Add(label);
                this.Controls.Add(button);

                i += 50;
            }
        }

        private void button_Click(object sender, System.EventArgs e)
        {
            var form = new EventInformation();
            form.Show();
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
