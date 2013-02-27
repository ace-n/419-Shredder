namespace _419Shredder
{
    partial class Form1
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnTearDown = new System.Windows.Forms.Button();
            this.btnDeSpam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(96, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(90, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 41);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(258, 22);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "aessa_nassri@hotmail.com";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 69);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(258, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnTearDown
            // 
            this.btnTearDown.Enabled = false;
            this.btnTearDown.Location = new System.Drawing.Point(96, 126);
            this.btnTearDown.Name = "btnTearDown";
            this.btnTearDown.Size = new System.Drawing.Size(90, 23);
            this.btnTearDown.TabIndex = 3;
            this.btnTearDown.Text = "Disconnect";
            this.btnTearDown.UseVisualStyleBackColor = true;
            this.btnTearDown.Click += new System.EventHandler(this.btnTearDown_Click);
            // 
            // btnDeSpam
            // 
            this.btnDeSpam.Enabled = false;
            this.btnDeSpam.Location = new System.Drawing.Point(96, 97);
            this.btnDeSpam.Name = "btnDeSpam";
            this.btnDeSpam.Size = new System.Drawing.Size(90, 23);
            this.btnDeSpam.TabIndex = 4;
            this.btnDeSpam.Text = "De-spam";
            this.btnDeSpam.UseVisualStyleBackColor = true;
            this.btnDeSpam.Click += new System.EventHandler(this.btnDeSpam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 173);
            this.Controls.Add(this.btnDeSpam);
            this.Controls.Add(this.btnTearDown);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "419Shredder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnTearDown;
        private System.Windows.Forms.Button btnDeSpam;
    }
}

