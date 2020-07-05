using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace label_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = ":))";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text = ":((";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            anh1 a1 = new anh1();
            a1.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            anh2 a2 = new anh2();
            a2.ShowDialog();
        }
    }
}
