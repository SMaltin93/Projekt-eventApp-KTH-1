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
    /*
     * Show the event details to the joiner  
     * Join the event
     */
    public partial class EventInformation : Form
    {
        string name;
        string description;
        string participantNames;
        int participants;
        string location;
        string time;

        /*
         * Set the event details 
         * 
         * name : Event name 
         * description : Description of the event 
         * participantNames : The participant name 
         * participants : The numer of participants 
         * location : The location of the event 
         * time : the event time
         */
        public EventInformation(string name, string description, string participantNames, int participants, string location, string time)
        {
            this.name = name;
            this.description = description;
            this.participantNames = participantNames;
            this.participants = participants;
            this.location = location;
            this.time = time;

            InitializeComponent();
        }

        private void EventInformation_Load(object sender, EventArgs e)
        {
            tb_name.Text = name;
            tb_location.Text = location;
            lbl_participants.Text = participants.ToString();
            rtb_description.Text = description;
            tb_time.Text = time;
        }
        /*
         * Join the event by clicking 
         * Uppdate event table
         */
        private void btn_joinEvent_Click(object sender, EventArgs e)
        {        
            string cs = @KTHare.Properties.Settings.Default.ConnectionString;
            MySqlConnection con = new MySqlConnection(cs);

            participantNames += ", " + User.name;
            participants++;

            string sql = "UPDATE event_table SET participantNames='"+ participantNames + "',participants='" + participants + "' WHERE name='" + name + "'";
            var cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                var adapter = new MySqlDataAdapter(cmd);

                adapter.UpdateCommand = con.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;

                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Du gick med i eventet!");
                    this.Hide();
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
}
