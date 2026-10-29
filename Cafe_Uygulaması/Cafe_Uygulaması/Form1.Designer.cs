namespace Cafe_Uygulaması
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.payButton = new System.Windows.Forms.Button();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hotdogPicture = new System.Windows.Forms.PictureBox();
            this.pancakePicture = new System.Windows.Forms.PictureBox();
            this.pizzaPicture = new System.Windows.Forms.PictureBox();
            this.cupcakePicture = new System.Windows.Forms.PictureBox();
            this.hamburgerPicture = new System.Windows.Forms.PictureBox();
            this.cheesePicture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotdogPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pancakePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupcakePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheesePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.moneyLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 311);
            this.panel1.TabIndex = 0;
            // 
            // moneyLabel
            // 
            this.moneyLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.moneyLabel.Location = new System.Drawing.Point(0, 290);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(125, 21);
            this.moneyLabel.TabIndex = 2;
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Akz Cafe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Cafe_Uygulaması.Properties.Resources.cup_of_drink;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.payButton);
            this.panel2.Controls.Add(this.cartListBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(554, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 311);
            this.panel2.TabIndex = 1;
            // 
            // payButton
            // 
            this.payButton.BackColor = System.Drawing.Color.Lime;
            this.payButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.payButton.FlatAppearance.BorderSize = 0;
            this.payButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payButton.Location = new System.Drawing.Point(0, 269);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(125, 42);
            this.payButton.TabIndex = 1;
            this.payButton.Text = "Öde";
            this.payButton.UseVisualStyleBackColor = false;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // cartListBox
            // 
            this.cartListBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cartListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cartListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.ItemHeight = 18;
            this.cartListBox.Location = new System.Drawing.Point(0, 23);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(125, 252);
            this.cartListBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sipariş Listesi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.hotdogPicture);
            this.panel3.Controls.Add(this.pancakePicture);
            this.panel3.Controls.Add(this.pizzaPicture);
            this.panel3.Controls.Add(this.cupcakePicture);
            this.panel3.Controls.Add(this.hamburgerPicture);
            this.panel3.Controls.Add(this.cheesePicture);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(125, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 311);
            this.panel3.TabIndex = 2;
            // 
            // hotdogPicture
            // 
            this.hotdogPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hotdogPicture.Image = global::Cafe_Uygulaması.Properties.Resources.hot_dog;
            this.hotdogPicture.Location = new System.Drawing.Point(139, 159);
            this.hotdogPicture.Name = "hotdogPicture";
            this.hotdogPicture.Size = new System.Drawing.Size(143, 110);
            this.hotdogPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hotdogPicture.TabIndex = 5;
            this.hotdogPicture.TabStop = false;
            this.hotdogPicture.Click += new System.EventHandler(this.hotdogPicture_Click);
            // 
            // pancakePicture
            // 
            this.pancakePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pancakePicture.Image = global::Cafe_Uygulaması.Properties.Resources.pancake;
            this.pancakePicture.Location = new System.Drawing.Point(282, 159);
            this.pancakePicture.Name = "pancakePicture";
            this.pancakePicture.Size = new System.Drawing.Size(143, 110);
            this.pancakePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pancakePicture.TabIndex = 4;
            this.pancakePicture.TabStop = false;
            this.pancakePicture.Click += new System.EventHandler(this.pancakePicture_Click);
            // 
            // pizzaPicture
            // 
            this.pizzaPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pizzaPicture.Image = global::Cafe_Uygulaması.Properties.Resources.pizza_slice;
            this.pizzaPicture.Location = new System.Drawing.Point(0, 159);
            this.pizzaPicture.Name = "pizzaPicture";
            this.pizzaPicture.Size = new System.Drawing.Size(143, 110);
            this.pizzaPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pizzaPicture.TabIndex = 3;
            this.pizzaPicture.TabStop = false;
            this.pizzaPicture.Click += new System.EventHandler(this.pizzaPicture_Click);
            // 
            // cupcakePicture
            // 
            this.cupcakePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cupcakePicture.Image = global::Cafe_Uygulaması.Properties.Resources.cupcake;
            this.cupcakePicture.Location = new System.Drawing.Point(139, 0);
            this.cupcakePicture.Name = "cupcakePicture";
            this.cupcakePicture.Size = new System.Drawing.Size(143, 110);
            this.cupcakePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cupcakePicture.TabIndex = 2;
            this.cupcakePicture.TabStop = false;
            this.cupcakePicture.Click += new System.EventHandler(this.cupcakePicture_Click);
            // 
            // hamburgerPicture
            // 
            this.hamburgerPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hamburgerPicture.Image = global::Cafe_Uygulaması.Properties.Resources.burger;
            this.hamburgerPicture.Location = new System.Drawing.Point(282, 0);
            this.hamburgerPicture.Name = "hamburgerPicture";
            this.hamburgerPicture.Size = new System.Drawing.Size(143, 110);
            this.hamburgerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hamburgerPicture.TabIndex = 1;
            this.hamburgerPicture.TabStop = false;
            this.hamburgerPicture.Click += new System.EventHandler(this.hamburgerPicture_Click);
            // 
            // cheesePicture
            // 
            this.cheesePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cheesePicture.Image = global::Cafe_Uygulaması.Properties.Resources.cheese__1_;
            this.cheesePicture.Location = new System.Drawing.Point(0, 0);
            this.cheesePicture.Name = "cheesePicture";
            this.cheesePicture.Size = new System.Drawing.Size(143, 110);
            this.cheesePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cheesePicture.TabIndex = 0;
            this.cheesePicture.TabStop = false;
            this.cheesePicture.Click += new System.EventHandler(this.cheesePicture_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 311);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Akz Cafe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hotdogPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pancakePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupcakePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheesePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox cupcakePicture;
        private System.Windows.Forms.PictureBox hamburgerPicture;
        private System.Windows.Forms.PictureBox cheesePicture;
        private System.Windows.Forms.PictureBox hotdogPicture;
        private System.Windows.Forms.PictureBox pancakePicture;
        private System.Windows.Forms.PictureBox pizzaPicture;
        private System.Windows.Forms.Button payButton;
    }
}

