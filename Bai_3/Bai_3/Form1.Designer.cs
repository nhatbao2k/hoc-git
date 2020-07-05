namespace Bai_3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thayĐổiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiMàuSắcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.hienThi = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chia = new System.Windows.Forms.Button();
            this.bang = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.khong = new System.Windows.Forms.Button();
            this.nhan = new System.Windows.Forms.Button();
            this.chin = new System.Windows.Forms.Button();
            this.tam = new System.Windows.Forms.Button();
            this.bay = new System.Windows.Forms.Button();
            this.tru = new System.Windows.Forms.Button();
            this.sau = new System.Windows.Forms.Button();
            this.nam = new System.Windows.Forms.Button();
            this.bon = new System.Windows.Forms.Button();
            this.cong = new System.Windows.Forms.Button();
            this.ba = new System.Windows.Forms.Button();
            this.hai = new System.Windows.Forms.Button();
            this.mot = new System.Windows.Forms.Button();
            this.ketQua = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thayĐổiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thayĐổiToolStripMenuItem
            // 
            this.thayĐổiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thayĐổiMàuSắcToolStripMenuItem,
            this.thayĐổiFontToolStripMenuItem});
            this.thayĐổiToolStripMenuItem.Name = "thayĐổiToolStripMenuItem";
            this.thayĐổiToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.thayĐổiToolStripMenuItem.Text = "Thay đổi";
            // 
            // thayĐổiMàuSắcToolStripMenuItem
            // 
            this.thayĐổiMàuSắcToolStripMenuItem.Name = "thayĐổiMàuSắcToolStripMenuItem";
            this.thayĐổiMàuSắcToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.thayĐổiMàuSắcToolStripMenuItem.Text = "Thay đổi màu sắc";
            this.thayĐổiMàuSắcToolStripMenuItem.Click += new System.EventHandler(this.thayĐổiMàuSắcToolStripMenuItem_Click);
            // 
            // thayĐổiFontToolStripMenuItem
            // 
            this.thayĐổiFontToolStripMenuItem.Name = "thayĐổiFontToolStripMenuItem";
            this.thayĐổiFontToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.thayĐổiFontToolStripMenuItem.Text = "Thay đổi font";
            this.thayĐổiFontToolStripMenuItem.Click += new System.EventHandler(this.thayĐổiFontToolStripMenuItem_Click);
            // 
            // hienThi
            // 
            this.hienThi.Dock = System.Windows.Forms.DockStyle.Top;
            this.hienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hienThi.Location = new System.Drawing.Point(0, 28);
            this.hienThi.Multiline = true;
            this.hienThi.Name = "hienThi";
            this.hienThi.ReadOnly = true;
            this.hienThi.Size = new System.Drawing.Size(800, 72);
            this.hienThi.TabIndex = 1;
            this.hienThi.Text = "0";
            this.hienThi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.chia, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.bang, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.xoa, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.khong, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nhan, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.chin, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tam, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bay, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tru, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.sau, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.nam, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bon, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cong, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ba, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.hai, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.mot, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 176);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 274);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // chia
            // 
            this.chia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chia.Location = new System.Drawing.Point(603, 207);
            this.chia.Name = "chia";
            this.chia.Size = new System.Drawing.Size(194, 64);
            this.chia.TabIndex = 15;
            this.chia.Text = "/";
            this.chia.UseVisualStyleBackColor = true;
            this.chia.Click += new System.EventHandler(this.bt_operator);
            // 
            // bang
            // 
            this.bang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bang.Location = new System.Drawing.Point(403, 207);
            this.bang.Name = "bang";
            this.bang.Size = new System.Drawing.Size(194, 64);
            this.bang.TabIndex = 14;
            this.bang.Text = "=";
            this.bang.UseVisualStyleBackColor = true;
            this.bang.Click += new System.EventHandler(this.bang_Click);
            // 
            // xoa
            // 
            this.xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xoa.Location = new System.Drawing.Point(203, 207);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(194, 64);
            this.xoa.TabIndex = 13;
            this.xoa.Text = "C";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // khong
            // 
            this.khong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khong.Location = new System.Drawing.Point(3, 207);
            this.khong.Name = "khong";
            this.khong.Size = new System.Drawing.Size(194, 64);
            this.khong.TabIndex = 12;
            this.khong.Text = "0";
            this.khong.UseVisualStyleBackColor = true;
            this.khong.Click += new System.EventHandler(this.bt_so);
            // 
            // nhan
            // 
            this.nhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhan.Location = new System.Drawing.Point(603, 139);
            this.nhan.Name = "nhan";
            this.nhan.Size = new System.Drawing.Size(194, 62);
            this.nhan.TabIndex = 11;
            this.nhan.Text = "*";
            this.nhan.UseVisualStyleBackColor = true;
            this.nhan.Click += new System.EventHandler(this.bt_operator);
            // 
            // chin
            // 
            this.chin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chin.Location = new System.Drawing.Point(403, 139);
            this.chin.Name = "chin";
            this.chin.Size = new System.Drawing.Size(194, 62);
            this.chin.TabIndex = 10;
            this.chin.Text = "9";
            this.chin.UseVisualStyleBackColor = true;
            this.chin.Click += new System.EventHandler(this.bt_so);
            // 
            // tam
            // 
            this.tam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tam.Location = new System.Drawing.Point(203, 139);
            this.tam.Name = "tam";
            this.tam.Size = new System.Drawing.Size(194, 62);
            this.tam.TabIndex = 9;
            this.tam.Text = "8";
            this.tam.UseVisualStyleBackColor = true;
            this.tam.Click += new System.EventHandler(this.bt_so);
            // 
            // bay
            // 
            this.bay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bay.Location = new System.Drawing.Point(3, 139);
            this.bay.Name = "bay";
            this.bay.Size = new System.Drawing.Size(194, 62);
            this.bay.TabIndex = 8;
            this.bay.Text = "7";
            this.bay.UseVisualStyleBackColor = true;
            this.bay.Click += new System.EventHandler(this.bt_so);
            // 
            // tru
            // 
            this.tru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tru.Location = new System.Drawing.Point(603, 71);
            this.tru.Name = "tru";
            this.tru.Size = new System.Drawing.Size(194, 62);
            this.tru.TabIndex = 7;
            this.tru.Text = "-";
            this.tru.UseVisualStyleBackColor = true;
            this.tru.Click += new System.EventHandler(this.bt_operator);
            // 
            // sau
            // 
            this.sau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sau.Location = new System.Drawing.Point(403, 71);
            this.sau.Name = "sau";
            this.sau.Size = new System.Drawing.Size(194, 62);
            this.sau.TabIndex = 6;
            this.sau.Text = "6";
            this.sau.UseVisualStyleBackColor = true;
            this.sau.Click += new System.EventHandler(this.bt_so);
            // 
            // nam
            // 
            this.nam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nam.Location = new System.Drawing.Point(203, 71);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(194, 62);
            this.nam.TabIndex = 5;
            this.nam.Text = "5";
            this.nam.UseVisualStyleBackColor = true;
            this.nam.Click += new System.EventHandler(this.bt_so);
            // 
            // bon
            // 
            this.bon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bon.Location = new System.Drawing.Point(3, 71);
            this.bon.Name = "bon";
            this.bon.Size = new System.Drawing.Size(194, 62);
            this.bon.TabIndex = 4;
            this.bon.Text = "4";
            this.bon.UseVisualStyleBackColor = true;
            this.bon.Click += new System.EventHandler(this.bt_so);
            // 
            // cong
            // 
            this.cong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cong.Location = new System.Drawing.Point(603, 3);
            this.cong.Name = "cong";
            this.cong.Size = new System.Drawing.Size(194, 62);
            this.cong.TabIndex = 3;
            this.cong.Text = "+";
            this.cong.UseVisualStyleBackColor = true;
            this.cong.Click += new System.EventHandler(this.bt_operator);
            // 
            // ba
            // 
            this.ba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ba.Location = new System.Drawing.Point(403, 3);
            this.ba.Name = "ba";
            this.ba.Size = new System.Drawing.Size(194, 62);
            this.ba.TabIndex = 2;
            this.ba.Text = "3";
            this.ba.UseVisualStyleBackColor = true;
            this.ba.Click += new System.EventHandler(this.bt_so);
            // 
            // hai
            // 
            this.hai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hai.Location = new System.Drawing.Point(203, 3);
            this.hai.Name = "hai";
            this.hai.Size = new System.Drawing.Size(194, 62);
            this.hai.TabIndex = 1;
            this.hai.Text = "2";
            this.hai.UseVisualStyleBackColor = true;
            this.hai.Click += new System.EventHandler(this.bt_so);
            // 
            // mot
            // 
            this.mot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mot.Location = new System.Drawing.Point(3, 3);
            this.mot.Name = "mot";
            this.mot.Size = new System.Drawing.Size(194, 62);
            this.mot.TabIndex = 0;
            this.mot.Text = "1";
            this.mot.UseVisualStyleBackColor = true;
            this.mot.Click += new System.EventHandler(this.bt_so);
            // 
            // ketQua
            // 
            this.ketQua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ketQua.Dock = System.Windows.Forms.DockStyle.Top;
            this.ketQua.Location = new System.Drawing.Point(0, 100);
            this.ketQua.Multiline = true;
            this.ketQua.Name = "ketQua";
            this.ketQua.ReadOnly = true;
            this.ketQua.Size = new System.Drawing.Size(800, 76);
            this.ketQua.TabIndex = 3;
            this.ketQua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ketQua);
            this.Controls.Add(this.hienThi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Máy tính của Bảo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiMàuSắcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiFontToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox hienThi;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button chia;
        private System.Windows.Forms.Button bang;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button khong;
        private System.Windows.Forms.Button nhan;
        private System.Windows.Forms.Button chin;
        private System.Windows.Forms.Button tam;
        private System.Windows.Forms.Button bay;
        private System.Windows.Forms.Button tru;
        private System.Windows.Forms.Button sau;
        private System.Windows.Forms.Button nam;
        private System.Windows.Forms.Button bon;
        private System.Windows.Forms.Button cong;
        private System.Windows.Forms.Button ba;
        private System.Windows.Forms.Button hai;
        private System.Windows.Forms.Button mot;
        private System.Windows.Forms.TextBox ketQua;
    }
}

