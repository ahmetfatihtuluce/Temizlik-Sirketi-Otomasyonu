namespace Temizlik_Otomasyonu
{
    partial class Satislar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_ucret = new System.Windows.Forms.Label();
            this.lbl_toplamucret = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(170, 233);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_ucret
            // 
            this.lbl_ucret.AutoSize = true;
            this.lbl_ucret.Location = new System.Drawing.Point(12, 302);
            this.lbl_ucret.Name = "lbl_ucret";
            this.lbl_ucret.Size = new System.Drawing.Size(80, 13);
            this.lbl_ucret.TabIndex = 1;
            this.lbl_ucret.Text = "Toplam Ucret =";
            // 
            // lbl_toplamucret
            // 
            this.lbl_toplamucret.AutoSize = true;
            this.lbl_toplamucret.Location = new System.Drawing.Point(102, 302);
            this.lbl_toplamucret.Name = "lbl_toplamucret";
            this.lbl_toplamucret.Size = new System.Drawing.Size(13, 13);
            this.lbl_toplamucret.TabIndex = 2;
            this.lbl_toplamucret.Text = "0";
            // 
            // Satislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Temizlik_Otomasyonu.Properties.Resources.image1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(241, 374);
            this.Controls.Add(this.lbl_toplamucret);
            this.Controls.Add(this.lbl_ucret);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Satislar";
            this.Text = "Satislar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Satislar_FormClosing);
            this.Load += new System.EventHandler(this.Satislar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_ucret;
        private System.Windows.Forms.Label lbl_toplamucret;
    }
}