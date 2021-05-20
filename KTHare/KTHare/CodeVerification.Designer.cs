
namespace KTHare
{
    partial class CodeVerification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeVerification));
            this.btn_verify = new System.Windows.Forms.Button();
            this.lbl_verify = new System.Windows.Forms.Label();
            this.tb_verification = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_verify
            // 
            this.btn_verify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verify.Location = new System.Drawing.Point(279, 61);
            this.btn_verify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.Size = new System.Drawing.Size(116, 40);
            this.btn_verify.TabIndex = 0;
            this.btn_verify.Text = "Verifiera";
            this.btn_verify.UseVisualStyleBackColor = true;
            this.btn_verify.Click += new System.EventHandler(this.btn_verify_Click);
            // 
            // lbl_verify
            // 
            this.lbl_verify.AutoSize = true;
            this.lbl_verify.BackColor = System.Drawing.Color.Transparent;
            this.lbl_verify.Location = new System.Drawing.Point(16, 11);
            this.lbl_verify.Name = "lbl_verify";
            this.lbl_verify.Size = new System.Drawing.Size(98, 15);
            this.lbl_verify.TabIndex = 1;
            this.lbl_verify.Text = "Verification code:";
            // 
            // tb_verification
            // 
            this.tb_verification.Location = new System.Drawing.Point(120, 8);
            this.tb_verification.Name = "tb_verification";
            this.tb_verification.Size = new System.Drawing.Size(275, 23);
            this.tb_verification.TabIndex = 2;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Location = new System.Drawing.Point(16, 61);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(43, 15);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Namn:";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mail.Location = new System.Drawing.Point(16, 86);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(39, 15);
            this.lbl_mail.TabIndex = 4;
            this.lbl_mail.Text = "Email:";
            // 
            // CodeVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KTHare.Properties.Resources.kth;
            this.ClientSize = new System.Drawing.Size(411, 112);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.tb_verification);
            this.Controls.Add(this.lbl_verify);
            this.Controls.Add(this.btn_verify);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CodeVerification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KTH:are - Verifiering";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CodeVerification_FormClosed);
            this.Load += new System.EventHandler(this.CodeVerification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_verify;
        private System.Windows.Forms.Label lbl_verify;
        private System.Windows.Forms.TextBox tb_verification;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_mail;
    }
}