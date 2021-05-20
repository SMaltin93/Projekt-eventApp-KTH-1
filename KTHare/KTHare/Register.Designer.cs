
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
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
            this.lbl_show = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // linklbl_login
            // 
            this.linklbl_login.AutoSize = true;
            this.linklbl_login.BackColor = System.Drawing.Color.Transparent;
            this.linklbl_login.Location = new System.Drawing.Point(136, 121);
            this.linklbl_login.Name = "linklbl_login";
            this.linklbl_login.Size = new System.Drawing.Size(115, 15);
            this.linklbl_login.TabIndex = 5;
            this.linklbl_login.TabStop = true;
            this.linklbl_login.Text = "Har redan ett konto?";
            this.linklbl_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_login_LinkClicked);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Location = new System.Drawing.Point(16, 48);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(58, 15);
            this.lbl_name.TabIndex = 10;
            this.lbl_name.Text = "Förnamn:";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mail.Location = new System.Drawing.Point(16, 11);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(60, 15);
            this.lbl_mail.TabIndex = 9;
            this.lbl_mail.Text = "KTH-mail:";
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(94, 8);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(288, 23);
            this.tb_mail.TabIndex = 0;
            this.tb_mail.TextChanged += new System.EventHandler(this.tb_mail_TextChanged);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(95, 44);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(288, 23);
            this.tb_name.TabIndex = 1;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(308, 114);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(94, 29);
            this.btn_register.TabIndex = 4;
            this.btn_register.Text = "Skapa";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(95, 80);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(288, 23);
            this.tb_password.TabIndex = 2;
            this.tb_password.UseSystemPasswordChar = true;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.Location = new System.Drawing.Point(16, 83);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(59, 15);
            this.lbl_password.TabIndex = 13;
            this.lbl_password.Text = "Lösenord:";
            // 
            // cb_showPassword
            // 
            this.cb_showPassword.AutoSize = true;
            this.cb_showPassword.BackColor = System.Drawing.Color.Transparent;
            this.cb_showPassword.Location = new System.Drawing.Point(395, 90);
            this.cb_showPassword.Name = "cb_showPassword";
            this.cb_showPassword.Size = new System.Drawing.Size(15, 14);
            this.cb_showPassword.TabIndex = 3;
            this.cb_showPassword.UseVisualStyleBackColor = false;
            this.cb_showPassword.CheckedChanged += new System.EventHandler(this.cb_showPassword_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl_show
            // 
            this.lbl_show.AutoSize = true;
            this.lbl_show.BackColor = System.Drawing.Color.Transparent;
            this.lbl_show.Location = new System.Drawing.Point(389, 72);
            this.lbl_show.Name = "lbl_show";
            this.lbl_show.Size = new System.Drawing.Size(28, 15);
            this.lbl_show.TabIndex = 14;
            this.lbl_show.Text = "Visa";
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkRate = 1;
            this.errorProvider2.ContainerControl = this;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KTHare.Properties.Resources.kth;
            this.ClientSize = new System.Drawing.Size(442, 153);
            this.Controls.Add(this.lbl_show);
            this.Controls.Add(this.cb_showPassword);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.linklbl_login);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.btn_register);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KTH:are - Skapa konto";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
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
        private System.Windows.Forms.Label lbl_show;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}