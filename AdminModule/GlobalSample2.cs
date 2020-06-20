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
    public partial class GlobalSample2 : GlobalWeb
    {
        public GlobalSample2()
        {
            InitializeComponent();
        }
        MainClass main = new MainClass();
        public void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        public virtual void addBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void editBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void saveBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void viewBtn_Click(object sender, EventArgs e)
        {

        }

        protected virtual void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();
            main.showWindow(hs, this, MultiDocInterface.ActiveForm);
        }

        public  void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        protected void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
