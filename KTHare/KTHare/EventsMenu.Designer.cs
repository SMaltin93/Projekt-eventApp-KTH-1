
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
            this.btn_createEvent = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_createEvent
            // 
            this.btn_createEvent.Location = new System.Drawing.Point(73, 415);
            this.btn_createEvent.Name = "btn_createEvent";
            this.btn_createEvent.Size = new System.Drawing.Size(242, 23);
            this.btn_createEvent.TabIndex = 1;
            this.btn_createEvent.Text = "Skapa event";
            this.btn_createEvent.UseVisualStyleBackColor = true;
            this.btn_createEvent.Click += new System.EventHandler(this.btn_createEvent_Click);
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // EventsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.btn_createEvent);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventsMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EventsMenu_FormClosed);
            this.Load += new System.EventHandler(this.EventsMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_createEvent;
        private System.Windows.Forms.Timer timer;
    }
}