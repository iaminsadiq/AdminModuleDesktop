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
    public partial class MultiDocInterface : Form
    {
        MainClass main = new MainClass();
        public MultiDocInterface()
        {
            InitializeComponent();
        }
        MainClass mainclass = new MainClass();
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lgn = new Login();
            lgn.MdiParent = this;
            lgn.WindowState = FormWindowState.Maximized;
            lgn.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MultiDocInterface_Load(object sender, EventArgs e)
        {
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(mainclass.path+"\\connect"))
            {
                Login obj = new Login();
                obj.MdiParent = this;
                obj.WindowState = FormWindowState.Maximized;
                obj.Show();
            }
            else
            {
                Settings obj = new Settings();
                obj.MdiParent = this;
                obj.WindowState = FormWindowState.Maximized;
                obj.Show();
            }
           
        }
    }
}
