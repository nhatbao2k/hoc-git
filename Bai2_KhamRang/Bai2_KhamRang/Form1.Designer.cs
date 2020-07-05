namespace Bai2_KhamRang
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tinhTien = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.kq = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hanRang = new System.Windows.Forms.NumericUpDown();
            this.layCao = new System.Windows.Forms.CheckBox();
            this.chupHinh = new System.Windows.Forms.CheckBox();
            this.tayTrang = new System.Windows.Forms.CheckBox();
            this.caoVoi = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hanRang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(223, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(587, 34);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 401);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng tiền";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tinhTien
            // 
            this.tinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhTien.Location = new System.Drawing.Point(21, 450);
            this.tinhTien.Margin = new System.Windows.Forms.Padding(4);
            this.tinhTien.Name = "tinhTien";
            this.tinhTien.Size = new System.Drawing.Size(144, 53);
            this.tinhTien.TabIndex = 4;
            this.tinhTien.Text = "Tính tiền";
            this.tinhTien.UseVisualStyleBackColor = true;
            this.tinhTien.Click += new System.EventHandler(this.tinhTien_Click);
            // 
            // thoat
            // 
            this.thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Location = new System.Drawing.Point(545, 450);
            this.thoat.Margin = new System.Windows.Forms.Padding(4);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(137, 53);
            this.thoat.TabIndex = 5;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // kq
            // 
            this.kq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kq.Location = new System.Drawing.Point(223, 389);
            this.kq.Margin = new System.Windows.Forms.Padding(4);
            this.kq.Name = "kq";
            this.kq.Size = new System.Drawing.Size(587, 42);
            this.kq.TabIndex = 6;
            this.kq.Text = "0";
            this.kq.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.kq.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.hanRang);
            this.panel1.Controls.Add(this.layCao);
            this.panel1.Controls.Add(this.chupHinh);
            this.panel1.Controls.Add(this.tayTrang);
            this.panel1.Controls.Add(this.caoVoi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(223, 85);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 287);
            this.panel1.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(355, 227);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "90 000 VNĐ / cái";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(392, 188);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "100 000 VNĐ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "150 000 VNĐ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(369, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "1 200 000 VNĐ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "100 000 VNĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hàn răng";
            // 
            // hanRang
            // 
            this.hanRang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hanRang.Location = new System.Drawing.Point(181, 222);
            this.hanRang.Margin = new System.Windows.Forms.Padding(4);
            this.hanRang.Name = "hanRang";
            this.hanRang.Size = new System.Drawing.Size(65, 34);
            this.hanRang.TabIndex = 5;
            // 
            // layCao
            // 
            this.layCao.AutoSize = true;
            this.layCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layCao.Location = new System.Drawing.Point(9, 183);
            this.layCao.Margin = new System.Windows.Forms.Padding(4);
            this.layCao.Name = "layCao";
            this.layCao.Size = new System.Drawing.Size(117, 33);
            this.layCao.TabIndex = 4;
            this.layCao.Text = "Lấy cao";
            this.layCao.UseVisualStyleBackColor = true;
            // 
            // chupHinh
            // 
            this.chupHinh.AutoSize = true;
            this.chupHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chupHinh.Location = new System.Drawing.Point(9, 142);
            this.chupHinh.Margin = new System.Windows.Forms.Padding(4);
            this.chupHinh.Name = "chupHinh";
            this.chupHinh.Size = new System.Drawing.Size(143, 33);
            this.chupHinh.TabIndex = 3;
            this.chupHinh.Text = "Chụp hình";
            this.chupHinh.UseVisualStyleBackColor = true;
            // 
            // tayTrang
            // 
            this.tayTrang.AutoSize = true;
            this.tayTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tayTrang.Location = new System.Drawing.Point(9, 100);
            this.tayTrang.Margin = new System.Windows.Forms.Padding(4);
            this.tayTrang.Name = "tayTrang";
            this.tayTrang.Size = new System.Drawing.Size(135, 33);
            this.tayTrang.TabIndex = 2;
            this.tayTrang.Text = "Tẩy trắng";
            this.tayTrang.UseVisualStyleBackColor = true;
            // 
            // caoVoi
            // 
            this.caoVoi.AutoSize = true;
            this.caoVoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caoVoi.Location = new System.Drawing.Point(9, 58);
            this.caoVoi.Margin = new System.Windows.Forms.Padding(4);
            this.caoVoi.Name = "caoVoi";
            this.caoVoi.Size = new System.Drawing.Size(116, 33);
            this.caoVoi.TabIndex = 1;
            this.caoVoi.Text = "Cạo vôi";
            this.caoVoi.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bảng giá";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tổng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.tinhTien;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CancelButton = this.thoat;
            this.ClientSize = new System.Drawing.Size(883, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kq);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.tinhTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính tiền khám răng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hanRang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tinhTien;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button kq;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown hanRang;
        private System.Windows.Forms.CheckBox layCao;
        private System.Windows.Forms.CheckBox chupHinh;
        private System.Windows.Forms.CheckBox tayTrang;
        private System.Windows.Forms.CheckBox caoVoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

