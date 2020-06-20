using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminModule
{
    public partial class Students : GlobalSample2
    {
        public Students()
        {
            InitializeComponent();
        }
        int edit = 0;
        int studentID;
        adminDBDataContext obj = new adminDBDataContext();
        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(panel6);
            edit = 0;
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(panel6);
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (sName_txt.Text == "") { sName_error.Visible = true; } else { sName_error.Visible = false; }
            if (sEmail_txt.Text == "") { sEmail_error.Visible = true; } else { sEmail_error.Visible = false; }
            if (sMobileNum_txt.Text == "") { sMobileNum_error.Visible = true; } else { sMobileNum_error.Visible = false; }
            if (sRollNumber_txt.Text == "") { sRollNum_error.Visible = true; } else { sRollNum_error.Visible = false; }
            if (spassword_txt.Text == "") { sPassword_error.Visible = true; } else { sPassword_error.Visible = false; }
            if (cpass_txt.Text == "") { cpass_error.Visible = true; } else { cpass_error.Visible = false; }
            if (sbatchDD.SelectedIndex == -1) { sBatch_error.Visible = true; } else { sBatch_error.Visible = false; }
            if (sdepartDD.SelectedIndex == -1) { sDepart_error.Visible = true; } else { sDepart_error.Visible = false; }

            if(sName_error.Visible || sEmail_error.Visible || sMobileNum_error.Visible || sRollNum_error.Visible || sPassword_error.Visible || sBatch_error.Visible || sDepart_error.Visible || cpass_error.Visible)
            {
                MainClass.ShowMSG("Field with * are required", "Sorry.....", "Error");
            }
            else
            {
                if(edit == 0) /////////// add
                {
                    //obj.st_insertStudent(sName_txt.Text, sEmail_txt.Text, sMobileNum_txt.Text, sRollNumber_txt.Text, spassword_txt.Text, Convert.ToInt32(sbatchDD.SelectedValue.ToString()), Convert.ToInt32(sdepartDD.SelectedValue.ToString()));
                    obj.SubmitChanges();
                    MainClass.ShowMSG(sName_txt.Text + " Added Successfully", "Success....", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                }
                else if(edit == 1) ////////// update
                {
                   // obj.st_updateStudent(sName_txt.Text, sEmail_txt.Text, sMobileNum_txt.Text, sRollNumber_txt.Text, spassword_txt.Text, Convert.ToInt32(sbatchDD.SelectedValue.ToString()), Convert.ToInt32(sdepartDD.SelectedValue.ToString()), studentID);
                    obj.SubmitChanges();
                    MainClass.ShowMSG(sName_txt.Text + " Updated Successfully", "Success....", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Do you really want to delete " + sName_txt.Text + "?", "Question.....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    //obj.st_deleteStudent(studentID);
                    obj.SubmitChanges();
                    MainClass.ShowMSG(sName_txt.Text + " Delete Successfully", "Success.....", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                }

            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            //var result = obj.st_getStudent();
            sidGV.DataPropertyName = "ID";
            snameGV.DataPropertyName = "Name";
            semailGV.DataPropertyName = "Email";
            spassGV.DataPropertyName = "Password";
            smobilenumGV.DataPropertyName = "MobNum";
            srollnumGV.DataPropertyName = "RollNum";
            batchidGV.DataPropertyName = "BatchID";
            sbatchGV.DataPropertyName = "BatchYr";
            progidGV.DataPropertyName = "ProgID";
            sprogramGV.DataPropertyName = "ProgName";
            //dataGridView1.DataSource = result;
            MainClass.sno(dataGridView1, "SnoGV");
        }
        protected override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            data_search();
        }
        public void data_search()
        {
            //var result = obj.st_searchStudent(searchTxt.Text);
            sidGV.DataPropertyName = "ID";
            snameGV.DataPropertyName = "Name";
            semailGV.DataPropertyName = "Email";
            spassGV.DataPropertyName = "Password";
            smobilenumGV.DataPropertyName = "MobNum";
            srollnumGV.DataPropertyName = "RollNum";
            batchidGV.DataPropertyName = "BatchID";
            sbatchGV.DataPropertyName = "BatchYr";
            progidGV.DataPropertyName = "ProgID";
            sprogramGV.DataPropertyName = "ProgName";
            //dataGridView1.DataSource = result;
            MainClass.sno(dataGridView1, "SnoGV");

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void sName_txt_TextChanged(object sender, EventArgs e)
        {
            if(sName_txt.Text == "") { sName_error.Visible = true; } else { sName_error.Visible = false; }
        }

        private void sEmail_txt_TextChanged(object sender, EventArgs e)
        {
            if(sEmail_txt.Text == "") { sEmail_error.Visible = true; } else { sEmail_error.Visible = false; }
        }

        private void sMobileNum_txt_TextChanged(object sender, EventArgs e)
        {
            if(sMobileNum_txt.Text == "") { sMobileNum_error.Visible = true; } else { sMobileNum_error.Visible = false; }
        }

        private void sRollNumber_txt_TextChanged(object sender, EventArgs e)
        {
            if(sRollNumber_txt.Text == "") { sRollNum_error.Visible = true; } else { sRollNum_error.Visible = false; }
        }

        private void spassword_txt_TextChanged(object sender, EventArgs e)
        {
            if(spassword_txt.Text == "") { sPassword_error.Visible = true; } else { sPassword_error.Visible = false; }
        }

        private void sbatchDD_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sbatchDD.SelectedIndex == -1) { sBatch_error.Visible = true; } else { sBatch_error.Visible = false; }
        }

        private void sdepartDD_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sdepartDD.SelectedIndex == -1) { sDepart_error.Visible = true; } else { sDepart_error.Visible = false; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void loadList()
        {
            var list_result = (from s in obj.Batches select new { s.BatchID, s.BatchYear }).ToList();
            list_result.Insert(0, new { BatchID = 0, BatchYear = 0});
            sbatchDD.DataSource = list_result;
            sbatchDD.DisplayMember = "BatchYear";
            sbatchDD.ValueMember = "BatchID";

        }
        public void loadList1()
        {
            var list_result = (from s in obj.Programmes select new { s.ProgrammeID, s.ProgrammeName }).ToList();
            list_result.Insert(0, new { ProgrammeID = 0, ProgrammeName = "Select" });
            sdepartDD.DataSource = list_result;
            sdepartDD.DisplayMember = "ProgrammeName";
            sdepartDD.ValueMember = "ProgrammeID";

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                studentID = Convert.ToInt32(row.Cells["sidGV"].Value.ToString());
                sName_txt.Text = row.Cells["snameGV"].Value.ToString();
                sEmail_txt.Text = row.Cells["semailGV"].Value.ToString();
                spassword_txt.Text = row.Cells["spassGV"].Value.ToString();
                sMobileNum_txt.Text = row.Cells["smobilenumGV"].Value.ToString();
                sRollNumber_txt.Text = row.Cells["srollnumGV"].Value.ToString();
                sbatchDD.SelectedValue = row.Cells["batchidGV"].Value;
                sdepartDD.SelectedValue = row.Cells["progidGV"].Value;

            }
        }

        private void Students_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
            loadList();
            loadList1();
        }

        private void cpass_txt_TextChanged(object sender, EventArgs e)
        {
            if (cpass_txt.Text == "") { cpass_error.Visible = true; } else { cpass_error.Visible = false; }
            if (spassword_txt.Text != cpass_txt.Text) { cmismatch_Error.Visible = true; } else { cmismatch_Error.Visible = false; }
        }
    }
}
