namespace SM.UI
{
    partial class Form2
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
            this.AddLabel = new System.Windows.Forms.Button();
            this.ModifyLabel = new System.Windows.Forms.Button();
            this.ViewLable = new System.Windows.Forms.Button();
            this.SalaryDetailsLable = new System.Windows.Forms.Button();
            this.ClickLable = new System.Windows.Forms.Label();
            this.BackLabel1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddLabel
            // 
            this.AddLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLabel.Location = new System.Drawing.Point(245, 104);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(219, 30);
            this.AddLabel.TabIndex = 0;
            this.AddLabel.Text = "Add New Staff";
            this.AddLabel.UseVisualStyleBackColor = false;
            this.AddLabel.Click += new System.EventHandler(this.AddLabel_Click);
            // 
            // ModifyLabel
            // 
            this.ModifyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ModifyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyLabel.Location = new System.Drawing.Point(245, 159);
            this.ModifyLabel.Name = "ModifyLabel";
            this.ModifyLabel.Size = new System.Drawing.Size(219, 30);
            this.ModifyLabel.TabIndex = 1;
            this.ModifyLabel.Text = "Modify Staff Details";
            this.ModifyLabel.UseVisualStyleBackColor = false;
            this.ModifyLabel.Click += new System.EventHandler(this.ModifyLabel_Click);
            // 
            // ViewLable
            // 
            this.ViewLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ViewLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewLable.Location = new System.Drawing.Point(245, 229);
            this.ViewLable.Name = "ViewLable";
            this.ViewLable.Size = new System.Drawing.Size(219, 30);
            this.ViewLable.TabIndex = 2;
            this.ViewLable.Text = "View Current Staff Info";
            this.ViewLable.UseVisualStyleBackColor = false;
            this.ViewLable.Click += new System.EventHandler(this.ViewLable_Click);
            // 
            // SalaryDetailsLable
            // 
            this.SalaryDetailsLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SalaryDetailsLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryDetailsLable.Location = new System.Drawing.Point(245, 296);
            this.SalaryDetailsLable.Name = "SalaryDetailsLable";
            this.SalaryDetailsLable.Size = new System.Drawing.Size(219, 30);
            this.SalaryDetailsLable.TabIndex = 3;
            this.SalaryDetailsLable.Text = "Salary Details";
            this.SalaryDetailsLable.UseVisualStyleBackColor = false;
            this.SalaryDetailsLable.Click += new System.EventHandler(this.SalaryDetailsLable_Click);
            // 
            // ClickLable
            // 
            this.ClickLable.AutoSize = true;
            this.ClickLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickLable.Location = new System.Drawing.Point(314, 60);
            this.ClickLable.Name = "ClickLable";
            this.ClickLable.Size = new System.Drawing.Size(69, 20);
            this.ClickLable.TabIndex = 4;
            this.ClickLable.Text = "Click on";
            this.ClickLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // BackLabel1
            // 
            this.BackLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackLabel1.Location = new System.Drawing.Point(138, 375);
            this.BackLabel1.Name = "BackLabel1";
            this.BackLabel1.Size = new System.Drawing.Size(75, 23);
            this.BackLabel1.TabIndex = 5;
            this.BackLabel1.Text = "Back";
            this.BackLabel1.UseVisualStyleBackColor = false;
            this.BackLabel1.Click += new System.EventHandler(this.BackLabel1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 443);
            this.Controls.Add(this.BackLabel1);
            this.Controls.Add(this.ClickLable);
            this.Controls.Add(this.SalaryDetailsLable);
            this.Controls.Add(this.ViewLable);
            this.Controls.Add(this.ModifyLabel);
            this.Controls.Add(this.AddLabel);
            this.Name = "Form2";
            this.Text = "Features";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddLabel;
        private System.Windows.Forms.Button ModifyLabel;
        private System.Windows.Forms.Button ViewLable;
        private System.Windows.Forms.Button SalaryDetailsLable;
        private System.Windows.Forms.Label ClickLable;
        private System.Windows.Forms.Button BackLabel1;
    }
}