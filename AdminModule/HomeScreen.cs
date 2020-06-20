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
    public partial class HomeScreen : GlobalWeb
    {
        public HomeScreen()
        {
            InitializeComponent();
        }
        MainClass main = new MainClass();
        private void button1_Click(object sender, EventArgs e)
        {
            Faculty f = new Faculty();
            main.showWindow(f, this, MultiDocInterface.ActiveForm);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Roles r = new Roles();
            main.showWindow(r, this, MultiDocInterface.ActiveForm);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Students std = new Students();
            main.showWindow(std, this, MultiDocInterface.ActiveForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Courses c = new Courses();
            main.showWindow(c, this, MultiDocInterface.ActiveForm);
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
