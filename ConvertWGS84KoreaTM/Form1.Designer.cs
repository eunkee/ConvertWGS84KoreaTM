
namespace ConvertWGS84KoreaTM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxTMLat = new System.Windows.Forms.TextBox();
            this.TextBoxTMLon = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TextBoxResultWGSLon = new System.Windows.Forms.TextBox();
            this.TextBoxResultWGSLat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtonKoreaTMtoWGS84 = new System.Windows.Forms.Button();
            this.ButtonWGS84toKoreaTM = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxResultTMLon = new System.Windows.Forms.TextBox();
            this.TextBoxResultTMLat = new System.Windows.Forms.TextBox();
            this.TextBoxWGSLon = new System.Windows.Forms.TextBox();
            this.TextBoxWGSLat = new System.Windows.Forms.TextBox();
            this.ButtonClearKoreaTMtoWGS84 = new System.Windows.Forms.Button();
            this.ButtonClearWGS84toKoreaTM = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.ButtonCopyResultWGS84 = new System.Windows.Forms.Button();
            this.ButtonCopyResultTM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korea Tm to WGS84";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "WGS84 to Korea Tm";
            // 
            // TextBoxTMLat
            // 
            this.TextBoxTMLat.Location = new System.Drawing.Point(102, 66);
            this.TextBoxTMLat.Name = "TextBoxTMLat";
            this.TextBoxTMLat.Size = new System.Drawing.Size(146, 23);
            this.TextBoxTMLat.TabIndex = 2;
            // 
            // TextBoxTMLon
            // 
            this.TextBoxTMLon.Location = new System.Drawing.Point(102, 104);
            this.TextBoxTMLon.Name = "TextBoxTMLon";
            this.TextBoxTMLon.Size = new System.Drawing.Size(146, 23);
            this.TextBoxTMLon.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bessel",
            "GRS80"});
            this.comboBox1.Location = new System.Drawing.Point(226, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // TextBoxResultWGSLon
            // 
            this.TextBoxResultWGSLon.Enabled = false;
            this.TextBoxResultWGSLon.Location = new System.Drawing.Point(431, 104);
            this.TextBoxResultWGSLon.Name = "TextBoxResultWGSLon";
            this.TextBoxResultWGSLon.Size = new System.Drawing.Size(146, 23);
            this.TextBoxResultWGSLon.TabIndex = 6;
            // 
            // TextBoxResultWGSLat
            // 
            this.TextBoxResultWGSLat.Enabled = false;
            this.TextBoxResultWGSLat.Location = new System.Drawing.Point(431, 66);
            this.TextBoxResultWGSLat.Name = "TextBoxResultWGSLat";
            this.TextBoxResultWGSLat.Size = new System.Drawing.Size(146, 23);
            this.TextBoxResultWGSLat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "WGS84";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "서부",
            "중부",
            "동부",
            "동해",
            "제주도"});
            this.comboBox2.Location = new System.Drawing.Point(412, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(108, 23);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(445, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "* 서부: 124W - 126W / 중부: 126W - 128W / 동부 128W - 130W / 동해 130W -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Korea Tm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "타원체";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(375, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "원점";
            // 
            // ButtonKoreaTMtoWGS84
            // 
            this.ButtonKoreaTMtoWGS84.Location = new System.Drawing.Point(258, 76);
            this.ButtonKoreaTMtoWGS84.Name = "ButtonKoreaTMtoWGS84";
            this.ButtonKoreaTMtoWGS84.Size = new System.Drawing.Size(94, 45);
            this.ButtonKoreaTMtoWGS84.TabIndex = 13;
            this.ButtonKoreaTMtoWGS84.Text = "Convert to ";
            this.ButtonKoreaTMtoWGS84.UseVisualStyleBackColor = true;
            this.ButtonKoreaTMtoWGS84.Click += new System.EventHandler(this.ButtonKoreaTMtoWGS84_Click);
            // 
            // ButtonWGS84toKoreaTM
            // 
            this.ButtonWGS84toKoreaTM.Location = new System.Drawing.Point(258, 260);
            this.ButtonWGS84toKoreaTM.Name = "ButtonWGS84toKoreaTM";
            this.ButtonWGS84toKoreaTM.Size = new System.Drawing.Size(94, 45);
            this.ButtonWGS84toKoreaTM.TabIndex = 20;
            this.ButtonWGS84toKoreaTM.Text = "Convert to ";
            this.ButtonWGS84toKoreaTM.UseVisualStyleBackColor = true;
            this.ButtonWGS84toKoreaTM.Click += new System.EventHandler(this.ButtonWGS84toKoreaTM_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Korea Tm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "WGS84";
            // 
            // TextBoxResultTMLon
            // 
            this.TextBoxResultTMLon.Enabled = false;
            this.TextBoxResultTMLon.Location = new System.Drawing.Point(431, 292);
            this.TextBoxResultTMLon.Name = "TextBoxResultTMLon";
            this.TextBoxResultTMLon.Size = new System.Drawing.Size(146, 23);
            this.TextBoxResultTMLon.TabIndex = 17;
            // 
            // TextBoxResultTMLat
            // 
            this.TextBoxResultTMLat.Enabled = false;
            this.TextBoxResultTMLat.Location = new System.Drawing.Point(431, 254);
            this.TextBoxResultTMLat.Name = "TextBoxResultTMLat";
            this.TextBoxResultTMLat.Size = new System.Drawing.Size(146, 23);
            this.TextBoxResultTMLat.TabIndex = 16;
            // 
            // TextBoxWGSLon
            // 
            this.TextBoxWGSLon.Location = new System.Drawing.Point(102, 292);
            this.TextBoxWGSLon.Name = "TextBoxWGSLon";
            this.TextBoxWGSLon.Size = new System.Drawing.Size(146, 23);
            this.TextBoxWGSLon.TabIndex = 15;
            // 
            // TextBoxWGSLat
            // 
            this.TextBoxWGSLat.Location = new System.Drawing.Point(102, 254);
            this.TextBoxWGSLat.Name = "TextBoxWGSLat";
            this.TextBoxWGSLat.Size = new System.Drawing.Size(146, 23);
            this.TextBoxWGSLat.TabIndex = 14;
            // 
            // ButtonClearKoreaTMtoWGS84
            // 
            this.ButtonClearKoreaTMtoWGS84.Location = new System.Drawing.Point(598, 61);
            this.ButtonClearKoreaTMtoWGS84.Name = "ButtonClearKoreaTMtoWGS84";
            this.ButtonClearKoreaTMtoWGS84.Size = new System.Drawing.Size(124, 30);
            this.ButtonClearKoreaTMtoWGS84.TabIndex = 21;
            this.ButtonClearKoreaTMtoWGS84.Text = "Clear";
            this.ButtonClearKoreaTMtoWGS84.UseVisualStyleBackColor = true;
            this.ButtonClearKoreaTMtoWGS84.Click += new System.EventHandler(this.ButtonClearKoreaTMtoWGS84_Click);
            // 
            // ButtonClearWGS84toKoreaTM
            // 
            this.ButtonClearWGS84toKoreaTM.Location = new System.Drawing.Point(598, 247);
            this.ButtonClearWGS84toKoreaTM.Name = "ButtonClearWGS84toKoreaTM";
            this.ButtonClearWGS84toKoreaTM.Size = new System.Drawing.Size(124, 30);
            this.ButtonClearWGS84toKoreaTM.TabIndex = 22;
            this.ButtonClearWGS84toKoreaTM.Text = "Clear";
            this.ButtonClearWGS84toKoreaTM.UseVisualStyleBackColor = true;
            this.ButtonClearWGS84toKoreaTM.Click += new System.EventHandler(this.ButtonClearWGS84toKoreaTM_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(375, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "원점";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(178, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "타원체";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "서부",
            "중부",
            "동부",
            "동해",
            "제주도"});
            this.comboBox4.Location = new System.Drawing.Point(412, 210);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(108, 23);
            this.comboBox4.TabIndex = 24;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.ComboBox4_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Bessel",
            "GRS80"});
            this.comboBox3.Location = new System.Drawing.Point(226, 210);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(108, 23);
            this.comboBox3.TabIndex = 23;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
            // 
            // ButtonCopyResultWGS84
            // 
            this.ButtonCopyResultWGS84.Location = new System.Drawing.Point(598, 104);
            this.ButtonCopyResultWGS84.Name = "ButtonCopyResultWGS84";
            this.ButtonCopyResultWGS84.Size = new System.Drawing.Size(124, 30);
            this.ButtonCopyResultWGS84.TabIndex = 27;
            this.ButtonCopyResultWGS84.Text = "Copy to Clipboard";
            this.ButtonCopyResultWGS84.UseVisualStyleBackColor = true;
            this.ButtonCopyResultWGS84.Click += new System.EventHandler(this.ButtonCopyResultWGS84_Click);
            // 
            // ButtonCopyResultTM
            // 
            this.ButtonCopyResultTM.Location = new System.Drawing.Point(598, 292);
            this.ButtonCopyResultTM.Name = "ButtonCopyResultTM";
            this.ButtonCopyResultTM.Size = new System.Drawing.Size(124, 30);
            this.ButtonCopyResultTM.TabIndex = 28;
            this.ButtonCopyResultTM.Text = "Copy to Clipboard";
            this.ButtonCopyResultTM.UseVisualStyleBackColor = true;
            this.ButtonCopyResultTM.Click += new System.EventHandler(this.ButtonCopyResultTM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 346);
            this.Controls.Add(this.ButtonCopyResultTM);
            this.Controls.Add(this.ButtonCopyResultWGS84);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.ButtonClearWGS84toKoreaTM);
            this.Controls.Add(this.ButtonClearKoreaTMtoWGS84);
            this.Controls.Add(this.ButtonWGS84toKoreaTM);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextBoxResultTMLon);
            this.Controls.Add(this.TextBoxResultTMLat);
            this.Controls.Add(this.TextBoxWGSLon);
            this.Controls.Add(this.TextBoxWGSLat);
            this.Controls.Add(this.ButtonKoreaTMtoWGS84);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxResultWGSLon);
            this.Controls.Add(this.TextBoxResultWGSLat);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TextBoxTMLon);
            this.Controls.Add(this.TextBoxTMLat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Convert WGS84 KoreaTM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxTMLat;
        private System.Windows.Forms.TextBox TextBoxTMLon;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TextBoxResultWGSLon;
        private System.Windows.Forms.TextBox TextBoxResultWGSLat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ButtonKoreaTMtoWGS84;
        private System.Windows.Forms.Button ButtonWGS84toKoreaTM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBoxResultTMLon;
        private System.Windows.Forms.TextBox TextBoxResultTMLat;
        private System.Windows.Forms.TextBox TextBoxWGSLon;
        private System.Windows.Forms.TextBox TextBoxWGSLat;
        private System.Windows.Forms.Button ButtonClearKoreaTMtoWGS84;
        private System.Windows.Forms.Button ButtonClearWGS84toKoreaTM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button ButtonCopyResultWGS84;
        private System.Windows.Forms.Button ButtonCopyResultTM;
    }
}

