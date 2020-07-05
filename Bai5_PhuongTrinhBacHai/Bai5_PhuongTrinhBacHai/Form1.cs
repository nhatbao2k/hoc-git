using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_PhuongTrinhBacHai
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
        
        private void bt_tinh_Click(object sender, EventArgs e)
        {
   
            if(txt_a.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập a", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txt_b.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập b", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_c.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập c", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double a = Convert.ToDouble(txt_a.Text);
                double b = Convert.ToDouble(txt_b.Text);
                double c = Convert.ToDouble(txt_c.Text);

                double delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                    lb_ketQua.Text = "Phương trình vô nghiệm";
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    lb_ketQua.Text = ("x=" + x).ToString();
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    lb_ketQua.Text = ("x1=" + x1 + ", x2=" + x2).ToString();
                }
            }    
          
        }

        private void txt_c_Leave(object sender, EventArgs e)
        {
                TextBox txt = (TextBox)sender;
                double a = 0;
                try
                {
                    a = Convert.ToDouble(txt.Text);
                }
                catch(FormatException)
                {
                    MessageBox.Show( "Bạn phải nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt.Text = ""; 
                    txt.Focus();
                }
                
        }

        private void đổiMàuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                  
                
            }
        }

        private void đổiFontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
