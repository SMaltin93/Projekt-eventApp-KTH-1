
namespace KTHare
{
    partial class errorProvider
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.logButt = new System.Windows.Forms.Button();
            this.exiteButt = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.sendButt = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // logButt
            // 
            this.logButt.Location = new System.Drawing.Point(265, 295);
            this.logButt.Name = "logButt";
            this.logButt.Size = new System.Drawing.Size(75, 23);
            this.logButt.TabIndex = 0;
            this.logButt.Text = "Login";
            this.logButt.UseVisualStyleBackColor = true;
            this.logButt.Click += new System.EventHandler(this.logButt_Click);
            // 
            // exiteButt
            // 
            this.exiteButt.Location = new System.Drawing.Point(380, 295);
            this.exiteButt.Name = "exiteButt";
            this.exiteButt.Size = new System.Drawing.Size(75, 23);
            this.exiteButt.TabIndex = 1;
            this.exiteButt.Text = "Exit";
            this.exiteButt.UseVisualStyleBackColor = true;
            this.exiteButt.Click += new System.EventHandler(this.exiteButt_Click);
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(265, 254);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(190, 23);
            this.passBox.TabIndex = 2;
            this.passBox.TextChanged += new System.EventHandler(this.passBox_TextChanged);
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(273, 165);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(182, 23);
            this.mailBox.TabIndex = 3;
            this.mailBox.TextChanged += new System.EventHandler(this.mailBox_TextChanged);
            // 
            // sendButt
            // 
            this.sendButt.Location = new System.Drawing.Point(273, 136);
            this.sendButt.Name = "sendButt";
            this.sendButt.Size = new System.Drawing.Size(75, 23);
            this.sendButt.TabIndex = 4;
            this.sendButt.Text = "Send";
            this.sendButt.UseVisualStyleBackColor = true;
            this.sendButt.Click += new System.EventHandler(this.sendButt_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendButt);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.exiteButt);
            this.Controls.Add(this.logButt);
            this.Name = "errorProvider";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logButt;
        private System.Windows.Forms.Button exiteButt;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.Button sendButt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

