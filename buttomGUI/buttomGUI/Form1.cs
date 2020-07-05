using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttomGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cong_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
            KQ.Text = Convert.ToString(a);
        }

        private void tru_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
            KQ.Text = Convert.ToString(a);
        }

        private void nhan_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
            KQ.Text = Convert.ToString(a);
        }

        private void chia_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
            KQ.Text = Convert.ToString(a);
        }

        private void Exits_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            KQ.Text = "";
        }
    }
}
