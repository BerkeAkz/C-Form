namespace ders12
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
            this.kategoritextBox1 = new System.Windows.Forms.TextBox();
            this.eklebutton1 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.gosterbutton1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = " Kategori Adı:";
            // 
            // kategoritextBox1
            // 
            this.kategoritextBox1.Location = new System.Drawing.Point(148, 40);
            this.kategoritextBox1.Name = "kategoritextBox1";
            this.kategoritextBox1.Size = new System.Drawing.Size(100, 20);
            this.kategoritextBox1.TabIndex = 1;
            // 
            // eklebutton1
            // 
            this.eklebutton1.Location = new System.Drawing.Point(148, 85);
            this.eklebutton1.Name = "eklebutton1";
            this.eklebutton1.Size = new System.Drawing.Size(100, 23);
            this.eklebutton1.TabIndex = 2;
            this.eklebutton1.Text = "Ekle";
            this.eklebutton1.UseVisualStyleBackColor = true;
            this.eklebutton1.Click += new System.EventHandler(this.eklebutton1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(148, 158);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 139);
            this.checkedListBox1.TabIndex = 3;
            // 
            // gosterbutton1
            // 
            this.gosterbutton1.Location = new System.Drawing.Point(148, 359);
            this.gosterbutton1.Name = "gosterbutton1";
            this.gosterbutton1.Size = new System.Drawing.Size(75, 23);
            this.gosterbutton1.TabIndex = 5;
            this.gosterbutton1.Text = "Göster";
            this.gosterbutton1.UseVisualStyleBackColor = true;
            this.gosterbutton1.Click += new System.EventHandler(this.gosterbutton1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(468, 150);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(146, 147);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gosterbutton1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.eklebutton1);
            this.Controls.Add(this.kategoritextBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
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
        private System.Windows.Forms.TextBox kategoritextBox1;
        private System.Windows.Forms.Button eklebutton1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button gosterbutton1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

