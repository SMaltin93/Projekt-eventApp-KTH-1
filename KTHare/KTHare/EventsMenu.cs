using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KTHare
{
    public partial class EventsMenu : Form
    {
        List<Control> list = new List<Control>();
        List<string> oldValues = new List<string>();
        public EventsMenu()
        {
            InitializeComponent();

            Database db = new Database();

            var sql = "SELECT * FROM event_table";
            using var cmd = new MySqlCommand(sql, db.con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            object[] obj = new object[rdr.FieldCount];

            while (rdr.Read())
            {
                oldValues.Add(rdr.GetValues(obj).ToString());
            }
        }

        private void EventsMenu_Load(object sender, EventArgs e)
        {
            loadEvents();
            timer.Start();
        }

        /**
        * load the events from the database
        */
        private void loadEvents()
        {
            Database db = new Database();

            var sql = "SELECT * FROM event_table";
            using var cmd = new MySqlCommand(sql, db.con);

            using MySqlDataReader rdr = cmd.ExecuteReader();
            int y = 30;

            while (rdr.Read())
            {
                createElements(rdr, y);
                y += 60; // Interval between the events
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

            Color color = Color.Black;
            int indexPositionUser = -1;

            // Create an array of the participants
            // It uses to check if the user is already a participant 

            string[] participantNamesArray = participantNames.Split(", ");

            for (int i = 0; i < participantNamesArray.Length; i++)
            {
                if (participantNamesArray[i] == User.name)
                {
                    indexPositionUser = i; 
                    color = Color.LimeGreen;
                }
            }

            Label label = new Label();
            label.AutoSize = true;
            label.ForeColor = color;
            label.Text = "\n" + name + " (" + location + ") - " + participantNames + " (" + participants + ") - " + DateTime.UtcNow.ToString("yyyy-MM-dd") + " " + time ;
            label.Location = new Point(30, y);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(25, y - 5);
            pictureBox.Size = new Size(865, 50);
            pictureBox.BorderStyle = BorderStyle.Fixed3D;

            Button button = new Button();
            button.Location = new Point(800, y);
            button.BackColor = Color.White;
            button.FlatAppearance.BorderSize = 1;
            button.FlatStyle = FlatStyle.Flat;
            button.AutoSize = true;
            button.Padding = new Padding(6);

            if (color == Color.LimeGreen)
            {
                button.ForeColor = Color.Red;
                button.Click += new EventHandler((s, e) => buttonLeave_Click(s, e, name, description, participantNamesArray, indexPositionUser, participants, location, time));
                button.Text = "< Lämna";
            }
            else
            {
                button.Click += new EventHandler((s, e) => buttonJoin_Click(s, e, name, description, participantNames, participants, location, time));
                button.Text = "Gå med >";
            }

            list.Add(label);
            list.Add(pictureBox);
            list.Add(button);

            this.Controls.Add(label);
            this.Controls.Add(button);
            this.Controls.Add(pictureBox);
        }

        private void buttonJoin_Click(object sender, System.EventArgs e, string name, string description, string participantNames, int participants, string location, string time)
        {
            var form = new EventInformation(name, description, participantNames, participants, location, time);
            form.Show();
        }
        private void buttonLeave_Click(object sender, System.EventArgs e, string name, string description, string[] participantNamesArray, int indexPositionUser, int participants, string location, string time)
        {
            participants--;

            if (participants == 0)
            {
                deleteEvent(name);
            }
            else
            {
                StringBuilder participantNames = new StringBuilder();

                int temp = 0;
                if (indexPositionUser == temp)
                {
                    participantNames.Append(participantNamesArray[1]);
                    temp = 2;
                }
                else
                {
                    participantNames.Append(participantNamesArray[0]);
                    temp = 1;
                }

                for (int i = temp; i < participantNamesArray.Length; i++)
                {
                    if (indexPositionUser != i)
                    {
                        participantNames.Append(", " + participantNamesArray[i]);
                    }
                }

                string cs = @KTHare.Properties.Settings.Default.ConnectionString;
                MySqlConnection con = new MySqlConnection(cs);

                string sql = "UPDATE event_table SET participantNames='" + participantNames + "',participants='" + participants + "' WHERE name='" + name + "'";
                var cmd = new MySqlCommand(sql, con);
                try
                {
                    con.Open();
                    var adapter = new MySqlDataAdapter(cmd);

                    adapter.UpdateCommand = con.CreateCommand();
                    adapter.UpdateCommand.CommandText = sql;

                    if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Du lämnade eventet!");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        /*
         * Delete the event when the user leaves it 
         */
        private void deleteEvent(string name)
        {
            string cs = @KTHare.Properties.Settings.Default.ConnectionString;
            MySqlConnection con = new MySqlConnection(cs);

            string sql = "DELETE FROM event_table WHERE name='" + name + "'";
            var cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                var adapter = new MySqlDataAdapter(cmd);

                adapter.UpdateCommand = con.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;

                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Du lämnade eventet!");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        /*
         * Create an event
         */
        private void btn_createEvent_Click(object sender, EventArgs e)
        {
            var form = new CreateEvent();
            form.Show();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (detectChange())
            {
                deleteElements();
                loadEvents();
            }
        }
        private bool detectChange()
        {
            Database db = new Database();

            var sql = "SELECT * FROM event_table";
            using var cmd = new MySqlCommand(sql, db.con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            List<string> temp = new List<string>();
            object[] obj = new object[rdr.FieldCount];

            while (rdr.Read())
            {
                temp.Add(rdr.GetString(2).ToString());
            }

            if (temp.SequenceEqual(oldValues))
            {
                return false;
            }
            oldValues = temp.GetRange(0, temp.Count);
            return true;
        }
        private void deleteElements()
        {
            foreach (var item in list)
            {
                item.Dispose();
            }       
        }

        private void EventsMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            User.id = -1;
            User.name = "";
            User.mail = "";

            var form = new Login();
            this.Hide();
            form.Show();
        }
    }
}
