namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_urun = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_stok = new System.Windows.Forms.Label();
            this.lbl_fiyat = new System.Windows.Forms.Label();
            this.txt_urun = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncel = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_urun
            // 
            this.lbl_urun.AutoSize = true;
            this.lbl_urun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_urun.Location = new System.Drawing.Point(74, 51);
            this.lbl_urun.Name = "lbl_urun";
            this.lbl_urun.Size = new System.Drawing.Size(90, 25);
            this.lbl_urun.TabIndex = 0;
            this.lbl_urun.Text = "Ürün No:";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ad.Location = new System.Drawing.Point(74, 119);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(94, 25);
            this.lbl_ad.TabIndex = 1;
            this.lbl_ad.Text = "Ürün Adı:";
            // 
            // lbl_stok
            // 
            this.lbl_stok.AutoSize = true;
            this.lbl_stok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_stok.Location = new System.Drawing.Point(74, 190);
            this.lbl_stok.Name = "lbl_stok";
            this.lbl_stok.Size = new System.Drawing.Size(58, 25);
            this.lbl_stok.TabIndex = 2;
            this.lbl_stok.Text = "Stok:";
            // 
            // lbl_fiyat
            // 
            this.lbl_fiyat.AutoSize = true;
            this.lbl_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_fiyat.Location = new System.Drawing.Point(74, 259);
            this.lbl_fiyat.Name = "lbl_fiyat";
            this.lbl_fiyat.Size = new System.Drawing.Size(60, 25);
            this.lbl_fiyat.TabIndex = 3;
            this.lbl_fiyat.Text = "Fiyat:";
            // 
            // txt_urun
            // 
            this.txt_urun.Enabled = false;
            this.txt_urun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_urun.Location = new System.Drawing.Point(213, 46);
            this.txt_urun.Name = "txt_urun";
            this.txt_urun.Size = new System.Drawing.Size(211, 30);
            this.txt_urun.TabIndex = 4;
            // 
            // txt_ad
            // 
            this.txt_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_ad.Location = new System.Drawing.Point(213, 114);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(211, 30);
            this.txt_ad.TabIndex = 5;
            this.txt_ad.TextChanged += new System.EventHandler(this.txt_ad_TextChanged);
            this.txt_ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ad_KeyPress);
            // 
            // txt_stok
            // 
            this.txt_stok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_stok.Location = new System.Drawing.Point(213, 187);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(211, 30);
            this.txt_stok.TabIndex = 6;
            this.txt_stok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stok_KeyPress);
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_fiyat.Location = new System.Drawing.Point(213, 254);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(211, 30);
            this.txt_fiyat.TabIndex = 7;
            this.txt_fiyat.TextChanged += new System.EventHandler(this.txt_fiyat_TextChanged);
            this.txt_fiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fiyat_KeyPress);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_ekle.Location = new System.Drawing.Point(600, 46);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(117, 49);
            this.btn_ekle.TabIndex = 8;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_guncel
            // 
            this.btn_guncel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_guncel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_guncel.Location = new System.Drawing.Point(600, 143);
            this.btn_guncel.Name = "btn_guncel";
            this.btn_guncel.Size = new System.Drawing.Size(117, 48);
            this.btn_guncel.TabIndex = 9;
            this.btn_guncel.Text = "Güncelle";
            this.btn_guncel.UseVisualStyleBackColor = false;
            this.btn_guncel.Click += new System.EventHandler(this.btn_guncel_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_sil.Location = new System.Drawing.Point(600, 238);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(117, 46);
            this.btn_sil.TabIndex = 10;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(79, 334);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(638, 233);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1090, 587);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncel);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.txt_stok);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_urun);
            this.Controls.Add(this.lbl_fiyat);
            this.Controls.Add(this.lbl_stok);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.lbl_urun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kontrol Paneli";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_urun;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_stok;
        private System.Windows.Forms.Label lbl_fiyat;
        private System.Windows.Forms.TextBox txt_urun;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncel;
        private System.Windows.Forms.Button btn_sil;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

