
namespace KTHare
{
    partial class Login
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
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.linklbl_createaccount = new System.Windows.Forms.LinkLabel();
            this.cb_showPassword = new System.Windows.Forms.CheckBox();
            this.lbl_show = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(307, 78);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(94, 29);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Logga in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(94, 44);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(288, 23);
            this.tb_password.TabIndex = 1;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(94, 8);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(288, 23);
            this.tb_mail.TabIndex = 0;
            this.tb_mail.TextChanged += new System.EventHandler(this.tb_mail_TextChanged);
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(16, 11);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(60, 15);
            this.lbl_mail.TabIndex = 3;
            this.lbl_mail.Text = "KTH-mail:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(17, 48);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(59, 15);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Lösenord:";
            // 
            // linklbl_createaccount
            // 
            this.linklbl_createaccount.AutoSize = true;
            this.linklbl_createaccount.Location = new System.Drawing.Point(206, 85);
            this.linklbl_createaccount.Name = "linklbl_createaccount";
            this.linklbl_createaccount.Size = new System.Drawing.Size(95, 15);
            this.linklbl_createaccount.TabIndex = 4;
            this.linklbl_createaccount.TabStop = true;
            this.linklbl_createaccount.Text = "Har inget konto?";
            this.linklbl_createaccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_createaccount_LinkClicked);
            // 
            // cb_showPassword
            // 
            this.cb_showPassword.AutoSize = true;
            this.cb_showPassword.Location = new System.Drawing.Point(386, 49);
            this.cb_showPassword.Name = "cb_showPassword";
            this.cb_showPassword.Size = new System.Drawing.Size(15, 14);
            this.cb_showPassword.TabIndex = 2;
            this.cb_showPassword.UseVisualStyleBackColor = true;
            this.cb_showPassword.CheckedChanged += new System.EventHandler(this.cb_showPassword_CheckedChanged);
            // 
            // lbl_show
            // 
            this.lbl_show.AutoSize = true;
            this.lbl_show.Location = new System.Drawing.Point(333, 38);
            this.lbl_show.Name = "lbl_show";
            this.lbl_show.Size = new System.Drawing.Size(36, 15);
            this.lbl_show.TabIndex = 15;
            this.lbl_show.Text = "Show";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Visa";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 119);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_showPassword);
            this.Controls.Add(this.linklbl_createaccount);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KTH:are - Logga in";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel linklbl_createaccount;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.CheckBox cb_showPassword;
        private System.Windows.Forms.Label lbl_show;
        private System.Windows.Forms.Label label1;
    }
}