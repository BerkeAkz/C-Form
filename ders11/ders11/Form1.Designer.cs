namespace ders11
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
            this.derslerListBox = new System.Windows.Forms.ListBox();
            this.secilenDersler = new System.Windows.Forms.ListBox();
            this.eklebutton1 = new System.Windows.Forms.Button();
            this.cıkartbutton2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // derslerListBox
            // 
            this.derslerListBox.FormattingEnabled = true;
            this.derslerListBox.Location = new System.Drawing.Point(108, 50);
            this.derslerListBox.Name = "derslerListBox";
            this.derslerListBox.Size = new System.Drawing.Size(120, 173);
            this.derslerListBox.TabIndex = 0;
            // 
            // secilenDersler
            // 
            this.secilenDersler.FormattingEnabled = true;
            this.secilenDersler.Location = new System.Drawing.Point(509, 50);
            this.secilenDersler.Name = "secilenDersler";
            this.secilenDersler.Size = new System.Drawing.Size(120, 173);
            this.secilenDersler.TabIndex = 1;
            // 
            // eklebutton1
            // 
            this.eklebutton1.Location = new System.Drawing.Point(328, 73);
            this.eklebutton1.Name = "eklebutton1";
            this.eklebutton1.Size = new System.Drawing.Size(75, 23);
            this.eklebutton1.TabIndex = 2;
            this.eklebutton1.Text = "Ekle>>>";
            this.eklebutton1.UseVisualStyleBackColor = true;
            this.eklebutton1.Click += new System.EventHandler(this.eklebutton1_Click);
            // 
            // cıkartbutton2
            // 
            this.cıkartbutton2.Location = new System.Drawing.Point(328, 156);
            this.cıkartbutton2.Name = "cıkartbutton2";
            this.cıkartbutton2.Size = new System.Drawing.Size(75, 23);
            this.cıkartbutton2.TabIndex = 3;
            this.cıkartbutton2.Text = "Çıkart<<<";
            this.cıkartbutton2.UseVisualStyleBackColor = true;
            this.cıkartbutton2.Click += new System.EventHandler(this.cıkartbutton2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(443, 267);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(105, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Eklemek Veya Çıkartmak İstediğiniz Dersi Yazın:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cıkartbutton2);
            this.Controls.Add(this.eklebutton1);
            this.Controls.Add(this.secilenDersler);
            this.Controls.Add(this.derslerListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox derslerListBox;
        private System.Windows.Forms.ListBox secilenDersler;
        private System.Windows.Forms.Button eklebutton1;
        private System.Windows.Forms.Button cıkartbutton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

