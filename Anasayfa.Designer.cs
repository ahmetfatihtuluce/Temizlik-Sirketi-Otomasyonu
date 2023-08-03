namespace Temizlik_Otomasyonu
{
    partial class Anasayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.btn_lisitele = new System.Windows.Forms.Button();
            this.btn_satislar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_lisitele
            // 
            this.btn_lisitele.ImageIndex = 2;
            this.btn_lisitele.ImageList = this.ımageList1;
            this.btn_lisitele.Location = new System.Drawing.Point(168, 12);
            this.btn_lisitele.Name = "btn_lisitele";
            this.btn_lisitele.Size = new System.Drawing.Size(150, 100);
            this.btn_lisitele.TabIndex = 1;
            this.btn_lisitele.Text = "Hizmet Listesi";
            this.btn_lisitele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_lisitele.UseVisualStyleBackColor = true;
            this.btn_lisitele.Click += new System.EventHandler(this.btn_lisitele_Click);
            // 
            // btn_satislar
            // 
            this.btn_satislar.ImageIndex = 6;
            this.btn_satislar.ImageList = this.ımageList1;
            this.btn_satislar.Location = new System.Drawing.Point(333, 12);
            this.btn_satislar.Name = "btn_satislar";
            this.btn_satislar.Size = new System.Drawing.Size(150, 100);
            this.btn_satislar.TabIndex = 2;
            this.btn_satislar.Text = "Satışlar";
            this.btn_satislar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_satislar.UseVisualStyleBackColor = true;
            this.btn_satislar.Click += new System.EventHandler(this.btn_satislar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Temizlik_Otomasyonu.Properties.Resources.image1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(627, 286);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cikis
            // 
            this.btn_cikis.ImageIndex = 5;
            this.btn_cikis.ImageList = this.ımageList1;
            this.btn_cikis.Location = new System.Drawing.Point(489, 12);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(150, 100);
            this.btn_cikis.TabIndex = 5;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.ImageIndex = 1;
            this.btn_ekle.ImageList = this.ımageList1;
            this.btn_ekle.Location = new System.Drawing.Point(12, 12);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(150, 100);
            this.btn_ekle.TabIndex = 6;
            this.btn_ekle.Text = "Hizmet Ekle";
            this.btn_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "image1.jpg");
            this.ımageList1.Images.SetKeyName(1, "logo1.jpg");
            this.ımageList1.Images.SetKeyName(2, "logo2.jpg");
            this.ımageList1.Images.SetKeyName(3, "logo3.jpg");
            this.ımageList1.Images.SetKeyName(4, "Logo4.png");
            this.ımageList1.Images.SetKeyName(5, "exit.png");
            this.ımageList1.Images.SetKeyName(6, "money.jpg");
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(675, 441);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_satislar);
            this.Controls.Add(this.btn_lisitele);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_lisitele;
        private System.Windows.Forms.Button btn_satislar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

