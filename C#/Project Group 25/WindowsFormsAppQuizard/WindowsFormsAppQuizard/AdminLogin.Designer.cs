namespace WindowsFormsAppQuizard
{
    partial class AdminLogin
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
            this.lblRegistration = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoginAdmin = new System.Windows.Forms.Button();
            this.txtPasswordAdmin = new System.Windows.Forms.TextBox();
            this.lblPassworAdmin = new System.Windows.Forms.Label();
            this.txtUserEmailAdmin = new System.Windows.Forms.TextBox();
            this.lblUserEmailAdmin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblRegistration.Location = new System.Drawing.Point(136, 51);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(96, 20);
            this.lblRegistration.TabIndex = 2;
            this.lblRegistration.Text = "Admin login";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLoginAdmin);
            this.panel1.Controls.Add(this.txtPasswordAdmin);
            this.panel1.Controls.Add(this.lblPassworAdmin);
            this.panel1.Controls.Add(this.txtUserEmailAdmin);
            this.panel1.Controls.Add(this.lblUserEmailAdmin);
            this.panel1.Controls.Add(this.lblRegistration);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 303);
            this.panel1.TabIndex = 1;
            // 
            // btnLoginAdmin
            // 
            this.btnLoginAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(187)))));
            this.btnLoginAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.btnLoginAdmin.FlatAppearance.BorderSize = 3;
            this.btnLoginAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAdmin.Location = new System.Drawing.Point(125, 202);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Size = new System.Drawing.Size(150, 31);
            this.btnLoginAdmin.TabIndex = 12;
            this.btnLoginAdmin.Text = "Login";
            this.btnLoginAdmin.UseVisualStyleBackColor = false;
            this.btnLoginAdmin.Click += new System.EventHandler(this.btnLoginAdmin_Click);
            // 
            // txtPasswordAdmin
            // 
            this.txtPasswordAdmin.Location = new System.Drawing.Point(78, 156);
            this.txtPasswordAdmin.Name = "txtPasswordAdmin";
            this.txtPasswordAdmin.Size = new System.Drawing.Size(245, 20);
            this.txtPasswordAdmin.TabIndex = 9;
            this.txtPasswordAdmin.UseSystemPasswordChar = true;
            // 
            // lblPassworAdmin
            // 
            this.lblPassworAdmin.AutoSize = true;
            this.lblPassworAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassworAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblPassworAdmin.Location = new System.Drawing.Point(75, 140);
            this.lblPassworAdmin.Name = "lblPassworAdmin";
            this.lblPassworAdmin.Size = new System.Drawing.Size(53, 13);
            this.lblPassworAdmin.TabIndex = 8;
            this.lblPassworAdmin.Text = "Password";
            // 
            // txtUserEmailAdmin
            // 
            this.txtUserEmailAdmin.Location = new System.Drawing.Point(78, 108);
            this.txtUserEmailAdmin.Name = "txtUserEmailAdmin";
            this.txtUserEmailAdmin.Size = new System.Drawing.Size(245, 20);
            this.txtUserEmailAdmin.TabIndex = 7;
            // 
            // lblUserEmailAdmin
            // 
            this.lblUserEmailAdmin.AutoSize = true;
            this.lblUserEmailAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserEmailAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblUserEmailAdmin.Location = new System.Drawing.Point(75, 92);
            this.lblUserEmailAdmin.Name = "lblUserEmailAdmin";
            this.lblUserEmailAdmin.Size = new System.Drawing.Size(57, 13);
            this.lblUserEmailAdmin.TabIndex = 6;
            this.lblUserEmailAdmin.Text = "User Email";
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(417, 327);
            this.Controls.Add(this.panel1);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminLogin_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoginAdmin;
        private System.Windows.Forms.TextBox txtPasswordAdmin;
        private System.Windows.Forms.Label lblPassworAdmin;
        private System.Windows.Forms.TextBox txtUserEmailAdmin;
        private System.Windows.Forms.Label lblUserEmailAdmin;
    }
}