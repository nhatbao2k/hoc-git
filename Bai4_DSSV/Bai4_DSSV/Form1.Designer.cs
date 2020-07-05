namespace Bai4_DSSV
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.bt_Them = new System.Windows.Forms.Button();
            this.radio_nu = new System.Windows.Forms.RadioButton();
            this.radio_nam = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_lop = new System.Windows.Forms.ComboBox();
            this.cbb_queQuan = new System.Windows.Forms.ComboBox();
            this.cbb_khoa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_HT = new System.Windows.Forms.TextBox();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_Sua);
            this.panel1.Controls.Add(this.bt_xoa);
            this.panel1.Controls.Add(this.ngaySinh);
            this.panel1.Controls.Add(this.bt_Them);
            this.panel1.Controls.Add(this.radio_nu);
            this.panel1.Controls.Add(this.radio_nam);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbb_lop);
            this.panel1.Controls.Add(this.cbb_queQuan);
            this.panel1.Controls.Add(this.cbb_khoa);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_HT);
            this.panel1.Controls.Add(this.txt_MaSV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 259);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bt_Sua.Location = new System.Drawing.Point(634, 189);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(141, 42);
            this.bt_Sua.TabIndex = 18;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = true;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bt_xoa.Location = new System.Drawing.Point(790, 189);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(141, 42);
            this.bt_xoa.TabIndex = 17;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // ngaySinh
            // 
            this.ngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaySinh.Location = new System.Drawing.Point(93, 128);
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.Size = new System.Drawing.Size(304, 22);
            this.ngaySinh.TabIndex = 16;
            // 
            // bt_Them
            // 
            this.bt_Them.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bt_Them.Location = new System.Drawing.Point(471, 189);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(141, 42);
            this.bt_Them.TabIndex = 15;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // radio_nu
            // 
            this.radio_nu.AutoSize = true;
            this.radio_nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_nu.Location = new System.Drawing.Point(346, 207);
            this.radio_nu.Name = "radio_nu";
            this.radio_nu.Size = new System.Drawing.Size(51, 24);
            this.radio_nu.TabIndex = 14;
            this.radio_nu.TabStop = true;
            this.radio_nu.Text = "Nữ";
            this.radio_nu.UseVisualStyleBackColor = true;
            // 
            // radio_nam
            // 
            this.radio_nam.AutoSize = true;
            this.radio_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_nam.Location = new System.Drawing.Point(183, 207);
            this.radio_nam.Name = "radio_nam";
            this.radio_nam.Size = new System.Drawing.Size(65, 24);
            this.radio_nam.TabIndex = 13;
            this.radio_nam.TabStop = true;
            this.radio_nam.Text = "Nam";
            this.radio_nam.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Giới tính";
            // 
            // cbb_lop
            // 
            this.cbb_lop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_lop.FormattingEnabled = true;
            this.cbb_lop.Items.AddRange(new object[] {
            "60TH1",
            "60TH2",
            "60TH3",
            "60TH4",
            "60TH5"});
            this.cbb_lop.Location = new System.Drawing.Point(605, 68);
            this.cbb_lop.Name = "cbb_lop";
            this.cbb_lop.Size = new System.Drawing.Size(317, 24);
            this.cbb_lop.TabIndex = 11;
            this.cbb_lop.SelectedIndexChanged += new System.EventHandler(this.cbb_lop_SelectedIndexChanged);
            // 
            // cbb_queQuan
            // 
            this.cbb_queQuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_queQuan.FormattingEnabled = true;
            this.cbb_queQuan.Items.AddRange(new object[] {
            "Hà Nội",
            "Ninh Bình",
            "Hải Phòng",
            "Hòa Bình",
            "Thanh Hóa",
            "Nghệ An ",
            "Hà Tĩnh ",
            "Quảng Bình"});
            this.cbb_queQuan.Location = new System.Drawing.Point(605, 22);
            this.cbb_queQuan.Name = "cbb_queQuan";
            this.cbb_queQuan.Size = new System.Drawing.Size(317, 24);
            this.cbb_queQuan.TabIndex = 10;
            // 
            // cbb_khoa
            // 
            this.cbb_khoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_khoa.FormattingEnabled = true;
            this.cbb_khoa.Items.AddRange(new object[] {
            "Công Nghệ Thông Tin",
            "Tự động hóa",
            "Kĩ thuật ô tô"});
            this.cbb_khoa.Location = new System.Drawing.Point(605, 119);
            this.cbb_khoa.Name = "cbb_khoa";
            this.cbb_khoa.Size = new System.Drawing.Size(317, 24);
            this.cbb_khoa.TabIndex = 9;
            this.cbb_khoa.SelectedValueChanged += new System.EventHandler(this.cbb_khoa_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(507, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Khoa";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(507, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lớp";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(507, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quê quán";
            // 
            // txt_HT
            // 
            this.txt_HT.Location = new System.Drawing.Point(85, 68);
            this.txt_HT.Multiline = true;
            this.txt_HT.Name = "txt_HT";
            this.txt_HT.Size = new System.Drawing.Size(312, 22);
            this.txt_HT.TabIndex = 4;
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Location = new System.Drawing.Point(85, 26);
            this.txt_MaSV.Multiline = true;
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(312, 22);
            this.txt_MaSV.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(934, 191);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radio_nu;
        private System.Windows.Forms.RadioButton radio_nam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_lop;
        private System.Windows.Forms.ComboBox cbb_queQuan;
        private System.Windows.Forms.ComboBox cbb_khoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_HT;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.DateTimePicker ngaySinh;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

