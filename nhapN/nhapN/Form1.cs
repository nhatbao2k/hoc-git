using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nhapN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nto_Click(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            label5.Text = label6.Text = label7.Text = "";

            try
            {
                n = Convert.ToInt32(nhap.Text);

            }

            catch { }


            void snt(int k)
            {

                for (int i = 2; i < k; i++)
                {
                    int dem = 0;
                    for (int j = 1; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            dem++;
                        }
                    }
                    if (dem == 1)
                    {
                        label5.Text += Convert.ToString(i) + " ";
                    }
                }

            }
            void cp(int c)
            {
                for(int i=1; i<c; i++)
                {
                    if(((int)Math.Sqrt(i))*((int)Math.Sqrt(i))==i)
                    {
                        label6.Text += Convert.ToString(i) + " ";
                    }    
                }    
            }

            void sohc(int d)
            {
                for(int i =1; i<d; i++)
                {
                    int sum = 0;
                    for (int j = 1; j < i; j++)
                    {
                        if (i % j == 0)
                            sum += j;
                    }
                    if (i == sum)
                        label7.Text += Convert.ToString(i) + " ";
                }    
            }
            if(n>0 && n<1000)
            {
                snt(n);
                cp(n);
                sohc(n);
            }    
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void nhap_Leave(object sender, EventArgs e)
        {
            int n = 0;
            try
            {
                n = Convert.ToInt32(nhap.Text);

            }

            catch (FormatException)
            {
                MessageBox.Show("sai du lieu");
                nhap.Focus();
            }
            if (n < 0 || n > 1000)
            {
                MessageBox.Show("Nhap sai du lieu");
                nhap.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
