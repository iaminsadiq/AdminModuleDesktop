namespace AdminModule
{
    partial class Courses
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
            this.coursename_label = new System.Windows.Forms.Label();
            this.courname_text = new System.Windows.Forms.TextBox();
            this.coursecode_label = new System.Windows.Forms.Label();
            this.coursecode_txt = new System.Windows.Forms.TextBox();
            this.coursename_error = new System.Windows.Forms.Label();
            this.coursecode_error = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SnoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursenameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursecodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(240, 580);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.coursecode_txt);
            this.panel6.Controls.Add(this.coursecode_label);
            this.panel6.Controls.Add(this.courname_text);
            this.panel6.Controls.Add(this.coursename_label);
            this.panel6.Controls.Add(this.coursename_error);
            this.panel6.Controls.Add(this.coursecode_error);
            this.panel6.Size = new System.Drawing.Size(240, 543);
            this.panel6.Controls.SetChildIndex(this.coursecode_error, 0);
            this.panel6.Controls.SetChildIndex(this.coursename_error, 0);
            this.panel6.Controls.SetChildIndex(this.coursename_label, 0);
            this.panel6.Controls.SetChildIndex(this.courname_text, 0);
            this.panel6.Controls.SetChildIndex(this.coursecode_label, 0);
            this.panel6.Controls.SetChildIndex(this.coursecode_txt, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(824, 580);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Size = new System.Drawing.Size(824, 543);
            this.panel5.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // coursename_label
            // 
            this.coursename_label.AutoSize = true;
            this.coursename_label.Location = new System.Drawing.Point(19, 138);
            this.coursename_label.Name = "coursename_label";
            this.coursename_label.Size = new System.Drawing.Size(79, 14);
            this.coursename_label.TabIndex = 1;
            this.coursename_label.Text = "Course Name";
            // 
            // courname_text
            // 
            this.courname_text.Enabled = false;
            this.courname_text.Location = new System.Drawing.Point(22, 155);
            this.courname_text.Name = "courname_text";
            this.courname_text.Size = new System.Drawing.Size(198, 22);
            this.courname_text.TabIndex = 2;
            this.courname_text.TextChanged += new System.EventHandler(this.courname_text_TextChanged);
            // 
            // coursecode_label
            // 
            this.coursecode_label.AutoSize = true;
            this.coursecode_label.Location = new System.Drawing.Point(19, 205);
            this.coursecode_label.Name = "coursecode_label";
            this.coursecode_label.Size = new System.Drawing.Size(76, 14);
            this.coursecode_label.TabIndex = 3;
            this.coursecode_label.Text = "Course Code";
            // 
            // coursecode_txt
            // 
            this.coursecode_txt.Enabled = false;
            this.coursecode_txt.Location = new System.Drawing.Point(22, 222);
            this.coursecode_txt.MaxLength = 5;
            this.coursecode_txt.Name = "coursecode_txt";
            this.coursecode_txt.Size = new System.Drawing.Size(198, 22);
            this.coursecode_txt.TabIndex = 4;
            this.coursecode_txt.TextChanged += new System.EventHandler(this.coursecode_txt_TextChanged);
            // 
            // coursename_error
            // 
            this.coursename_error.AutoSize = true;
            this.coursename_error.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursename_error.Location = new System.Drawing.Point(200, 138);
            this.coursename_error.Name = "coursename_error";
            this.coursename_error.Size = new System.Drawing.Size(20, 23);
            this.coursename_error.TabIndex = 5;
            this.coursename_error.Text = "*";
            this.coursename_error.Visible = false;
            // 
            // coursecode_error
            // 
            this.coursecode_error.AutoSize = true;
            this.coursecode_error.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursecode_error.Location = new System.Drawing.Point(200, 205);
            this.coursecode_error.Name = "coursecode_error";
            this.coursecode_error.Size = new System.Drawing.Size(20, 23);
            this.coursecode_error.TabIndex = 6;
            this.coursecode_error.Text = "*";
            this.coursecode_error.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(824, 491);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SnoGV,
            this.courseIDGV,
            this.coursenameGV,
            this.coursecodeGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(818, 470);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SnoGV
            // 
            this.SnoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SnoGV.HeaderText = "SNO";
            this.SnoGV.Name = "SnoGV";
            this.SnoGV.ReadOnly = true;
            this.SnoGV.Width = 56;
            // 
            // courseIDGV
            // 
            this.courseIDGV.HeaderText = "Course ID";
            this.courseIDGV.Name = "courseIDGV";
            this.courseIDGV.ReadOnly = true;
            this.courseIDGV.Visible = false;
            // 
            // coursenameGV
            // 
            this.coursenameGV.HeaderText = "Course Name";
            this.coursenameGV.Name = "coursenameGV";
            this.coursenameGV.ReadOnly = true;
            // 
            // coursecodeGV
            // 
            this.coursecodeGV.HeaderText = "Course Code";
            this.coursecodeGV.Name = "coursecodeGV";
            this.coursecodeGV.ReadOnly = true;
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 580);
            this.Name = "Courses";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.Courses_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label coursename_label;
        private System.Windows.Forms.TextBox coursecode_txt;
        private System.Windows.Forms.Label coursecode_label;
        private System.Windows.Forms.TextBox courname_text;
        private System.Windows.Forms.Label coursename_error;
        private System.Windows.Forms.Label coursecode_error;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursecodeGV;
    }
}