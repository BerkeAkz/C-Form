namespace ders_8
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toplamTutar = new System.Windows.Forms.Label();
            this.burgercheckBox1 = new System.Windows.Forms.CheckBox();
            this.pizzacheckBox2 = new System.Windows.Forms.CheckBox();
            this.donercheckBox3 = new System.Windows.Forms.CheckBox();
            this.LahmacuncheckBox4 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.ayrancheckBox1 = new System.Windows.Forms.CheckBox();
            this.sodacheckBox2 = new System.Windows.Forms.CheckBox();
            this.sucheckBox3 = new System.Windows.Forms.CheckBox();
            this.SicakcheckBox4 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(446, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(442, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Toplam Tutar:";
            // 
            // toplamTutar
            // 
            this.toplamTutar.AutoSize = true;
            this.toplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamTutar.Location = new System.Drawing.Point(561, 199);
            this.toplamTutar.Name = "toplamTutar";
            this.toplamTutar.Size = new System.Drawing.Size(0, 20);
            this.toplamTutar.TabIndex = 5;
            // 
            // burgercheckBox1
            // 
            this.burgercheckBox1.AutoSize = true;
            this.burgercheckBox1.Location = new System.Drawing.Point(15, 37);
            this.burgercheckBox1.Name = "burgercheckBox1";
            this.burgercheckBox1.Size = new System.Drawing.Size(115, 17);
            this.burgercheckBox1.TabIndex = 0;
            this.burgercheckBox1.Text = "Hamburger(200TL)";
            this.burgercheckBox1.UseVisualStyleBackColor = true;
            // 
            // pizzacheckBox2
            // 
            this.pizzacheckBox2.AutoSize = true;
            this.pizzacheckBox2.Location = new System.Drawing.Point(15, 87);
            this.pizzacheckBox2.Name = "pizzacheckBox2";
            this.pizzacheckBox2.Size = new System.Drawing.Size(84, 17);
            this.pizzacheckBox2.TabIndex = 1;
            this.pizzacheckBox2.Text = "Pizza(350Tl)";
            this.pizzacheckBox2.UseVisualStyleBackColor = true;
            // 
            // donercheckBox3
            // 
            this.donercheckBox3.AutoSize = true;
            this.donercheckBox3.Location = new System.Drawing.Point(15, 136);
            this.donercheckBox3.Name = "donercheckBox3";
            this.donercheckBox3.Size = new System.Drawing.Size(82, 17);
            this.donercheckBox3.TabIndex = 2;
            this.donercheckBox3.Text = "Döner(80Tl)";
            this.donercheckBox3.UseVisualStyleBackColor = true;
            // 
            // LahmacuncheckBox4
            // 
            this.LahmacuncheckBox4.AutoSize = true;
            this.LahmacuncheckBox4.Location = new System.Drawing.Point(15, 190);
            this.LahmacuncheckBox4.Name = "LahmacuncheckBox4";
            this.LahmacuncheckBox4.Size = new System.Drawing.Size(113, 17);
            this.LahmacuncheckBox4.TabIndex = 3;
            this.LahmacuncheckBox4.Text = "Lahmacun(120TL)";
            this.LahmacuncheckBox4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.LahmacuncheckBox4);
            this.groupBox1.Controls.Add(this.burgercheckBox1);
            this.groupBox1.Controls.Add(this.donercheckBox3);
            this.groupBox1.Controls.Add(this.pizzacheckBox2);
            this.groupBox1.Location = new System.Drawing.Point(6, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 246);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yiyecekler";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(431, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İndirim";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Controls.Add(this.SicakcheckBox4);
            this.groupBox3.Controls.Add(this.sucheckBox3);
            this.groupBox3.Controls.Add(this.sodacheckBox2);
            this.groupBox3.Controls.Add(this.ayrancheckBox1);
            this.groupBox3.Location = new System.Drawing.Point(236, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 246);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İçecekler";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Öğrenci İndirimi (%20)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 58);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(120, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Kamu Çalışanı (%10)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // ayrancheckBox1
            // 
            this.ayrancheckBox1.AutoSize = true;
            this.ayrancheckBox1.Location = new System.Drawing.Point(17, 37);
            this.ayrancheckBox1.Name = "ayrancheckBox1";
            this.ayrancheckBox1.Size = new System.Drawing.Size(87, 17);
            this.ayrancheckBox1.TabIndex = 0;
            this.ayrancheckBox1.Text = "Ayran (15TL)";
            this.ayrancheckBox1.UseVisualStyleBackColor = true;
            // 
            // sodacheckBox2
            // 
            this.sodacheckBox2.AutoSize = true;
            this.sodacheckBox2.Location = new System.Drawing.Point(17, 87);
            this.sodacheckBox2.Name = "sodacheckBox2";
            this.sodacheckBox2.Size = new System.Drawing.Size(81, 17);
            this.sodacheckBox2.TabIndex = 1;
            this.sodacheckBox2.Text = "Soda (15Tl)";
            this.sodacheckBox2.UseVisualStyleBackColor = true;
            // 
            // sucheckBox3
            // 
            this.sucheckBox3.AutoSize = true;
            this.sucheckBox3.Location = new System.Drawing.Point(17, 136);
            this.sucheckBox3.Name = "sucheckBox3";
            this.sucheckBox3.Size = new System.Drawing.Size(69, 17);
            this.sucheckBox3.TabIndex = 2;
            this.sucheckBox3.Text = "Su (10Tl)";
            this.sucheckBox3.UseVisualStyleBackColor = true;
            // 
            // SicakcheckBox4
            // 
            this.SicakcheckBox4.AutoSize = true;
            this.SicakcheckBox4.Location = new System.Drawing.Point(17, 190);
            this.SicakcheckBox4.Name = "SicakcheckBox4";
            this.SicakcheckBox4.Size = new System.Drawing.Size(128, 17);
            this.SicakcheckBox4.TabIndex = 3;
            this.SicakcheckBox4.Text = "Sıcak Çikolata (80TL)";
            this.SicakcheckBox4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(643, 299);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toplamTutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox LahmacuncheckBox4;
        private System.Windows.Forms.CheckBox donercheckBox3;
        private System.Windows.Forms.CheckBox pizzacheckBox2;
        private System.Windows.Forms.CheckBox burgercheckBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label toplamTutar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox SicakcheckBox4;
        private System.Windows.Forms.CheckBox sucheckBox3;
        private System.Windows.Forms.CheckBox sodacheckBox2;
        private System.Windows.Forms.CheckBox ayrancheckBox1;
    }
}

