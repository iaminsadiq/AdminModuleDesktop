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
    public partial class Login : GlobalWeb
    {
        public Login()
        {
            InitializeComponent();
        }
        MainClass main = new MainClass();
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (password_txt.Text == "") { password_error.Visible = true; } else { password_error.Visible = false; }
            if (username_txt.Text == "") { username_error.Visible = true; } else { username_error.Visible = false; }
            if (username_error.Visible || password_error.Visible)
            {
                MainClass.ShowMSG("Field with * are required", "Sorry.....", "Error");
            }
            else
            {
                if (main.getFacultyLogin(username_txt.Text, password_txt.Text))
                {
                    if (MainClass.EMPLOYEEROLE == "Director" || MainClass.EMPLOYEEROLE == "Head of Departments" || MainClass.EMPLOYEEROLE == "Professor" || MainClass.EMPLOYEEROLE == "Associate Professor" || MainClass.EMPLOYEEROLE == "Lecturer" || MainClass.EMPLOYEEROLE == "Lab Instructor" || MainClass.EMPLOYEEROLE == "Visiting Faculty")
                    {
                        FacultyDashBoard hs = new FacultyDashBoard();
                        main.showWindow(hs, this, MultiDocInterface.ActiveForm);
                    }
                    else if (MainClass.EMPLOYEEROLE == "Admin" || MainClass.EMPLOYEEROLE == "Manager Academics")
                    {
                        HomeScreen hs = new HomeScreen();
                        main.showWindow(hs, this, MultiDocInterface.ActiveForm);
                    }
                    else
                    {
                        MainClass.ShowMSG("Invalid Login Details", "Error.....", "Error");
                    }
                    
                }
                else
                {
                    MainClass.ShowMSG("Invalid Login Details", "Error.....", "Error");
                }

            }


        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {
            if(password_txt.Text == "") { password_error.Visible = true; } else { password_error.Visible = false; }
        }

        private void username_txt_TextChanged(object sender, EventArgs e)
        {
            if(username_txt.Text == "") { username_error.Visible = true; } else { username_error.Visible = false; }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MultiDocInterface obj = new MultiDocInterface();
            obj.logoutToolStripMenuItem.Enabled = false;
        }
    }
}
