using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhap
{
    public partial class Form1 : Form
    {
        List<SinhVien> danhSach;
        public Form1()
        {
            InitializeComponent();
            danhsach = new List<food>()
            {
                new food() { Name = "Burger", Price = 100000 },
                new food() { Name = "noodle", Price = 10000 },
                new food() { Name = "cake", Price = 500000 }
            };

            comboBox1.DataSource = danhsach;
            comboBox1.DisplayMember = "Name";
            addDatabinding();
            danhSach = new List<SinhVien>();
            danhSach.Add(new SinhVien()
            {
                tenLop = "12A",
                tenSV = new List<string>() { "an", "ha" }
            });
            danhSach.Add(new SinhVien()
            {
                tenLop ="12E",
                tenSV = new List<string>() { "dat","hoang"}
            });
            cbb_Lop.DataSource = danhSach;
            cbb_Lop.DisplayMember = "tenLop";
        }
        
        private void bt_1_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.AutoSize = true;
            bt.Text = "hello";
          
            Random rand = new Random();
            bt.Location = new Point(rand.Next(0, panel1.Size.Width), rand.Next(0, panel1.Size.Height));
            panel1.Controls.Add(bt);
            
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Text = "hello2";
            bt.AutoSize = true;
            flowLayoutPanel1.Controls.Add(bt);
            panel1.Enabled = !panel1.Enabled;
        }
        List<food> danhsach;
        private void comboBox1_Click(object sender, EventArgs e)
        {
            
        }
        void addDatabinding()
        {
            textBox1.DataBindings.Add(new Binding("Text", comboBox1.DataSource, "Price"));
        }
        public class food
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //ComboBox cbb = sender as ComboBox;
            //if(cbb.SelectedValue.ToString() != null)
            //{
            //    food doAn = cbb.SelectedValue as food;
            //    textBox1.Text = Convert.ToString(doAn.Price);
            //}    
           
        }

        private void cbb_Lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbb = sender as ComboBox;
            if(cbb.SelectedValue!=null)
            {
                SinhVien sv = cbb.SelectedValue as SinhVien;
                cbb_tenSV.DataSource = sv.tenSV;
            }
        }
    }
}
