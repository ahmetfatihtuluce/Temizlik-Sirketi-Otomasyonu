namespace Temizlik_Otomasyonu
{
    partial class HizmetEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_hizmet = new System.Windows.Forms.TextBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_ucret = new System.Windows.Forms.TextBox();
            this.txt_adres = new System.Windows.Forms.RichTextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hizmet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ücret";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(104, 27);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(228, 20);
            this.txt_isim.TabIndex = 5;
            // 
            // txt_hizmet
            // 
            this.txt_hizmet.Location = new System.Drawing.Point(104, 63);
            this.txt_hizmet.Name = "txt_hizmet";
            this.txt_hizmet.Size = new System.Drawing.Size(228, 20);
            this.txt_hizmet.TabIndex = 6;
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(104, 98);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(228, 20);
            this.txt_telefon.TabIndex = 7;
            // 
            // txt_ucret
            // 
            this.txt_ucret.Location = new System.Drawing.Point(104, 133);
            this.txt_ucret.Name = "txt_ucret";
            this.txt_ucret.Size = new System.Drawing.Size(228, 20);
            this.txt_ucret.TabIndex = 8;
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(104, 171);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(228, 96);
            this.txt_adres.TabIndex = 10;
            this.txt_adres.Text = "";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(339, 174);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(114, 93);
            this.btn_ekle.TabIndex = 11;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // HizmetEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Temizlik_Otomasyonu.Properties.Resources.image1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(465, 271);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.txt_ucret);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.txt_hizmet);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HizmetEkle";
            this.Text = "HizmetEkle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HizmetEkle_FormClosing);
            this.Load += new System.EventHandler(this.HizmetEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_hizmet;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_ucret;
        private System.Windows.Forms.RichTextBox txt_adres;
        private System.Windows.Forms.Button btn_ekle;
    }
}