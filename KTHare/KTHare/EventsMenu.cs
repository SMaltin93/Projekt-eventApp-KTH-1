using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            lbl_welcome.Text = "Welcome, " + User.name + "!";



        }
    }
}
