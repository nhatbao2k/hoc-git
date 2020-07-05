namespace TimUCLN_BCNN
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ra_BCNN = new System.Windows.Forms.RadioButton();
            this.ra_UCLN = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.bt_boQua = new System.Windows.Forms.Button();
            this.bt_Tim = new System.Windows.Forms.Button();
            this.hienThiKetQua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txt_b);
            this.groupBox1.Controls.Add(this.txt_a);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập:";
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(39, 151);
            this.txt_b.Multiline = true;
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(376, 36);
            this.txt_b.TabIndex = 3;
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(39, 50);
            this.txt_a.Multiline = true;
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(376, 36);
            this.txt_a.TabIndex = 2;
            this.txt_a.TextChanged += new System.EventHandler(this.txt_a_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "A:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.ra_BCNN);
            this.groupBox2.Controls.Add(this.ra_UCLN);
            this.groupBox2.Location = new System.Drawing.Point(466, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 213);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn tìm";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ra_BCNN
            // 
            this.ra_BCNN.AutoSize = true;
            this.ra_BCNN.Location = new System.Drawing.Point(100, 123);
            this.ra_BCNN.Name = "ra_BCNN";
            this.ra_BCNN.Size = new System.Drawing.Size(76, 21);
            this.ra_BCNN.TabIndex = 1;
            this.ra_BCNN.TabStop = true;
            this.ra_BCNN.Text = "BSCNN";
            this.ra_BCNN.UseVisualStyleBackColor = true;
            // 
            // ra_UCLN
            // 
            this.ra_UCLN.AutoSize = true;
            this.ra_UCLN.Location = new System.Drawing.Point(100, 50);
            this.ra_UCLN.Name = "ra_UCLN";
            this.ra_UCLN.Size = new System.Drawing.Size(75, 21);
            this.ra_UCLN.TabIndex = 0;
            this.ra_UCLN.TabStop = true;
            this.ra_UCLN.Text = "USCLN";
            this.ra_UCLN.UseVisualStyleBackColor = true;
            this.ra_UCLN.CheckedChanged += new System.EventHandler(this.ra_UCLN_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.bt_Thoat);
            this.groupBox3.Controls.Add(this.bt_boQua);
            this.groupBox3.Controls.Add(this.bt_Tim);
            this.groupBox3.Controls.Add(this.hienThiKetQua);
            this.groupBox3.Location = new System.Drawing.Point(12, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 189);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Thoat.Location = new System.Drawing.Point(385, 112);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(104, 40);
            this.bt_Thoat.TabIndex = 3;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // bt_boQua
            // 
            this.bt_boQua.Location = new System.Drawing.Point(230, 112);
            this.bt_boQua.Name = "bt_boQua";
            this.bt_boQua.Size = new System.Drawing.Size(104, 40);
            this.bt_boQua.TabIndex = 2;
            this.bt_boQua.Text = "Bỏ qua";
            this.bt_boQua.UseVisualStyleBackColor = true;
            this.bt_boQua.Click += new System.EventHandler(this.bt_boQua_Click);
            // 
            // bt_Tim
            // 
            this.bt_Tim.Location = new System.Drawing.Point(78, 112);
            this.bt_Tim.Name = "bt_Tim";
            this.bt_Tim.Size = new System.Drawing.Size(104, 40);
            this.bt_Tim.TabIndex = 1;
            this.bt_Tim.Text = "Tìm";
            this.bt_Tim.UseVisualStyleBackColor = true;
            this.bt_Tim.Click += new System.EventHandler(this.bt_Tim_Click);
            // 
            // hienThiKetQua
            // 
            this.hienThiKetQua.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.hienThiKetQua.FlatAppearance.BorderSize = 5;
            this.hienThiKetQua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.hienThiKetQua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.hienThiKetQua.Location = new System.Drawing.Point(78, 35);
            this.hienThiKetQua.Name = "hienThiKetQua";
            this.hienThiKetQua.Size = new System.Drawing.Size(360, 41);
            this.hienThiKetQua.TabIndex = 0;
            this.hienThiKetQua.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.bt_Tim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.bt_Thoat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ra_BCNN;
        private System.Windows.Forms.RadioButton ra_UCLN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button hienThiKetQua;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_boQua;
        private System.Windows.Forms.Button bt_Tim;
    }
}

