namespace AdminModule
{
    partial class Roles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.roleTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rolesIDGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SnoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.roleError = new System.Windows.Forms.Label();
            this.statusError = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(240, 579);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.statusError);
            this.panel6.Controls.Add(this.statusDD);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.roleTxt);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.roleError);
            this.panel6.Size = new System.Drawing.Size(240, 542);
            this.panel6.Controls.SetChildIndex(this.roleError, 0);
            this.panel6.Controls.SetChildIndex(this.label2, 0);
            this.panel6.Controls.SetChildIndex(this.roleTxt, 0);
            this.panel6.Controls.SetChildIndex(this.label3, 0);
            this.panel6.Controls.SetChildIndex(this.statusDD, 0);
            this.panel6.Controls.SetChildIndex(this.statusError, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(824, 579);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Size = new System.Drawing.Size(824, 542);
            this.panel5.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Role";
            // 
            // roleTxt
            // 
            this.roleTxt.Location = new System.Drawing.Point(12, 94);
            this.roleTxt.Name = "roleTxt";
            this.roleTxt.Size = new System.Drawing.Size(218, 22);
            this.roleTxt.TabIndex = 2;
            this.roleTxt.TextChanged += new System.EventHandler(this.roleTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status";
            // 
            // statusDD
            // 
            this.statusDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.statusDD.Location = new System.Drawing.Point(12, 154);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(218, 22);
            this.statusDD.TabIndex = 4;
            this.statusDD.SelectedIndexChanged += new System.EventHandler(this.statusDropdown_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rolesIDGv,
            this.SnoGV,
            this.RoleGV,
            this.StatusGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(818, 469);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // rolesIDGv
            // 
            this.rolesIDGv.HeaderText = "Role ID";
            this.rolesIDGv.Name = "rolesIDGv";
            this.rolesIDGv.ReadOnly = true;
            this.rolesIDGv.Visible = false;
            // 
            // SnoGV
            // 
            this.SnoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SnoGV.HeaderText = "SNO";
            this.SnoGV.Name = "SnoGV";
            this.SnoGV.ReadOnly = true;
            this.SnoGV.Width = 56;
            // 
            // RoleGV
            // 
            this.RoleGV.HeaderText = "Role";
            this.RoleGV.Name = "RoleGV";
            this.RoleGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(824, 490);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // roleError
            // 
            this.roleError.AutoSize = true;
            this.roleError.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleError.Location = new System.Drawing.Point(213, 70);
            this.roleError.Name = "roleError";
            this.roleError.Size = new System.Drawing.Size(21, 24);
            this.roleError.TabIndex = 5;
            this.roleError.Text = "*";
            this.roleError.Visible = false;
            // 
            // statusError
            // 
            this.statusError.AutoSize = true;
            this.statusError.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusError.Location = new System.Drawing.Point(213, 129);
            this.statusError.Name = "statusError";
            this.statusError.Size = new System.Drawing.Size(21, 24);
            this.statusError.TabIndex = 6;
            this.statusError.Text = "*";
            this.statusError.Visible = false;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 579);
            this.Name = "Roles";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.Roles_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox roleTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolesIDGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
        private System.Windows.Forms.Label statusError;
        private System.Windows.Forms.Label roleError;
    }
}