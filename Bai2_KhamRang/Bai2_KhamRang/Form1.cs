using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_KhamRang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }    
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        int a, b, c, d;
      
        private void tinhTien_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0, d = 0;
            if (caoVoi.Checked == true)
                 a = 100000;
            if (tayTrang.Checked == true)
                 b = 1200000;
            if (chupHinh.Checked == true)
                c = 150000;
            if (layCao.Checked == true)
                d = 100000;
            int k=0;
            try
            {
                k = Convert.ToInt32(hanRang.Value);
                
            }
            catch
            {
                MessageBox.Show("sai so rang");
                hanRang.Focus();
            }
            if (k > 32)
            {
                MessageBox.Show("ERROR", "WARNINGS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hanRang.Focus();
            }    
            else
            {
                int t = a + b + c + d + k * 90000;

                kq.Text = Convert.ToString(t);
            }    
           
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }
    }
}
