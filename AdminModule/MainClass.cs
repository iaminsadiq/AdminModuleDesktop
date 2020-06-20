using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminModule
{
    class MainClass
    {
        adminDBDataContext obj = new adminDBDataContext();
        public string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static int employeeID;
        private static string employeeName, employeeRole;
        private bool check_login = false;
        
        public static int EMPLOYEEID
        {
            get
            {
                return employeeID;
            }
            private set
            {
                employeeID = value;
            }
        }

        public static string EMPLOYEENAME
        {
            get
            {
                return employeeName;
            }
            private set
            {
                employeeName = value;
            }
        }

        public static string EMPLOYEEROLE
        {
            get
            {
                return employeeRole;
            }
            private set
            {
                employeeRole = value;
            }
        }


        public bool getFacultyLogin(string email,string pass_word)
        {
            var result = obj.emp_getEmployeeLogin(email, pass_word);
            foreach(var items in result)
            {
                if (items.EmpName == null || items.EmpName == "")
                {

                    check_login = false;
                    break;
                }
                else
                {
                    check_login = true;
                }
                EMPLOYEEID = items.EmpID;
                EMPLOYEENAME = items.EmpName;
                EMPLOYEEROLE = items.EmpDesignation;
            }
            return check_login;
        }
        public  void showWindow(Form openwindow,Form closewindow,Form MDI)
        {
            closewindow.Close();
            openwindow.WindowState = FormWindowState.Maximized;
            openwindow.MdiParent = MDI;
            openwindow.Show();
        }

        public static DialogResult ShowMSG(string msg,string heading,string type)
        {
            if(type == "Success")
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void disable_reset(Panel p)
        {
            foreach(Control c in p.Controls)
            {
                if(c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = false;
                    tb.Text = "";
                }
                if(c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                    cb.SelectedIndex = -1;
                }
                if(c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                    rb.Checked = false;
                }
                if(c is CheckBox)
                {
                    CheckBox ckb = (CheckBox)c;
                    ckb.Enabled = false;
                    ckb.Checked = false;
                }
                if(c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = false;
                    dtp.Value = DateTime.Now;
                }
                if(c is Button)
                {
                    Button btn = (Button)c;
                    btn.Enabled = false;
                }
            }
        }

        public static void enable_reset(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = true;
                    tb.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                    rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox ckb = (CheckBox)c;
                    ckb.Enabled = true;
                    ckb.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                }
                if (c is Button)
                {
                    Button btn = (Button)c;
                    btn.Enabled = true;
                }
            }
        }

        public static void enable_reset(GroupBox gb)
        {
            foreach (Control c in gb.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = true;
                    tb.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                    rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox ckb = (CheckBox)c;
                    ckb.Enabled = true;
                    ckb.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                }
                if (c is Button)
                {
                    Button btn = (Button)c;
                    btn.Enabled = true;
                }
            }
        }

        public static void enable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = true;
                    //tb.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    //cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                    //rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox ckb = (CheckBox)c;
                    ckb.Enabled = true;
                    //ckb.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                    //dtp.Value = DateTime.Now;
                }
                if (c is Button)
                {
                    Button btn = (Button)c;
                    btn.Enabled = true;
                }
            }
        }

        public static void sno(DataGridView dgv,string colname)
        {
            int count = 1;
            foreach(DataGridViewRow row in dgv.Rows)
            {
               
                row.Cells[colname].Value = count;
                count++;
            }
        }
    }
}
