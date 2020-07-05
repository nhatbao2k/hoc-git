namespace buttomGUI
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
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cong = new System.Windows.Forms.Button();
            this.tru = new System.Windows.Forms.Button();
            this.nhan = new System.Windows.Forms.Button();
            this.chia = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.Exits = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.KQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thực hiện các phép tính";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số n:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập số m:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết quả";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(255, 253);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 17);
            this.linkLabel1.TabIndex = 4;
            // 
            // cong
            // 
            this.cong.Location = new System.Drawing.Point(69, 309);
            this.cong.Name = "cong";
            this.cong.Size = new System.Drawing.Size(75, 23);
            this.cong.TabIndex = 5;
            this.cong.Text = "+";
            this.cong.UseVisualStyleBackColor = true;
            this.cong.Click += new System.EventHandler(this.cong_Click);
            // 
            // tru
            // 
            this.tru.Location = new System.Drawing.Point(230, 309);
            this.tru.Name = "tru";
            this.tru.Size = new System.Drawing.Size(75, 23);
            this.tru.TabIndex = 6;
            this.tru.Text = "-";
            this.tru.UseVisualStyleBackColor = true;
            this.tru.Click += new System.EventHandler(this.tru_Click);
            // 
            // nhan
            // 
            this.nhan.Location = new System.Drawing.Point(395, 308);
            this.nhan.Name = "nhan";
            this.nhan.Size = new System.Drawing.Size(75, 23);
            this.nhan.TabIndex = 7;
            this.nhan.Text = "*";
            this.nhan.UseVisualStyleBackColor = true;
            this.nhan.Click += new System.EventHandler(this.nhan_Click);
            // 
            // chia
            // 
            this.chia.Location = new System.Drawing.Point(539, 309);
            this.chia.Name = "chia";
            this.chia.Size = new System.Drawing.Size(75, 23);
            this.chia.TabIndex = 8;
            this.chia.Text = "/";
            this.chia.UseVisualStyleBackColor = true;
            this.chia.Click += new System.EventHandler(this.chia_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(693, 308);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 9;
            this.xoa.Text = "xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // Exits
            // 
            this.Exits.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exits.Location = new System.Drawing.Point(693, 378);
            this.Exits.Name = "Exits";
            this.Exits.Size = new System.Drawing.Size(75, 23);
            this.Exits.TabIndex = 10;
            this.Exits.Text = "thoát";
            this.Exits.UseVisualStyleBackColor = true;
            this.Exits.Click += new System.EventHandler(this.Exits_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 22);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(246, 22);
            this.textBox2.TabIndex = 12;
            // 
            // KQ
            // 
            this.KQ.AllowDrop = true;
            this.KQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.KQ.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.KQ.FlatAppearance.BorderSize = 2;
            this.KQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KQ.Location = new System.Drawing.Point(171, 234);
            this.KQ.Name = "KQ";
            this.KQ.Size = new System.Drawing.Size(246, 36);
            this.KQ.TabIndex = 13;
            this.KQ.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.Exits;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KQ);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Exits);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.chia);
            this.Controls.Add(this.nhan);
            this.Controls.Add(this.tru);
            this.Controls.Add(this.cong);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button cong;
        private System.Windows.Forms.Button tru;
        private System.Windows.Forms.Button nhan;
        private System.Windows.Forms.Button chia;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button Exits;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button KQ;
    }
}

