namespace ders5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Başlık = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Konu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Içerik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslikTextBox = new System.Windows.Forms.TextBox();
            this.basliklabel = new System.Windows.Forms.Label();
            this.konuLabel = new System.Windows.Forms.Label();
            this.konuTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.icerikRichTextBox = new System.Windows.Forms.RichTextBox();
            this.veriEkleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Başlık,
            this.Konu,
            this.Içerik});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Başlık
            // 
            this.Başlık.HeaderText = "Başlık";
            this.Başlık.Name = "Başlık";
            this.Başlık.Width = 130;
            // 
            // Konu
            // 
            this.Konu.HeaderText = "Konu";
            this.Konu.Name = "Konu";
            this.Konu.Width = 130;
            // 
            // Içerik
            // 
            this.Içerik.HeaderText = "Içerik";
            this.Içerik.Name = "Içerik";
            this.Içerik.Width = 500;
            // 
            // baslikTextBox
            // 
            this.baslikTextBox.Location = new System.Drawing.Point(42, 178);
            this.baslikTextBox.Name = "baslikTextBox";
            this.baslikTextBox.Size = new System.Drawing.Size(741, 20);
            this.baslikTextBox.TabIndex = 1;
            // 
            // basliklabel
            // 
            this.basliklabel.AutoSize = true;
            this.basliklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basliklabel.Location = new System.Drawing.Point(38, 155);
            this.basliklabel.Name = "basliklabel";
            this.basliklabel.Size = new System.Drawing.Size(55, 20);
            this.basliklabel.TabIndex = 4;
            this.basliklabel.Text = "Başlık:";
            // 
            // konuLabel
            // 
            this.konuLabel.AutoSize = true;
            this.konuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.konuLabel.Location = new System.Drawing.Point(43, 205);
            this.konuLabel.Name = "konuLabel";
            this.konuLabel.Size = new System.Drawing.Size(50, 20);
            this.konuLabel.TabIndex = 6;
            this.konuLabel.Text = "Konu:";
            // 
            // konuTextBox
            // 
            this.konuTextBox.Location = new System.Drawing.Point(42, 228);
            this.konuTextBox.Name = "konuTextBox";
            this.konuTextBox.Size = new System.Drawing.Size(741, 20);
            this.konuTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Içerik:";
            // 
            // icerikRichTextBox
            // 
            this.icerikRichTextBox.Location = new System.Drawing.Point(42, 289);
            this.icerikRichTextBox.Name = "icerikRichTextBox";
            this.icerikRichTextBox.Size = new System.Drawing.Size(741, 96);
            this.icerikRichTextBox.TabIndex = 8;
            this.icerikRichTextBox.Text = "";
            // 
            // veriEkleButton
            // 
            this.veriEkleButton.Location = new System.Drawing.Point(42, 402);
            this.veriEkleButton.Name = "veriEkleButton";
            this.veriEkleButton.Size = new System.Drawing.Size(741, 36);
            this.veriEkleButton.TabIndex = 9;
            this.veriEkleButton.Text = "Ekle";
            this.veriEkleButton.UseVisualStyleBackColor = true;
            this.veriEkleButton.Click += new System.EventHandler(this.veriEkleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.veriEkleButton);
            this.Controls.Add(this.icerikRichTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.konuLabel);
            this.Controls.Add(this.konuTextBox);
            this.Controls.Add(this.basliklabel);
            this.Controls.Add(this.baslikTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Başlık;
        private System.Windows.Forms.DataGridViewTextBoxColumn Konu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Içerik;
        private System.Windows.Forms.TextBox baslikTextBox;
        private System.Windows.Forms.Label basliklabel;
        private System.Windows.Forms.Label konuLabel;
        private System.Windows.Forms.TextBox konuTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox icerikRichTextBox;
        private System.Windows.Forms.Button veriEkleButton;
    }
}

