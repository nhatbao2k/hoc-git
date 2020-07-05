namespace Nhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_1 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbb_Lop = new System.Windows.Forms.ComboBox();
            this.cbb_tenSV = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(89, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 254);
            this.panel1.TabIndex = 0;
            // 
            // bt_1
            // 
            this.bt_1.Location = new System.Drawing.Point(8, 121);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(75, 58);
            this.bt_1.TabIndex = 1;
            this.bt_1.Text = "button1";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // bt_2
            // 
            this.bt_2.Location = new System.Drawing.Point(8, 204);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(75, 58);
            this.bt_2.TabIndex = 2;
            this.bt_2.Text = "button2";
            this.bt_2.UseVisualStyleBackColor = true;
            this.bt_2.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(267, 132);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(470, 254);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 5;
            // 
            // cbb_Lop
            // 
            this.cbb_Lop.FormattingEnabled = true;
            this.cbb_Lop.Location = new System.Drawing.Point(422, 54);
            this.cbb_Lop.Name = "cbb_Lop";
            this.cbb_Lop.Size = new System.Drawing.Size(121, 24);
            this.cbb_Lop.TabIndex = 6;
            this.cbb_Lop.SelectedIndexChanged += new System.EventHandler(this.cbb_Lop_SelectedIndexChanged);
            // 
            // cbb_tenSV
            // 
            this.cbb_tenSV.FormattingEnabled = true;
            this.cbb_tenSV.Location = new System.Drawing.Point(609, 54);
            this.cbb_tenSV.Name = "cbb_tenSV";
            this.cbb_tenSV.Size = new System.Drawing.Size(121, 24);
            this.cbb_tenSV.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbb_tenSV);
            this.Controls.Add(this.cbb_Lop);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.bt_2);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbb_Lop;
        private System.Windows.Forms.ComboBox cbb_tenSV;
    }
}

