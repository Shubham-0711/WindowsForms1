namespace WindowsForms1
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(117, 156);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(76, 16);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "User Name";
            this.lblUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtusername
            // 
            this.txtusername.AccessibleName = "";
            this.txtusername.Location = new System.Drawing.Point(280, 148);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(199, 22);
            this.txtusername.TabIndex = 1;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(117, 204);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.AccessibleName = "";
            this.txtpassword.Location = new System.Drawing.Point(280, 194);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(199, 22);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.AccessibleName = "";
            this.btnlogin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnlogin.Location = new System.Drawing.Point(323, 257);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(115, 28);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btncancel
            // 
            this.btncancel.AccessibleName = "";
            this.btncancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btncancel.Location = new System.Drawing.Point(323, 308);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(115, 28);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 522);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblUsername);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btncancel;
    }
}

