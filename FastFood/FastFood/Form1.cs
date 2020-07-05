using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable bang = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            bang.Columns.Add("Món Ăn");
            bang.Columns.Add("Số lượng");
            dataGridView1.DataSource = bang;
        }
    }
}
