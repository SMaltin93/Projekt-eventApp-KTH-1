
namespace KTHare
{
    partial class EventsMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsMenu));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btn_createEvent = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btn_createEvent
            // 
            this.btn_createEvent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_createEvent.Location = new System.Drawing.Point(0, 613);
            this.btn_createEvent.Name = "btn_createEvent";
            this.btn_createEvent.Size = new System.Drawing.Size(910, 23);
            this.btn_createEvent.TabIndex = 0;
            this.btn_createEvent.Text = "Skapa event";
            this.btn_createEvent.UseVisualStyleBackColor = true;
            this.btn_createEvent.Click += new System.EventHandler(this.btn_createEvent_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_logout.Location = new System.Drawing.Point(0, 590);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(910, 23);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Logga ut";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // EventsMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = global::KTHare.Properties.Resources.kth;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 636);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_createEvent);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KTH:are - Event";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EventsMenu_FormClosed);
            this.Load += new System.EventHandler(this.EventsMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btn_createEvent;
        private System.Windows.Forms.Button btn_logout;
    }
}