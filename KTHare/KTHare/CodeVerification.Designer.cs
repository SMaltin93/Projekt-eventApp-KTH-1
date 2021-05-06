
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
            this.btn_verify = new System.Windows.Forms.Button();
            this.lbl_verify = new System.Windows.Forms.Label();
            this.tb_verification = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_verify
            // 
            this.btn_verify.Location = new System.Drawing.Point(109, 32);
            this.btn_verify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.Size = new System.Drawing.Size(82, 22);
            this.btn_verify.TabIndex = 0;
            this.btn_verify.Text = "Verify";
            this.btn_verify.UseVisualStyleBackColor = true;
            this.btn_verify.Click += new System.EventHandler(this.btn_verify_Click);
            // 
            // lbl_verify
            // 
            this.lbl_verify.AutoSize = true;
            this.lbl_verify.Location = new System.Drawing.Point(106, 67);
            this.lbl_verify.Name = "lbl_verify";
            this.lbl_verify.Size = new System.Drawing.Size(101, 15);
            this.lbl_verify.TabIndex = 1;
            this.lbl_verify.Text = "Verification code :";
            this.lbl_verify.Click += new System.EventHandler(this.lbl_verify_Click);
            // 
            // tb_verification
            // 
            this.tb_verification.Location = new System.Drawing.Point(213, 64);
            this.tb_verification.Name = "tb_verification";
            this.tb_verification.Size = new System.Drawing.Size(204, 23);
            this.tb_verification.TabIndex = 2;
            this.tb_verification.TextChanged += new System.EventHandler(this.tb_verification_TextChanged);
            // 
            // CodeVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 647);
            this.Controls.Add(this.tb_verification);
            this.Controls.Add(this.lbl_verify);
            this.Controls.Add(this.btn_verify);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CodeVerification";
            this.Text = "CodeVerification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_verify;
        private System.Windows.Forms.Label lbl_verify;
        private System.Windows.Forms.TextBox tb_verification;
    }
}