namespace RssHaberÇekme
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
            this.btnanadoluajansı = new System.Windows.Forms.Button();
            this.btnahaber = new System.Windows.Forms.Button();
            this.btnfb = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnanadoluajansı
            // 
            this.btnanadoluajansı.Location = new System.Drawing.Point(12, 503);
            this.btnanadoluajansı.Name = "btnanadoluajansı";
            this.btnanadoluajansı.Size = new System.Drawing.Size(136, 41);
            this.btnanadoluajansı.TabIndex = 0;
            this.btnanadoluajansı.Text = "Anadolu Ajansı";
            this.btnanadoluajansı.UseVisualStyleBackColor = true;
            this.btnanadoluajansı.Click += new System.EventHandler(this.btnanadoluajansı_Click);
            // 
            // btnahaber
            // 
            this.btnahaber.Location = new System.Drawing.Point(167, 503);
            this.btnahaber.Name = "btnahaber";
            this.btnahaber.Size = new System.Drawing.Size(136, 41);
            this.btnahaber.TabIndex = 0;
            this.btnahaber.Text = "A Haber";
            this.btnahaber.UseVisualStyleBackColor = true;
            this.btnahaber.Click += new System.EventHandler(this.btnahaber_Click);
            // 
            // btnfb
            // 
            this.btnfb.Location = new System.Drawing.Point(326, 503);
            this.btnfb.Name = "btnfb";
            this.btnfb.Size = new System.Drawing.Size(136, 41);
            this.btnfb.TabIndex = 0;
            this.btnfb.Text = "Fenerkolik";
            this.btnfb.UseVisualStyleBackColor = true;
            this.btnfb.Click += new System.EventHandler(this.btnfb_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1061, 446);
            this.listBox1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RssHaberÇekme.Properties.Resources.fb;
            this.pictureBox3.Location = new System.Drawing.Point(326, 462);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(136, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RssHaberÇekme.Properties.Resources.a;
            this.pictureBox2.Location = new System.Drawing.Point(167, 462);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RssHaberÇekme.Properties.Resources.aa;
            this.pictureBox1.Location = new System.Drawing.Point(12, 462);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 547);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnfb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnahaber);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnanadoluajansı);
            this.Name = "Form1";
            this.Text = "Rss ile haber başlıkları çekme ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnanadoluajansı;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnahaber;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnfb;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

