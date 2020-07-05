namespace Bai5_PhuongTrinhBacHai
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đổiMàuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_ketQua = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_tinh = new System.Windows.Forms.Button();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ContextMenuStrip = this.contextMenuStrip1;
            this.label1.Location = new System.Drawing.Point(311, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phương trình bậc hai";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMàuToolStripMenuItem,
            this.đổiFontToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 52);
            // 
            // đổiMàuToolStripMenuItem
            // 
            this.đổiMàuToolStripMenuItem.Name = "đổiMàuToolStripMenuItem";
            this.đổiMàuToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.đổiMàuToolStripMenuItem.Text = "Đổi màu";
            this.đổiMàuToolStripMenuItem.Click += new System.EventHandler(this.đổiMàuToolStripMenuItem_Click);
            // 
            // đổiFontToolStripMenuItem
            // 
            this.đổiFontToolStripMenuItem.Name = "đổiFontToolStripMenuItem";
            this.đổiFontToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.đổiFontToolStripMenuItem.Text = "Đổi font";
            this.đổiFontToolStripMenuItem.Click += new System.EventHandler(this.đổiFontToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ContextMenuStrip = this.contextMenuStrip1;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ContextMenuStrip = this.contextMenuStrip1;
            this.label3.Location = new System.Drawing.Point(16, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ContextMenuStrip = this.contextMenuStrip1;
            this.label4.Location = new System.Drawing.Point(16, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập c";
            // 
            // lb_ketQua
            // 
            this.lb_ketQua.AutoSize = true;
            this.lb_ketQua.ContextMenuStrip = this.contextMenuStrip1;
            this.lb_ketQua.Location = new System.Drawing.Point(265, 333);
            this.lb_ketQua.Name = "lb_ketQua";
            this.lb_ketQua.Size = new System.Drawing.Size(0, 17);
            this.lb_ketQua.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ContextMenuStrip = this.contextMenuStrip1;
            this.label5.Location = new System.Drawing.Point(122, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kết quả";
            // 
            // bt_tinh
            // 
            this.bt_tinh.ContextMenuStrip = this.contextMenuStrip1;
            this.bt_tinh.Location = new System.Drawing.Point(634, 90);
            this.bt_tinh.Name = "bt_tinh";
            this.bt_tinh.Size = new System.Drawing.Size(75, 159);
            this.bt_tinh.TabIndex = 10;
            this.bt_tinh.Text = "Tính";
            this.bt_tinh.UseVisualStyleBackColor = true;
            this.bt_tinh.Click += new System.EventHandler(this.bt_tinh_Click);
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(27, 175);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(428, 22);
            this.txt_c.TabIndex = 7;
            this.txt_c.Leave += new System.EventHandler(this.txt_c_Leave);
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(27, 106);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(428, 22);
            this.txt_b.TabIndex = 6;
            this.txt_b.Leave += new System.EventHandler(this.txt_c_Leave);
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(27, 38);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(428, 22);
            this.txt_a.TabIndex = 5;
            this.txt_a.Leave += new System.EventHandler(this.txt_c_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_a);
            this.panel1.Controls.Add(this.txt_b);
            this.panel1.Controls.Add(this.txt_c);
            this.panel1.Location = new System.Drawing.Point(98, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 212);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_tinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_ketQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đổiMàuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiFontToolStripMenuItem;
        private System.Windows.Forms.Label lb_ketQua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_tinh;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

