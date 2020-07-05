using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_DSSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable tb = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            tb.Columns.Add("MaSV");
            tb.Columns.Add("Họ tên");
            tb.Columns.Add("Ngày sinh");
            tb.Columns.Add("Giới tính");
            tb.Columns.Add("Quê quán");
            tb.Columns.Add("Lớp");
            tb.Columns.Add("Khoa");
            dataGridView1.DataSource = tb;
        }
        int index;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        } 
        string gt;
        private void bt_Them_Click(object sender, EventArgs e)
        {
                    if (radio_nam.Checked)
                        gt = "Nam";
                    if (radio_nu.Checked)
                        gt = "Nữ";

                    tb.Rows.Add(txt_MaSV.Text, txt_HT.Text, ngaySinh.Text, gt, cbb_queQuan.Text, cbb_lop.Text, cbb_khoa.Text);           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tb.Rows.RemoveAt(index);
        }
        private void cbb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            tb.Rows[index][0] = txt_MaSV.Text;
            tb.Rows[index][1] = txt_HT.Text;
            tb.Rows[index][2] = ngaySinh.Text;
            tb.Rows[index][3] = gt;
            tb.Rows[index][4] = cbb_queQuan.Text;
            tb.Rows[index][5] = cbb_lop.Text;
            tb.Rows[index][6] = cbb_khoa.Text;
        }
        
    

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;

            txt_MaSV.Text = tb.Rows[index][0].ToString();
            txt_HT.Text = tb.Rows[index][1].ToString();
            ngaySinh.Text = Convert.ToDateTime(tb.Rows[index][2]).ToString();
            gt = tb.Rows[index][3].ToString();
            if (gt == "Nam")
                radio_nam.Checked = true;
            else
                radio_nu.Checked = true;
            cbb_queQuan.Text = tb.Rows[index][4].ToString();
            cbb_lop.Text = tb.Rows[index][5].ToString();
            cbb_khoa.Text = tb.Rows[index][6].ToString();
        }
        
        private void cbb_khoa_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
