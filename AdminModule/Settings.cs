using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminModule
{
    public partial class Settings : GlobalWeb
    {
        public Settings()
        {
            InitializeComponent();
        }
        MainClass main = new MainClass();

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(dataSourcetxt.Text == ""){dataSourceError.Visible = true;}else{dataSourceError.Visible = false;}
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dBtxt_TextChanged(object sender, EventArgs e)
        {
            if (dBtxt.Text == ""){dbError.Visible = true;}else{dbError.Visible = false;}
        }

        private void userNametxt_TextChanged(object sender, EventArgs e)
        {
            if (userNametxt.Text == ""){ usernameError.Visible = true; }else{usernameError.Visible = false;}
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (passwordTxt.Text == ""){passwordError.Visible = true;}else{passwordError.Visible = false;}

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (isCB.Checked)
            {
                if (dataSourcetxt.Text == "") { dataSourceError.Visible = true; } else { dataSourceError.Visible = false; }
                if (dBtxt.Text == "") { dbError.Visible = true; } else { dbError.Visible = false; }
                if(dataSourceError.Visible || dbError.Visible)
                {
                    MessageBox.Show("Fields with * are required");
                }
                else
                {
                    sb.Append("Data Source=" + dataSourcetxt.Text + ","+"Initial Category="+dBtxt.Text+","+"Integrated Security=true;MultipleActiveResultSets=true");
                    File.WriteAllText(main.path + "\\connect", sb.ToString());
                    DialogResult dr = MessageBox.Show("Settings Save Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        main.showWindow(new Login(), this, MultiDocInterface.ActiveForm);
                    }
                 
                }
                //if (userNametxt.Text == "") { usernameError.Visible = true; } else { usernameError.Visible = false; }
                //if (passwordTxt.Text == "") { passwordError.Visible = true; } else { passwordError.Visible = false; }
            }
            else
            {
                if (dataSourcetxt.Text == "") { dataSourceError.Visible = true; } else { dataSourceError.Visible = false; }
                if (dBtxt.Text == "") { dbError.Visible = true; } else { dbError.Visible = false; }
                if (userNametxt.Text == "") { usernameError.Visible = true; } else { usernameError.Visible = false; }
                if (passwordTxt.Text == "") { passwordError.Visible = true; } else { passwordError.Visible = false; }
                if (dataSourceError.Visible || dbError.Visible)
                {
                    MessageBox.Show("Fields with * are required");
                }
                else
                {
                    sb.Append("Data Source=" + dataSourcetxt.Text + "," + "Initial Category=" + dBtxt.Text + "," + "User ID="+userNametxt.Text+";Password="+passwordTxt.Text+ ";MultipleActiveResultSets=true");
                    File.WriteAllText(main.path + "\\connect", sb.ToString());
                    DialogResult dr = MessageBox.Show("Settings Save Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        main.showWindow(new Login(), this, MultiDocInterface.ActiveForm);
                    }
                }

            }
        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                userNametxt.Text = "";
                userNametxt.Enabled = false;
                usernameError.Visible = false;

                passwordTxt.Text = "";
                passwordTxt.Enabled = false;
                passwordError.Visible = false;
            }
            else
            {
                //userNametxt.Text = "";
                userNametxt.Enabled = true;

                //passwordTxt.Text = "";
                passwordTxt.Enabled = true;
            }
        }
    }
}
