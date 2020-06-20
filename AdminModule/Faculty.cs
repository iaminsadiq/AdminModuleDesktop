using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using System.Net.Http.Headers;


namespace AdminModule
{
    public partial class Faculty : GlobalSample2
    {
        public Faculty()
        {
            InitializeComponent();
        }
        int edit = 0;
        adminDBDataContext obj = new adminDBDataContext();
        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(panel6);
            //imageTxt.Enabled = false;
            edit = 0;
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(panel6);
            //imageTxt.Enabled = false;
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if(nameTxt.Text == "") { nameError.Visible = true; } else { nameError.Visible = false; }
            if(usernameTxt.Text == "") { usernameError.Visible = true; } else { usernameError.Visible = false; }
            if(passwordTxt.Text == "") { passwordError.Visible = true; } else { passwordError.Visible = false; }
            if(cpasswordTxt.Text == "") { cpasswordError.Visible = true; } else { cpasswordError.Visible = false; }
            if(cnTxt.Text == "") { cnError.Visible = true; } else { cnError.Visible = false; }
            if(roleDD.SelectedIndex == -1) { roleError.Visible = true; } else { roleError.Visible = false; }
            if (departDD.SelectedIndex == -1) { departDD_error.Visible = true; } else { departDD_error.Visible = false; }
            //if(statusDD.SelectedIndex == -1) { statusError.Visible = true; } else { statusError.Visible = false; }

