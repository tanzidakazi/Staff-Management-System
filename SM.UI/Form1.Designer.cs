namespace SM.UI
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
            this.Title = new System.Windows.Forms.Label();
            this.AdUsername = new System.Windows.Forms.Label();
            this.AdPassword = new System.Windows.Forms.Label();
            this.usernametf = new System.Windows.Forms.TextBox();
            this.passwordtf = new System.Windows.Forms.TextBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(241, 48);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(333, 31);
            this.Title.TabIndex = 0;
            this.Title.Text = "Staff Management System";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdUsername
            // 
            this.AdUsername.AutoSize = true;
            this.AdUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdUsername.Location = new System.Drawing.Point(159, 144);
            this.AdUsername.Name = "AdUsername";
            this.AdUsername.Size = new System.Drawing.Size(157, 17);
            this.AdUsername.TabIndex = 1;
            this.AdUsername.Text = "Adminstrator Username";
            // 
            // AdPassword
            // 
            this.AdPassword.AutoSize = true;
            this.AdPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdPassword.Location = new System.Drawing.Point(162, 180);
            this.AdPassword.Name = "AdPassword";
            this.AdPassword.Size = new System.Drawing.Size(153, 17);
            this.AdPassword.TabIndex = 2;
            this.AdPassword.Text = "Adminstrator Password";
            this.AdPassword.Click += new System.EventHandler(this.AdPassword_Click);
            // 
            // usernametf
            // 
            this.usernametf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametf.Location = new System.Drawing.Point(367, 141);
            this.usernametf.Name = "usernametf";
            this.usernametf.Size = new System.Drawing.Size(260, 23);
            this.usernametf.TabIndex = 3;
            this.usernametf.TextChanged += new System.EventHandler(this.AdUsernametf_TextChanged);
            // 
            // passwordtf
            // 
            this.passwordtf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtf.Location = new System.Drawing.Point(367, 177);
            this.passwordtf.Name = "passwordtf";
            this.passwordtf.Size = new System.Drawing.Size(260, 23);
            this.passwordtf.TabIndex = 4;
            this.passwordtf.UseSystemPasswordChar = true;
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.Location = new System.Drawing.Point(599, 280);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(90, 39);
            this.SignIn.TabIndex = 6;
            this.SignIn.Text = "Sign in";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 443);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.passwordtf);
            this.Controls.Add(this.usernametf);
            this.Controls.Add(this.AdPassword);
            this.Controls.Add(this.AdUsername);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Staff Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label AdUsername;
        private System.Windows.Forms.Label AdPassword;
        private System.Windows.Forms.TextBox usernametf;
        private System.Windows.Forms.TextBox passwordtf;
        private System.Windows.Forms.Button SignIn;
    }
}

