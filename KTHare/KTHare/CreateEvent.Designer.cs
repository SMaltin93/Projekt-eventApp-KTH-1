
namespace KTHare
{
    partial class CreateEvent
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
            this.btn_createEvent = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_location = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.cb_time = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_createEvent
            // 
            this.btn_createEvent.Location = new System.Drawing.Point(219, 370);
            this.btn_createEvent.Name = "btn_createEvent";
            this.btn_createEvent.Size = new System.Drawing.Size(75, 23);
            this.btn_createEvent.TabIndex = 0;
            this.btn_createEvent.Text = "Create";
            this.btn_createEvent.UseVisualStyleBackColor = true;
            this.btn_createEvent.Click += new System.EventHandler(this.btn_createEvent_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(109, 12);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(185, 23);
            this.tb_name.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 15);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(91, 15);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Namn på event:";
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(12, 132);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(282, 238);
            this.tb_description.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Plats:";
            // 
            // tb_location
            // 
            this.tb_location.Location = new System.Drawing.Point(109, 41);
            this.tb_location.Name = "tb_location";
            this.tb_location.Size = new System.Drawing.Size(185, 23);
            this.tb_location.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Beskrivning:";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(172, 73);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(26, 15);
            this.lbl_time.TabIndex = 8;
            this.lbl_time.Text = "Tid:";
            // 
            // cb_time
            // 
            this.cb_time.FormattingEnabled = true;
            this.cb_time.Location = new System.Drawing.Point(204, 70);
            this.cb_time.Name = "cb_time";
            this.cb_time.Size = new System.Drawing.Size(90, 23);
            this.cb_time.TabIndex = 9;
            // 
            // CreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 398);
            this.Controls.Add(this.cb_time);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_location);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.btn_createEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateEvent";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CreateEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_createEvent;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_location;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_time;
        private System.Windows.Forms.Label lbl_time;
    }
}