            if (nameError.Visible || usernameError.Visible || passwordError.Visible || cpasswordError.Visible || cnError.Visible || roleError.Visible || departDD_error.Visible)
            {
                MainClass.ShowMSG("Field with * are required", "Sorry.....", "Error");
            }
            else
            {
                if(edit == 0)//////////////// for save
                {
                    
                        //obj.fa_insertFacultyWithoutImage(nameTxt.Text,usernameTxt.Text,passwordTxt.Text,cnTxt.Text,Convert.ToInt32(roleDD.SelectedValue.ToString()));
                        obj.SubmitChanges();
                        MainClass.ShowMSG(nameTxt.Text + " Added Successfully", "Success....", "Success");
                        MainClass.disable_reset(panel6);
                        loadData();
                   
                
                }
                else if(edit == 1)//////////// for modification /update
                {
                    
                        //obj.fa_updateFacultyWithoutImage(nameTxt.Text, usernameTxt.Text, passwordTxt.Text, cnTxt.Text, Convert.ToInt32(roleDD.SelectedValue.ToString()),facultyID);
                        obj.SubmitChanges();
                        MainClass.ShowMSG(nameTxt.Text + " Updated Successfully", "Success....", "Success");
                        MainClass.disable_reset(panel6);
                        loadData();
                   
                }
            }
        }
        public async void loadData()
        {
            //var result = obj.fa_getFacultyDetails();
            IEnumerable<employees> empList;
            //List<faculties> empList = new List<faculties>();
            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("https://localhost:44380/api/");
            //    client.DefaultRequestHeaders.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //    HttpResponseMessage response = await client.GetAsync("admin/getFaculties/").Result;
            //    empList = response.Content.ReadAsAsync<IEnumerable<employees>>().Result;


            //}
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44380/api/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage result = client.GetAsync("admin/getFaculties/").Result;
                var response = result.Content.ReadAsStringAsync().Result;


                useridGV.DataPropertyName = "EmpID";
                nameGV.DataPropertyName = "EmpName";
                usernameGV.DataPropertyName = "Email";
                passwordGV.DataPropertyName = "EPassword";
                cnGV.DataPropertyName = "MobileNumber";
                roleGV.DataPropertyName = "DesignationTitle";
                roleidGV.DataPropertyName = "DesignationID";
                departGV.DataPropertyName = "DepartmentName";
                departidGV.DataPropertyName = "DepartmentID";
                dataGridView1.DataSource = response;
                MainClass.sno(dataGridView1, "SnoGV");
            }




        }
        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1 )
            {
                DialogResult dr = MessageBox.Show("Do you really want to delete " + nameTxt.Text + "?", "Question.....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    //obj.fa_deleteFaculty(facultyID);
                    obj.SubmitChanges();
                    MainClass.ShowMSG(nameTxt.Text + " Delete Successfully", "Success.....", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                }

            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }

        protected override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            data_search();
        }
        public void data_search()
        {
            var result = obj.emp_searchEmployee(searchTxt.Text);
            useridGV.DataPropertyName = "EmpID";
            nameGV.DataPropertyName = "EmpName";
            cnGV.DataPropertyName = "EmpMobileNumber";
            roleGV.DataPropertyName = "EmpDesignation";
            departGV.DataPropertyName = "DepartmentName";
            dataGridView1.DataSource = result;
            MainClass.sno(dataGridView1, "SnoGV");
        }
        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (nameTxt.Text == "") { nameError.Visible = true; } else { nameError.Visible = false; }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "") { usernameError.Visible = true; } else { usernameError.Visible = false; }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (passwordTxt.Text == "") { passwordError.Visible = true; } else { passwordError.Visible = false; }
        }

        private void cpasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (cpasswordTxt.Text == "") { cpasswordError.Visible = true; } else { cpasswordError.Visible = false; }
            if (passwordTxt.Text != cpasswordTxt.Text) { mismatchError.Visible = true; } else { mismatchError.Visible = false; }
        }

        private void cnTxt_TextChanged(object sender, EventArgs e)
        {
            if (cnTxt.Text == "") { cnError.Visible = true; } else { cnError.Visible = false; }
        }

        private void roleDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleDD.SelectedIndex == -1) { roleError.Visible = true; } else { roleError.Visible = false; }



        }


      
        //Image i;
        //private void browseBtn_Click(object sender, EventArgs e)
        //{
        //    DialogResult dr =  openFileDialog1.ShowDialog();
        //    if(dr == DialogResult.OK)
        //    {
        //        i= new Bitmap(openFileDialog1.FileName);
        //        pictureBox1.Image = i;
        //        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        //        imageTxt.Text = openFileDialog1.FileName;
        //    }
        //}
        //public void con_data_dd()
        //{
        //    SqlConnection con = new SqlConnection("Data Source=DESKTOP-EIS8P32;Initial Catalog = adminpanel; Integrated Security = True");
        //    SqlCommand cmd = new SqlCommand("fa_getRole", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    roleDD.DataSource = dt;
        //    roleDD.DisplayMember = "Role";
        //    roleDD.ValueMember = "ID";
        //}
        private void Faculty_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
            //con_data_dd();
            loadList();
            loadList1();
        }
        public void loadList()
        {
            var list = (from x in obj.Designations select new {x.DesignationID,x.DesignationTitle }).ToList();
            list.Insert(0, new { DesignationID = 0, DesignationTitle = "Select" });
            roleDD.DataSource = list;
            roleDD.DisplayMember = "DesignationTitle";
            roleDD.ValueMember = "DesignationID";
        }
        public void loadList1()
        {
            var list = (from x in obj.Departments select new { x.DepartmentID, x.DepartmentName }).ToList();
            list.Insert(0, new { DepartmentID = 0, DepartmentName = "Select" });
            departDD.DataSource = list;
            departDD.DisplayMember = "DepartmentName";
            departDD.ValueMember = "DepartmentID";
        }
        int facultyID;
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                facultyID = Convert.ToInt32(row.Cells["useridGV"].Value.ToString());
                nameTxt.Text = row.Cells["nameGV"].Value.ToString();
                usernameTxt.Text = row.Cells["usernameGV"].Value.ToString();
                passwordTxt.Text = row.Cells["passwordGV"].Value.ToString();
                cpasswordTxt.Text = row.Cells["passwordGV"].Value.ToString();
                cnTxt.Text = row.Cells["cnGV"].Value.ToString();
                roleDD.SelectedValue = row.Cells["roleidGV"].Value;

               
            }
        }

        private void departDD_error_Click(object sender, EventArgs e)
        {
            if (departDD.SelectedIndex == -1) { departDD_error.Visible = true; } else { departDD_error.Visible = false; }
        }

        //private void searchTxt_TextChanged_1(object sender, EventArgs e)
        //{

        //}
    }
}
