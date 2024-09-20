namespace entity_projem
{
    partial class kitaplık
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
            this.label1kitap_id = new System.Windows.Forms.Label();
            this.label2baslık = new System.Windows.Forms.Label();
            this.label3yazar = new System.Windows.Forms.Label();
            this.label4yayınlanma_yılı = new System.Windows.Forms.Label();
            this.label5tur = new System.Windows.Forms.Label();
            this.textBox1kitap_id = new System.Windows.Forms.TextBox();
            this.textBox2baslık = new System.Windows.Forms.TextBox();
            this.textBox3yazar = new System.Windows.Forms.TextBox();
            this.textBox4yayınlanma_yılı = new System.Windows.Forms.TextBox();
            this.textBox5tur = new System.Windows.Forms.TextBox();
            this.button1Ekle = new System.Windows.Forms.Button();
            this.button1sil = new System.Windows.Forms.Button();
            this.button1güncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1kitap_id
            // 
            this.label1kitap_id.AutoSize = true;
            this.label1kitap_id.Location = new System.Drawing.Point(62, 18);
            this.label1kitap_id.Name = "label1kitap_id";
            this.label1kitap_id.Size = new System.Drawing.Size(54, 16);
            this.label1kitap_id.TabIndex = 0;
            this.label1kitap_id.Text = "kitap_id";
            // 
            // label2baslık
            // 
            this.label2baslık.AutoSize = true;
            this.label2baslık.Location = new System.Drawing.Point(73, 62);
            this.label2baslık.Name = "label2baslık";
            this.label2baslık.Size = new System.Drawing.Size(43, 16);
            this.label2baslık.TabIndex = 1;
            this.label2baslık.Text = "baslık";
            // 
            // label3yazar
            // 
            this.label3yazar.AutoSize = true;
            this.label3yazar.Location = new System.Drawing.Point(76, 108);
            this.label3yazar.Name = "label3yazar";
            this.label3yazar.Size = new System.Drawing.Size(40, 16);
            this.label3yazar.TabIndex = 2;
            this.label3yazar.Text = "yazar";
            // 
            // label4yayınlanma_yılı
            // 
            this.label4yayınlanma_yılı.AutoSize = true;
            this.label4yayınlanma_yılı.Location = new System.Drawing.Point(17, 152);
            this.label4yayınlanma_yılı.Name = "label4yayınlanma_yılı";
            this.label4yayınlanma_yılı.Size = new System.Drawing.Size(99, 16);
            this.label4yayınlanma_yılı.TabIndex = 3;
            this.label4yayınlanma_yılı.Text = "yayınlanma_yılı";
            // 
            // label5tur
            // 
            this.label5tur.AutoSize = true;
            this.label5tur.Location = new System.Drawing.Point(95, 200);
            this.label5tur.Name = "label5tur";
            this.label5tur.Size = new System.Drawing.Size(21, 16);
            this.label5tur.TabIndex = 4;
            this.label5tur.Text = "tur";
            // 
            // textBox1kitap_id
            // 
            this.textBox1kitap_id.Location = new System.Drawing.Point(132, 18);
            this.textBox1kitap_id.Name = "textBox1kitap_id";
            this.textBox1kitap_id.Size = new System.Drawing.Size(121, 22);
            this.textBox1kitap_id.TabIndex = 5;
            // 
            // textBox2baslık
            // 
            this.textBox2baslık.Location = new System.Drawing.Point(132, 62);
            this.textBox2baslık.Name = "textBox2baslık";
            this.textBox2baslık.Size = new System.Drawing.Size(121, 22);
            this.textBox2baslık.TabIndex = 6;
            // 
            // textBox3yazar
            // 
            this.textBox3yazar.Location = new System.Drawing.Point(132, 108);
            this.textBox3yazar.Name = "textBox3yazar";
            this.textBox3yazar.Size = new System.Drawing.Size(121, 22);
            this.textBox3yazar.TabIndex = 7;
            // 
            // textBox4yayınlanma_yılı
            // 
            this.textBox4yayınlanma_yılı.Location = new System.Drawing.Point(132, 152);
            this.textBox4yayınlanma_yılı.Name = "textBox4yayınlanma_yılı";
            this.textBox4yayınlanma_yılı.Size = new System.Drawing.Size(121, 22);
            this.textBox4yayınlanma_yılı.TabIndex = 8;
            // 
            // textBox5tur
            // 
            this.textBox5tur.Location = new System.Drawing.Point(132, 194);
            this.textBox5tur.Name = "textBox5tur";
            this.textBox5tur.Size = new System.Drawing.Size(121, 22);
            this.textBox5tur.TabIndex = 9;
            // 
            // button1Ekle
            // 
            this.button1Ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1Ekle.Location = new System.Drawing.Point(60, 293);
            this.button1Ekle.Name = "button1Ekle";
            this.button1Ekle.Size = new System.Drawing.Size(136, 57);
            this.button1Ekle.TabIndex = 10;
            this.button1Ekle.Text = "kitap ekle";
            this.button1Ekle.UseVisualStyleBackColor = false;
            this.button1Ekle.Click += new System.EventHandler(this.button1Ekle_Click);
            // 
            // button1sil
            // 
            this.button1sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1sil.Location = new System.Drawing.Point(235, 293);
            this.button1sil.Name = "button1sil";
            this.button1sil.Size = new System.Drawing.Size(136, 57);
            this.button1sil.TabIndex = 11;
            this.button1sil.Text = "kitap sil";
            this.button1sil.UseVisualStyleBackColor = false;
            this.button1sil.Click += new System.EventHandler(this.button1sil_Click);
            // 
            // button1güncelle
            // 
            this.button1güncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1güncelle.Location = new System.Drawing.Point(398, 293);
            this.button1güncelle.Name = "button1güncelle";
            this.button1güncelle.Size = new System.Drawing.Size(136, 57);
            this.button1güncelle.TabIndex = 12;
            this.button1güncelle.Text = "kitap güncelle";
            this.button1güncelle.UseVisualStyleBackColor = false;
            this.button1güncelle.Click += new System.EventHandler(this.button1güncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1kitap_id);
            this.groupBox1.Controls.Add(this.label2baslık);
            this.groupBox1.Controls.Add(this.label3yazar);
            this.groupBox1.Controls.Add(this.label4yayınlanma_yılı);
            this.groupBox1.Controls.Add(this.textBox5tur);
            this.groupBox1.Controls.Add(this.label5tur);
            this.groupBox1.Controls.Add(this.textBox4yayınlanma_yılı);
            this.groupBox1.Controls.Add(this.textBox1kitap_id);
            this.groupBox1.Controls.Add(this.textBox3yazar);
            this.groupBox1.Controls.Add(this.textBox2baslık);
            this.groupBox1.Location = new System.Drawing.Point(60, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 251);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "kitaplar";
            // 
            // kitaplık
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1güncelle);
            this.Controls.Add(this.button1sil);
            this.Controls.Add(this.button1Ekle);
            this.Name = "kitaplık";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.kitaplık_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1kitap_id;
        private System.Windows.Forms.Label label2baslık;
        private System.Windows.Forms.Label label3yazar;
        private System.Windows.Forms.Label label4yayınlanma_yılı;
        private System.Windows.Forms.Label label5tur;
        private System.Windows.Forms.TextBox textBox1kitap_id;
        private System.Windows.Forms.TextBox textBox2baslık;
        private System.Windows.Forms.TextBox textBox3yazar;
        private System.Windows.Forms.TextBox textBox4yayınlanma_yılı;
        private System.Windows.Forms.TextBox textBox5tur;
        private System.Windows.Forms.Button button1Ekle;
        private System.Windows.Forms.Button button1sil;
        private System.Windows.Forms.Button button1güncelle;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

