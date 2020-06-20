using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminModule
{
    public partial class Courses : GlobalSample2
    {
        public Courses()
        {
            InitializeComponent();
        }
        int edit = 0;
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
            if (courname_text.Text == "") { coursename_error.Visible = true; } else { coursename_error.Visible = false; }
            if (coursecode_txt.Text == "") { coursecode_error.Visible = true; } else { coursecode_error.Visible = false; }
            
            if(coursecode_error.Visible || coursename_error.Visible)
            {
                MainClass.ShowMSG("Field with * are required", "Sorry.....", "Error");

            }
            else
            {
                if(edit == 0) // add
                {
                    try
                    {
                        ////obj.co_insertCourse(courname_text.Text, coursecode_txt.Text);
                        //obj.SubmitChanges();
                        addData();
                        MainClass.ShowMSG(coursecode_txt.Text + " Added Successfully", "Success....", "Success");
                        MainClass.disable_reset(panel6);
                        loadData();
                    }
                    catch(Exception ex)
                    {
                        MainClass.ShowMSG("You are adding the Course Code which is already Exist!\nContact the Technical Department", "Error", "Error");

                    }


                }
                else if (edit == 1) // update
                {
                    try
                    {
                       //// obj.co_updateCourse(courname_text.Text, coursecode_txt.Text, CourseID);
                       // obj.SubmitChanges();

                        MainClass.ShowMSG(courname_text.Text + " Updated Successfully", "Success....", "Success");
                        MainClass.disable_reset(panel6);
                        loadData();
                    }
                    catch (Exception ex)
                    {
                        MainClass.ShowMSG("You are updating the Course Code which is already Exist!\nContact the Technical Department", "Error", "Error");
                    }
                    
                }
            }

        }
        public async void addData()
        {
            List<coursesstn> course = new List<coursesstn>();
            course.Add(new coursesstn { CourseName = courname_text.Text, CourseCode = coursecode_txt.Text });
            var json = JsonConvert.SerializeObject(course);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44380/api/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage result = await client.PostAsync("admin/AddCourse/", data);
                var response = result.Content.ReadAsStringAsync().Result;
            }

        }
        private void loadData()
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44380/api/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage result = client.GetAsync("admin/getCourses/").Result;
                var response = result.Content.ReadAsStringAsync().Result;
                // var result = obj.co_getCourse();

                courseIDGV.DataPropertyName = "CourseID";
                coursenameGV.DataPropertyName = "CourseName";
                coursecodeGV.DataPropertyName = "CourseCode";
                dataGridView1.DataSource = response;
                MainClass.sno(dataGridView1, "SnoGV");
            }
           
        }
        int CourseID;
        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Do you really want to delete " + courname_text.Text + "?", "Question.....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    //// obj.co_deleteCourse(CourseID);
                    // obj.SubmitChanges();
                    dataDelete();
                    MainClass.ShowMSG(courname_text.Text + " Delete Successfully", "Success.....", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                }

            }
        }
        public async void dataDelete()
        {
            var json = JsonConvert.SerializeObject(new Courses { CourseID = CourseID });
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using (var client = new HttpClient())

            {
                client.BaseAddress = new Uri("https://localhost:44380/api/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                HttpResponseMessage result = await client.PostAsync("admin/DeleteStudent/", data);
                var response = result.Content.ReadAsStringAsync().Result;
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
            var result = obj.co_searchCourse(searchTxt.Text);
            courseIDGV.DataPropertyName = "ID";
            coursenameGV.DataPropertyName = "Name";
            coursecodeGV.DataPropertyName = "Code";

            dataGridView1.DataSource = result;
            MainClass.sno(dataGridView1, "SnoGV");
        }
        private void courname_text_TextChanged(object sender, EventArgs e)
        {
            if(courname_text.Text == "") { coursename_error.Visible = true; } else { coursename_error.Visible = false; }
        }

        private void coursecode_txt_TextChanged(object sender, EventArgs e)
        {
            if(coursecode_txt.Text == "") { coursecode_error.Visible = true; } else { coursecode_error.Visible = false; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                CourseID = Convert.ToInt32(row.Cells["courseIDGV"].Value.ToString());
                courname_text.Text = row.Cells["coursenameGV"].Value.ToString();
                coursecode_txt.Text = row.Cells["coursecodeGV"].Value.ToString();
            }
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
        }
    }
}
