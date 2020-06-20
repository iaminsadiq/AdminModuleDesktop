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
    public partial class GlobalWeb : Form
    {
        public GlobalWeb()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void showname_Click(object sender, EventArgs e)
        {
            
        }

        private void GlobalWeb_Load(object sender, EventArgs e)
        {
            showname.Text = MainClass.EMPLOYEENAME;
        }
    }
}
