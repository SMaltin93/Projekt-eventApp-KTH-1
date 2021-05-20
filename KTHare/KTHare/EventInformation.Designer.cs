
namespace KTHare
{
    partial class EventInformation
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
            System.Windows.Forms.Label lbl_participantsLabel;
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_participants = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_location = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_description = new System.Windows.Forms.RichTextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.btn_joinEvent = new System.Windows.Forms.Button();
            lbl_participantsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_participantsLabel
            // 
            lbl_participantsLabel.AutoSize = true;
            lbl_participantsLabel.Location = new System.Drawing.Point(182, 114);
            lbl_participantsLabel.Name = "lbl_participantsLabel";
            lbl_participantsLabel.Size = new System.Drawing.Size(90, 15);
            lbl_participantsLabel.TabIndex = 8;
            lbl_participantsLabel.Text = "Antal deltagare:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 15);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(91, 15);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Namn på event:";
            // 
            // lbl_participants
            // 
            this.lbl_participants.AutoSize = true;
            this.lbl_participants.Location = new System.Drawing.Point(275, 114);
            this.lbl_participants.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_participants.Name = "lbl_participants";
            this.lbl_participants.Size = new System.Drawing.Size(19, 15);
            this.lbl_participants.TabIndex = 1;
            this.lbl_participants.Text = "10";
            // 
            // tb_name
            // 
            this.tb_name.Enabled = false;
            this.tb_name.HideSelection = false;
            this.tb_name.Location = new System.Drawing.Point(109, 12);
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(185, 23);
            this.tb_name.TabIndex = 2;
            this.tb_name.TabStop = false;
            this.tb_name.WordWrap = false;
            // 
            // tb_location
            // 
            this.tb_location.Enabled = false;
            this.tb_location.Location = new System.Drawing.Point(109, 41);
            this.tb_location.Name = "tb_location";
            this.tb_location.ReadOnly = true;
            this.tb_location.Size = new System.Drawing.Size(185, 23);
            this.tb_location.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plats:";
            // 
            // rtb_description
            // 
            this.rtb_description.Enabled = false;
            this.rtb_description.Location = new System.Drawing.Point(12, 132);
            this.rtb_description.Name = "rtb_description";
            this.rtb_description.ReadOnly = true;
            this.rtb_description.Size = new System.Drawing.Size(282, 232);
            this.rtb_description.TabIndex = 5;
            this.rtb_description.Text = "";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(12, 114);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(71, 15);
            this.lbl_description.TabIndex = 7;
            this.lbl_description.Text = "Beskrivning:";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(172, 73);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(26, 15);
            this.lbl_time.TabIndex = 9;
            this.lbl_time.Text = "Tid:";
            // 
            // tb_time
            // 
            this.tb_time.Enabled = false;
            this.tb_time.Location = new System.Drawing.Point(204, 70);
            this.tb_time.Name = "tb_time";
            this.tb_time.ReadOnly = true;
            this.tb_time.Size = new System.Drawing.Size(90, 23);
            this.tb_time.TabIndex = 10;
            this.tb_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_joinEvent
            // 
            this.btn_joinEvent.Location = new System.Drawing.Point(219, 370);
            this.btn_joinEvent.Name = "btn_joinEvent";
            this.btn_joinEvent.Size = new System.Drawing.Size(75, 23);
            this.btn_joinEvent.TabIndex = 11;
            this.btn_joinEvent.Text = "Gå med";
            this.btn_joinEvent.UseVisualStyleBackColor = true;
            this.btn_joinEvent.Click += new System.EventHandler(this.btn_joinEvent_Click);
            // 
            // EventInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(306, 398);
            this.Controls.Add(this.btn_joinEvent);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(lbl_participantsLabel);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.rtb_description);
            this.Controls.Add(this.tb_location);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lbl_participants);
            this.Controls.Add(this.lbl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventInformation";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EventInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_participants;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_location;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_description;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.Button btn_joinEvent;
    }
}