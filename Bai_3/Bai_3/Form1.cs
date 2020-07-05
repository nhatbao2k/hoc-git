using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_3
{
    public partial class Form1 : Form
    {
        string toanTu;
        double a;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thayĐổiMàuSắcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (Button x in tableLayoutPanel1.Controls)
                    x.BackColor = colorDialog1.Color;
            }
        }

        private void thayĐổiFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (Button x in tableLayoutPanel1.Controls)
                    x.Font = fontDialog1.Font;
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            hienThi.Text = "0";
            toanTu = "";
        }

        private void bt_so(object sender, EventArgs e)
        {
            if (hienThi.Text == "0")
                hienThi.Text = "";
            Button bt = (Button)sender;
            hienThi.Text = hienThi.Text + bt.Text;
        }

        private void bt_operator(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            toanTu = bt.Text;
            a = double.Parse(hienThi.Text);
            hienThi.Text = "";
        }
        private void bang_Click(object sender, EventArgs e)
        {
            switch(toanTu)
            {
                case "+":
                    hienThi.Text = Convert.ToString(a + double.Parse(hienThi.Text));
                    break;
                case "-":
                    hienThi.Text = Convert.ToString(a - double.Parse(hienThi.Text));
                    break;
                case "*":
                    hienThi.Text = Convert.ToString(a * double.Parse(hienThi.Text));
                    break;
                case "/":
                    hienThi.Text = Convert.ToString(a / double.Parse(hienThi.Text));
                    break;
            }    
        }

       

        
    }
}

