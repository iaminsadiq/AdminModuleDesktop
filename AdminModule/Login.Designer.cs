namespace AdminModule
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.username_error = new System.Windows.Forms.Label();
            this.password_error = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.loginBtn);
            this.panel6.Controls.Add(this.password_txt);
            this.panel6.Controls.Add(this.username_txt);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.username_error);
            this.panel6.Controls.Add(this.password_error);
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(23, 169);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(194, 22);
            this.username_txt.TabIndex = 2;
            this.username_txt.TextChanged += new System.EventHandler(this.username_txt_TextChanged);
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(23, 235);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(194, 22);
            this.password_txt.TabIndex = 3;
            this.password_txt.UseSystemPasswordChar = true;
            this.password_txt.TextChanged += new System.EventHandler(this.password_txt_TextChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.FlatAppearance.BorderSize = 2;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Location = new System.Drawing.Point(23, 278);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(194, 35);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // username_error
            // 
            this.username_error.AutoSize = true;
            this.username_error.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_error.Location = new System.Drawing.Point(197, 149);
            this.username_error.Name = "username_error";
            this.username_error.Size = new System.Drawing.Size(20, 23);
            this.username_error.TabIndex = 5;
            this.username_error.Text = "*";
            this.username_error.Visible = false;
            // 
            // password_error
            // 
            this.password_error.AutoSize = true;
            this.password_error.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_error.Location = new System.Drawing.Point(197, 218);
            this.password_error.Name = "password_error";
            this.password_error.Size = new System.Drawing.Size(20, 23);
            this.password_error.TabIndex = 6;
            this.password_error.Text = "*";
            this.password_error.Visible = false;
            // 
            // Login
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 401);
            this.ControlBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username_error;
        private System.Windows.Forms.Label password_error;
    }
}