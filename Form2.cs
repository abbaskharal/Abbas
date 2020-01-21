using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Cafe_Management_Systems
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitClick_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nextClick_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show(); 
        }
    }
}
