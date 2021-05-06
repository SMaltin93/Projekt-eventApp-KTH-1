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
    public partial class EventInformation : Form
    {
        string name;
        string description;
        string participantNames;
        string participants;
        string location;

        public EventInformation(string name, string description, string participantNames, string participants, string location)
        {
            this.name = name;
            this.description = description;
            this.participantNames = participantNames;
            this.participants = participants;
            this.location = location;

            InitializeComponent();
        }

        private void EventInformation_Load(object sender, EventArgs e)
        {
            tb_name.Text = name;
            tb_location.Text = location;
            lbl_participants.Text = participants;
            rtb_description.Text = description;
        }
    }
}
