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
    public partial class Roles : GlobalSample2
    {
        public Roles()
        {
            InitializeComponent();
        }
        int edit = 0;
        adminDBDataContext obj = new adminDBDataContext();
        public void statusDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(statusDD.SelectedIndex == -1){ statusError.Visible = true; } else { statusError.Visible = false; }
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.enable_reset(panel6);
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(panel6);
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (roleTxt.Text == "") { roleError.Visible = true; } else { roleError.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statusError.Visible = true; } else { statusError.Visible = false; }

            if(roleError.Visible || statusError.Visible)
            {
                MainClass.ShowMSG("fields with * are required", "Sorry....","Error");
            }
            else
            {
                if(edit == 0) /// code for save
                {
                   
                    //role r = new role();
                    //r.r_name = roleTxt.Text;
                    //if (statusDD.SelectedIndex == 0)
                    //{
                    //    r.r_status = 1;
                    //}else 
                    //{
                    //    r.r_status = 0;
                    //}
                    ////obj.roles.InsertOnSubmit(r);
                    ////obj.fa_insertRoles(roleTxt.Text, r.r_status);
                    //obj.SubmitChanges();
                    //MainClass.ShowMSG(roleTxt.Text + " Added Successfully","Success.....","Success");
                    //MainClass.disable_reset(panel6);
                    //data_load();
                }
                else if(edit == 1)// code for edit
                {
                    //var data = obj.roles.Single(x => x.r_id == roleID);
                    //data.r_name = roleTxt.Text;
                    //if (statusDD.SelectedIndex == 0)
                    //{
                    //    data.r_status = 1;
                    //}
                    //else
                    //{
                    //    data.r_status = 0;
                    //}
                    //obj.SubmitChanges();
                    //MainClass.ShowMSG(roleTxt.Text + " Update Successfully", "Success.....", "Success");
                    //MainClass.disable_reset(panel6);
                    //data_load();
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if(edit == 1 || edit == 0)
            {
                DialogResult dr = MessageBox.Show("Do you really want to delete " + roleTxt.Text + "?", "Question.....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    //obj.fa_deleteRoles(roleID);
                    obj.SubmitChanges();
                    MainClass.ShowMSG(roleTxt.Text + " Delete Successfully", "Success.....", "Success");
                    MainClass.disable_reset(panel6);
                    data_load();
                }
               
            } 
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            data_load();
        }
        public  void data_search()
        {
            //var result = obj.fa_searchRoles(searchTxt.Text);
            rolesIDGv.DataPropertyName = "ID";
            RoleGV.DataPropertyName = "Role";
            StatusGV.DataPropertyName = "Status";

            //dataGridView1.DataSource = result;
            MainClass.sno(dataGridView1, "SnoGV");
        }
        protected override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            data_search();
        }
        public void data_load()
        {
            //var result = obj.fa_getRoles();
            rolesIDGv.DataPropertyName = "ID";
            RoleGV.DataPropertyName = "Role";
            StatusGV.DataPropertyName = "Status";

            //dataGridView1.DataSource = result;
            MainClass.sno(dataGridView1, "SnoGV");
        }
        public void Roles_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
        }

        public void roleTxt_TextChanged(object sender, EventArgs e)
        {
            if(roleTxt.Text == "") { roleError.Visible = true; } else { roleError.Visible = false; }
        }
        int roleID;
        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                roleID = Convert.ToInt32(row.Cells["rolesIDGv"].Value.ToString());
                roleTxt.Text = row.Cells["RoleGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();

            }
        }
    }
}
