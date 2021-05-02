
namespace KTHare
{
    partial class Form1
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
            this.passBox = new System.Windows.Forms.TextBox();
            this.logButt = new System.Windows.Forms.Button();
            this.exiteButt = new System.Windows.Forms.Button();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.sendButt = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(303, 339);
            this.passBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(217, 27);
            this.passBox.TabIndex = 2;
            this.passBox.TextChanged += new System.EventHandler(this.passBox_TextChanged);
            // 
            // logButt
            // 
            this.logButt.Location = new System.Drawing.Point(303, 393);
            this.logButt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logButt.Name = "logButt";
            this.logButt.Size = new System.Drawing.Size(86, 31);
            this.logButt.TabIndex = 0;
            this.logButt.Text = "Login";
            this.logButt.UseVisualStyleBackColor = true;
            this.logButt.Click += new System.EventHandler(this.logButt_Click);
            // 
            // exiteButt
            // 
            this.exiteButt.Location = new System.Drawing.Point(434, 393);
            this.exiteButt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exiteButt.Name = "exiteButt";
            this.exiteButt.Size = new System.Drawing.Size(86, 31);
            this.exiteButt.TabIndex = 1;
            this.exiteButt.Text = "Exit";
            this.exiteButt.UseVisualStyleBackColor = true;
            this.exiteButt.Click += new System.EventHandler(this.exiteButt_Click);
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(309, 212);
            this.mailBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(207, 27);
            this.mailBox.TabIndex = 3;
            this.mailBox.TextChanged += new System.EventHandler(this.mailBox_TextChanged);
            // 
            // sendButt
            // 
            this.sendButt.Location = new System.Drawing.Point(305, 245);
            this.sendButt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendButt.Name = "sendButt";
            this.sendButt.Size = new System.Drawing.Size(114, 31);
            this.sendButt.TabIndex = 4;
            this.sendButt.Text = "Send ";
            this.sendButt.UseVisualStyleBackColor = true;
            this.sendButt.Click += new System.EventHandler(this.sendButt_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "send password to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "password ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendButt);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.exiteButt);
            this.Controls.Add(this.logButt);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

