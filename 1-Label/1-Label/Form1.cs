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

namespace _1_Label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadLabel();
        }
        public void LoadLabel()
        {
            Label lb = new Label();
            lb.Text = "Welcome";
            this.Controls.Add(lb);
            lb.BackColor = Color.Gold;
            
           
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            f.label1.Text = "ahihi";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hellooooooooooooo";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

    }
}
