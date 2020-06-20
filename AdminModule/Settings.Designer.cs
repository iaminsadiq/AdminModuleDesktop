namespace AdminModule
{
    partial class Settings
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
            this.dBtxt = new System.Windows.Forms.TextBox();
            this.userNametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataSourcetxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.isCB = new System.Windows.Forms.CheckBox();
            this.dataSourceError = new System.Windows.Forms.Label();
            this.dbError = new System.Windows.Forms.Label();
            this.usernameError = new System.Windows.Forms.Label();
            this.passwordError = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(240, 617);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.isCB);
            this.panel6.Controls.Add(this.saveBtn);
            this.panel6.Controls.Add(this.passwordTxt);
            this.panel6.Controls.Add(this.userNametxt);
            this.panel6.Controls.Add(this.dataSourcetxt);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.dBtxt);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.dataSourceError);
            this.panel6.Controls.Add(this.dbError);
            this.panel6.Controls.Add(this.usernameError);
            this.panel6.Controls.Add(this.passwordError);
            this.panel6.Size = new System.Drawing.Size(240, 577);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(724, 617);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(724, 577);
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(724, 40);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // dBtxt
            // 
            this.dBtxt.Location = new System.Drawing.Point(23, 207);
            this.dBtxt.Name = "dBtxt";
            this.dBtxt.Size = new System.Drawing.Size(191, 23);
            this.dBtxt.TabIndex = 2;
            this.dBtxt.TextChanged += new System.EventHandler(this.dBtxt_TextChanged);
            // 
            // userNametxt
            // 
            this.userNametxt.Location = new System.Drawing.Point(23, 279);
            this.userNametxt.Name = "userNametxt";
            this.userNametxt.Size = new System.Drawing.Size(191, 23);
            this.userNametxt.TabIndex = 3;
            this.userNametxt.TextChanged += new System.EventHandler(this.userNametxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data Source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // dataSourcetxt
            // 
            this.dataSourcetxt.Location = new System.Drawing.Point(23, 145);
            this.dataSourcetxt.Name = "dataSourcetxt";
            this.dataSourcetxt.Size = new System.Drawing.Size(191, 23);
            this.dataSourcetxt.TabIndex = 1;
            this.dataSourcetxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(23, 341);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(191, 23);
            this.passwordTxt.TabIndex = 4;
            this.passwordTxt.UseSystemPasswordChar = true;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(23, 416);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(191, 38);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "&Save ";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // isCB
            // 
            this.isCB.AutoSize = true;
            this.isCB.Location = new System.Drawing.Point(23, 381);
            this.isCB.Name = "isCB";
            this.isCB.Size = new System.Drawing.Size(143, 19);
            this.isCB.TabIndex = 5;
            this.isCB.Text = "DB Integrated Security";
            this.isCB.UseVisualStyleBackColor = true;
            this.isCB.CheckedChanged += new System.EventHandler(this.isCB_CheckedChanged);
            // 
            // dataSourceError
            // 
            this.dataSourceError.AutoSize = true;
            this.dataSourceError.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataSourceError.Location = new System.Drawing.Point(201, 112);
            this.dataSourceError.Name = "dataSourceError";
            this.dataSourceError.Size = new System.Drawing.Size(22, 30);
            this.dataSourceError.TabIndex = 7;
            this.dataSourceError.Text = "*";
            this.dataSourceError.Visible = false;
            this.dataSourceError.Click += new System.EventHandler(this.label5_Click);
            // 
            // dbError
            // 
            this.dbError.AutoSize = true;
            this.dbError.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbError.Location = new System.Drawing.Point(201, 180);
            this.dbError.Name = "dbError";
            this.dbError.Size = new System.Drawing.Size(22, 30);
            this.dbError.TabIndex = 8;
            this.dbError.Text = "*";
            this.dbError.Visible = false;
            // 
            // usernameError
            // 
            this.usernameError.AutoSize = true;
            this.usernameError.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameError.Location = new System.Drawing.Point(201, 251);
            this.usernameError.Name = "usernameError";
            this.usernameError.Size = new System.Drawing.Size(22, 30);
            this.usernameError.TabIndex = 9;
            this.usernameError.Text = "*";
            this.usernameError.Visible = false;
            // 
            // passwordError
            // 
            this.passwordError.AutoSize = true;
            this.passwordError.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordError.Location = new System.Drawing.Point(201, 314);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(22, 30);
            this.passwordError.TabIndex = 10;
            this.passwordError.Text = "*";
            this.passwordError.Visible = false;
            // 
            // Settings
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 617);
            this.ControlBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.leftPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox userNametxt;
        private System.Windows.Forms.TextBox dataSourcetxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dBtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox isCB;
        private System.Windows.Forms.Label dataSourceError;
        private System.Windows.Forms.Label dbError;
        private System.Windows.Forms.Label usernameError;
        private System.Windows.Forms.Label passwordError;
    }
}