
namespace KTHare
{
    partial class Register
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
            this.linklbl_login = new System.Windows.Forms.LinkLabel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.cb_showPassword = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // linklbl_login
            // 
            this.linklbl_login.AutoSize = true;
            this.linklbl_login.Location = new System.Drawing.Point(127, 129);
            this.linklbl_login.Name = "linklbl_login";
            this.linklbl_login.Size = new System.Drawing.Size(146, 20);
            this.linklbl_login.TabIndex = 5;
            this.linklbl_login.TabStop = true;
            this.linklbl_login.Text = "Har redan ett konto?";
            this.linklbl_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_login_LinkClicked);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(15, 51);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(67, 20);
            this.lbl_name.TabIndex = 10;
            this.lbl_name.Text = "Förnamn";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(13, 12);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(72, 20);
            this.lbl_mail.TabIndex = 9;
            this.lbl_mail.Text = "KTH-mail";
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(86, 8);
            this.tb_mail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(263, 27);
            this.tb_mail.TabIndex = 0;
            this.tb_mail.TextChanged += new System.EventHandler(this.tb_mail_TextChanged);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(87, 47);
            this.tb_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(263, 27);
            this.tb_name.TabIndex = 1;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(290, 124);
            this.btn_register.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(86, 31);
            this.btn_register.TabIndex = 4;
            this.btn_register.Text = "Skapa";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(87, 85);
            this.tb_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(263, 27);
            this.tb_password.TabIndex = 2;
            this.tb_password.UseSystemPasswordChar = true;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(16, 89);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(70, 20);
            this.lbl_password.TabIndex = 13;
            this.lbl_password.Text = "Lösenord";
            // 
            // cb_showPassword
            // 
            this.cb_showPassword.AutoSize = true;
            this.cb_showPassword.Location = new System.Drawing.Point(358, 91);
            this.cb_showPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_showPassword.Name = "cb_showPassword";
            this.cb_showPassword.Size = new System.Drawing.Size(18, 17);
            this.cb_showPassword.TabIndex = 3;
            this.cb_showPassword.UseVisualStyleBackColor = true;
            this.cb_showPassword.CheckedChanged += new System.EventHandler(this.cb_showPassword_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Show";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 243);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_showPassword);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.linklbl_login);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.btn_register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklbl_login;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.CheckBox cb_showPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
    }
}