namespace ders10
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.eklebutton1 = new System.Windows.Forms.Button();
            this.cikartbutton2 = new System.Windows.Forms.Button();
            this.ogrenciList = new System.Windows.Forms.ListBox();
            this.temizlebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adınız:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 26);
            this.textBox1.TabIndex = 1;
            // 
            // eklebutton1
            // 
            this.eklebutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.eklebutton1.Location = new System.Drawing.Point(42, 84);
            this.eklebutton1.Name = "eklebutton1";
            this.eklebutton1.Size = new System.Drawing.Size(75, 37);
            this.eklebutton1.TabIndex = 2;
            this.eklebutton1.Text = "Ekle";
            this.eklebutton1.UseVisualStyleBackColor = false;
            this.eklebutton1.Click += new System.EventHandler(this.eklebutton1_Click);
            // 
            // cikartbutton2
            // 
            this.cikartbutton2.BackColor = System.Drawing.Color.Red;
            this.cikartbutton2.Location = new System.Drawing.Point(148, 84);
            this.cikartbutton2.Name = "cikartbutton2";
            this.cikartbutton2.Size = new System.Drawing.Size(75, 37);
            this.cikartbutton2.TabIndex = 3;
            this.cikartbutton2.Text = "Çıkart";
            this.cikartbutton2.UseVisualStyleBackColor = false;
            this.cikartbutton2.Click += new System.EventHandler(this.cikartbutton2_Click);
            // 
            // ogrenciList
            // 
            this.ogrenciList.FormattingEnabled = true;
            this.ogrenciList.ItemHeight = 20;
            this.ogrenciList.Location = new System.Drawing.Point(306, 37);
            this.ogrenciList.Name = "ogrenciList";
            this.ogrenciList.Size = new System.Drawing.Size(187, 224);
            this.ogrenciList.TabIndex = 4;
            // 
            // temizlebutton
            // 
            this.temizlebutton.BackColor = System.Drawing.Color.IndianRed;
            this.temizlebutton.Location = new System.Drawing.Point(306, 290);
            this.temizlebutton.Name = "temizlebutton";
            this.temizlebutton.Size = new System.Drawing.Size(187, 35);
            this.temizlebutton.TabIndex = 5;
            this.temizlebutton.Text = "Temizle";
            this.temizlebutton.UseVisualStyleBackColor = false;
            this.temizlebutton.Click += new System.EventHandler(this.temizlebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(581, 353);
            this.Controls.Add(this.temizlebutton);
            this.Controls.Add(this.ogrenciList);
            this.Controls.Add(this.cikartbutton2);
            this.Controls.Add(this.eklebutton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button eklebutton1;
        private System.Windows.Forms.Button cikartbutton2;
        private System.Windows.Forms.ListBox ogrenciList;
        private System.Windows.Forms.Button temizlebutton;
    }
}

