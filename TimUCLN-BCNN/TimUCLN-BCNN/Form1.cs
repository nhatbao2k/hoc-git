using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimUCLN_BCNN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bt_Tim_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            try
            {
                a = Convert.ToInt32(txt_a.Text);
                b = Convert.ToInt32(txt_b.Text);
            }
            catch
            {
              
                txt_a.Focus();
                txt_b.Focus();
            }
            if(a<=0 || b<=0)
            {
                MessageBox.Show("đm ngu vl", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_a.Focus();
                txt_b.Focus();
            }    
            if (ra_UCLN.Checked == true)
            {
                if (a == b)
                    hienThiKetQua.Text = Convert.ToString(a);
                else if (a < b)
                {
                    for (int i = a; i >0; i--)
                    {
                        if (b % i == 0 && a%i == 0)
                        {
                            hienThiKetQua.Text = Convert.ToString(i);
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = b; i >0; i--)
                    {
                        if (a % i == 0 && b % i == 0)
                        {
                            hienThiKetQua.Text = Convert.ToString(i);
                            break;
                        }
                    }
                }
            }    
            
            if(ra_BCNN.Checked == true)
            {
                if(a>b)
                {
                    for(int i=a; i>=a; i++)
                    {
                        if((i%a==0)&&(i%b==0))
                        {
                            hienThiKetQua.Text = Convert.ToString(i);
                            break;
                        }    
                    }    
                }
                else
                {
                    for (int i = b; i >= b; i++)
                    {
                        if ((i % a == 0) && (i % b == 0))
                        {
                            hienThiKetQua.Text = Convert.ToString(i);
                            break;
                        }
                    }
                }    
            }    
        }

        private void ra_UCLN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt_boQua_Click(object sender, EventArgs e)
        {
            txt_a.Clear();
            txt_b.Clear();
            hienThiKetQua.Text = "";
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_a_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
