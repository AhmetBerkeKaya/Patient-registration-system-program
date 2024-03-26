
namespace HastaKayit
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
            this.dgvHasta = new System.Windows.Forms.DataGridView();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblDTarihi = new System.Windows.Forms.Label();
            this.lblDYeri = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblTeshis = new System.Windows.Forms.Label();
            this.lblilac = new System.Windows.Forms.Label();
            this.tbxTC = new System.Windows.Forms.TextBox();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.tbxTelefon = new System.Windows.Forms.TextBox();
            this.tbxDTarih = new System.Windows.Forms.TextBox();
            this.tbxDYer = new System.Windows.Forms.TextBox();
            this.tbxAdres = new System.Windows.Forms.TextBox();
            this.tbxTeshis = new System.Windows.Forms.TextBox();
            this.tbxilac = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.lblSil = new System.Windows.Forms.Label();
            this.tbxTCSil = new System.Windows.Forms.TextBox();
            this.tbxTCUpdate = new System.Windows.Forms.TextBox();
            this.lblTCUpdate = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnBilgiGetir = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.cbx1 = new System.Windows.Forms.CheckBox();
            this.cbx2 = new System.Windows.Forms.CheckBox();
            this.cbx3 = new System.Windows.Forms.CheckBox();
            this.cbx4 = new System.Windows.Forms.CheckBox();
            this.cbx5 = new System.Windows.Forms.CheckBox();
            this.cbx6 = new System.Windows.Forms.CheckBox();
            this.cbx7 = new System.Windows.Forms.CheckBox();
            this.cbx8 = new System.Windows.Forms.CheckBox();
            this.cbx9 = new System.Windows.Forms.CheckBox();
            this.groupBoxColumns = new System.Windows.Forms.GroupBox();
            this.chckbxASC = new System.Windows.Forms.CheckBox();
            this.chckbxDESC = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHasta)).BeginInit();
            this.groupBoxColumns.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHasta
            // 
            this.dgvHasta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHasta.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvHasta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvHasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHasta.Location = new System.Drawing.Point(27, 54);
            this.dgvHasta.Name = "dgvHasta";
            this.dgvHasta.ReadOnly = true;
            this.dgvHasta.RowHeadersWidth = 51;
            this.dgvHasta.RowTemplate.Height = 24;
            this.dgvHasta.Size = new System.Drawing.Size(1141, 446);
            this.dgvHasta.TabIndex = 0;
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTC.Location = new System.Drawing.Point(1194, 114);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(51, 17);
            this.lblTC.TabIndex = 1;
            this.lblTC.Text = "TC NO";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAd.Location = new System.Drawing.Point(1194, 150);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(27, 17);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "AD";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSoyad.Location = new System.Drawing.Point(1194, 186);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(56, 17);
            this.lblSoyad.TabIndex = 3;
            this.lblSoyad.Text = "SOYAD";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTelefon.Location = new System.Drawing.Point(1194, 222);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(72, 17);
            this.lblTelefon.TabIndex = 4;
            this.lblTelefon.Text = "TELEFON";
            // 
            // lblDTarihi
            // 
            this.lblDTarihi.AutoSize = true;
            this.lblDTarihi.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDTarihi.Location = new System.Drawing.Point(1194, 258);
            this.lblDTarihi.Name = "lblDTarihi";
            this.lblDTarihi.Size = new System.Drawing.Size(109, 17);
            this.lblDTarihi.TabIndex = 5;
            this.lblDTarihi.Text = "DOĞUM TARİHİ";
            // 
            // lblDYeri
            // 
            this.lblDYeri.AutoSize = true;
            this.lblDYeri.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDYeri.Location = new System.Drawing.Point(1194, 294);
            this.lblDYeri.Name = "lblDYeri";
            this.lblDYeri.Size = new System.Drawing.Size(96, 17);
            this.lblDYeri.TabIndex = 6;
            this.lblDYeri.Text = "DOĞUM YERİ";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAdres.Location = new System.Drawing.Point(1194, 330);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(55, 17);
            this.lblAdres.TabIndex = 7;
            this.lblAdres.Text = "ADRES";
            // 
            // lblTeshis
            // 
            this.lblTeshis.AutoSize = true;
            this.lblTeshis.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTeshis.Location = new System.Drawing.Point(1194, 386);
            this.lblTeshis.Name = "lblTeshis";
            this.lblTeshis.Size = new System.Drawing.Size(57, 17);
            this.lblTeshis.TabIndex = 8;
            this.lblTeshis.Text = "TEŞHİS";
            // 
            // lblilac
            // 
            this.lblilac.AutoSize = true;
            this.lblilac.ForeColor = System.Drawing.SystemColors.Window;
            this.lblilac.Location = new System.Drawing.Point(1194, 422);
            this.lblilac.Name = "lblilac";
            this.lblilac.Size = new System.Drawing.Size(37, 17);
            this.lblilac.TabIndex = 9;
            this.lblilac.Text = "İLAÇ";
            // 
            // tbxTC
            // 
            this.tbxTC.Location = new System.Drawing.Point(1312, 114);
            this.tbxTC.Name = "tbxTC";
            this.tbxTC.Size = new System.Drawing.Size(175, 22);
            this.tbxTC.TabIndex = 10;
            // 
            // tbxAd
            // 
            this.tbxAd.Location = new System.Drawing.Point(1312, 150);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(175, 22);
            this.tbxAd.TabIndex = 11;
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Location = new System.Drawing.Point(1312, 186);
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(175, 22);
            this.tbxSoyad.TabIndex = 12;
            // 
            // tbxTelefon
            // 
            this.tbxTelefon.Location = new System.Drawing.Point(1312, 222);
            this.tbxTelefon.Name = "tbxTelefon";
            this.tbxTelefon.Size = new System.Drawing.Size(175, 22);
            this.tbxTelefon.TabIndex = 13;
            // 
            // tbxDTarih
            // 
            this.tbxDTarih.Location = new System.Drawing.Point(1312, 258);
            this.tbxDTarih.Name = "tbxDTarih";
            this.tbxDTarih.Size = new System.Drawing.Size(175, 22);
            this.tbxDTarih.TabIndex = 14;
            // 
            // tbxDYer
            // 
            this.tbxDYer.Location = new System.Drawing.Point(1312, 294);
            this.tbxDYer.Name = "tbxDYer";
            this.tbxDYer.Size = new System.Drawing.Size(175, 22);
            this.tbxDYer.TabIndex = 15;
            // 
            // tbxAdres
            // 
            this.tbxAdres.Location = new System.Drawing.Point(1312, 330);
            this.tbxAdres.Multiline = true;
            this.tbxAdres.Name = "tbxAdres";
            this.tbxAdres.Size = new System.Drawing.Size(175, 41);
            this.tbxAdres.TabIndex = 16;
            // 
            // tbxTeshis
            // 
            this.tbxTeshis.Location = new System.Drawing.Point(1312, 383);
            this.tbxTeshis.Name = "tbxTeshis";
            this.tbxTeshis.Size = new System.Drawing.Size(175, 22);
            this.tbxTeshis.TabIndex = 17;
            // 
            // tbxilac
            // 
            this.tbxilac.Location = new System.Drawing.Point(1312, 419);
            this.tbxilac.Name = "tbxilac";
            this.tbxilac.Size = new System.Drawing.Size(175, 22);
            this.tbxilac.TabIndex = 18;
            // 
            // btnEkle
            // 
            this.btnEkle.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEkle.Location = new System.Drawing.Point(1197, 460);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(290, 40);
            this.btnEkle.TabIndex = 19;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSil.Location = new System.Drawing.Point(901, 562);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(290, 40);
            this.btnSil.TabIndex = 20;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnListele
            // 
            this.btnListele.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnListele.Location = new System.Drawing.Point(370, 562);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(248, 40);
            this.btnListele.TabIndex = 21;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lblSil
            // 
            this.lblSil.AutoSize = true;
            this.lblSil.ForeColor = System.Drawing.Color.White;
            this.lblSil.Location = new System.Drawing.Point(930, 509);
            this.lblSil.Name = "lblSil";
            this.lblSil.Size = new System.Drawing.Size(225, 17);
            this.lblSil.TabIndex = 23;
            this.lblSil.Text = "SİLİNECEK KİŞİNİN TC NUMARASI";
            // 
            // tbxTCSil
            // 
            this.tbxTCSil.Location = new System.Drawing.Point(901, 534);
            this.tbxTCSil.Name = "tbxTCSil";
            this.tbxTCSil.Size = new System.Drawing.Size(290, 22);
            this.tbxTCSil.TabIndex = 24;
            // 
            // tbxTCUpdate
            // 
            this.tbxTCUpdate.Location = new System.Drawing.Point(1197, 534);
            this.tbxTCUpdate.Name = "tbxTCUpdate";
            this.tbxTCUpdate.Size = new System.Drawing.Size(290, 22);
            this.tbxTCUpdate.TabIndex = 25;
            // 
            // lblTCUpdate
            // 
            this.lblTCUpdate.AutoSize = true;
            this.lblTCUpdate.ForeColor = System.Drawing.Color.White;
            this.lblTCUpdate.Location = new System.Drawing.Point(1201, 509);
            this.lblTCUpdate.Name = "lblTCUpdate";
            this.lblTCUpdate.Size = new System.Drawing.Size(276, 17);
            this.lblTCUpdate.TabIndex = 26;
            this.lblTCUpdate.Text = "GÜNCELLENECEK KİŞİNİN TC NUMARASI";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnGüncelle.Location = new System.Drawing.Point(1197, 608);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(290, 40);
            this.btnGüncelle.TabIndex = 27;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnBilgiGetir
            // 
            this.btnBilgiGetir.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnBilgiGetir.Location = new System.Drawing.Point(1197, 562);
            this.btnBilgiGetir.Name = "btnBilgiGetir";
            this.btnBilgiGetir.Size = new System.Drawing.Size(290, 40);
            this.btnBilgiGetir.TabIndex = 28;
            this.btnBilgiGetir.Text = "BİLGİLERİ GETİR";
            this.btnBilgiGetir.UseVisualStyleBackColor = true;
            this.btnBilgiGetir.Click += new System.EventHandler(this.btnBilgiGetir_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnTemizle.Location = new System.Drawing.Point(1197, 54);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(290, 41);
            this.btnTemizle.TabIndex = 29;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // cbx1
            // 
            this.cbx1.AutoSize = true;
            this.cbx1.ForeColor = System.Drawing.SystemColors.Window;
            this.cbx1.Location = new System.Drawing.Point(6, 25);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(73, 21);
            this.cbx1.TabIndex = 30;
            this.cbx1.Text = "TC NO";
            this.cbx1.UseVisualStyleBackColor = true;
            // 
            // cbx2
            // 
            this.cbx2.AutoSize = true;
            this.cbx2.ForeColor = System.Drawing.SystemColors.Window;
            this.cbx2.Location = new System.Drawing.Point(85, 25);
            this.cbx2.Name = "cbx2";
            this.cbx2.Size = new System.Drawing.Size(49, 21);
            this.cbx2.TabIndex = 31;
            this.cbx2.Text = "AD";
            this.cbx2.UseVisualStyleBackColor = true;
            // 
            // cbx3
            // 
            this.cbx3.AutoSize = true;
            this.cbx3.ForeColor = System.Drawing.SystemColors.Window;
            this.cbx3.Location = new System.Drawing.Point(150, 25);
            this.cbx3.Name = "cbx3";
            this.cbx3.Size = new System.Drawing.Size(78, 21);
            this.cbx3.TabIndex = 32;
            this.cbx3.Text = "SOYAD";
            this.cbx3.UseVisualStyleBackColor = true;
            // 
            // cbx4
            // 
            this.cbx4.AutoSize = true;
            this.cbx4.ForeColor = System.Drawing.SystemColors.Window;
            this.cbx4.Location = new System.Drawing.Point(243, 25);
            this.cbx4.Name = "cbx4";
            this.cbx4.Size = new System.Drawing.Size(94, 21);
            this.cbx4.TabIndex = 33;
            this.cbx4.Text = "TELEFON";
            this.cbx4.UseVisualStyleBackColor = true;
            // 
            // cbx5
            // 
            this.cbx5.AutoSize = true;
            this.cbx5.ForeColor = System.Drawing.SystemColors.Window;
            this.cbx5.Location = new System.Drawing.Point(343, 25);
            this.cbx5.Name = "cbx5";
            this.cbx5.Size = new System.Drawing.Size(131, 21);
            this.cbx5.TabIndex = 34;
            this.cbx5.Text = "DOĞUM TARİHİ";
            this.cbx5.UseVisualStyleBackColor = true;
            // 
            // cbx6
            // 
            this.cbx6.AutoSize = true;
            this.cbx6.ForeColor = System.Drawing.SystemColors.Window;
            this.cbx6.Location = new System.Drawing.Point(480, 25);
            this.cbx6.Name = "cbx6";
            this.cbx6.Size = new System.Drawing.Size(118, 21);
            this.cbx6.TabIndex = 35;
            this.cbx6.Text = "DOĞUM YERİ";
            this.cbx6.UseVisualStyleBackColor = true;
            // 
            // cbx7
            // 
            this.cbx7.AutoSize = true;
            this.cbx7.ForeColor = System.Drawing.SystemColors.Window;
            this.cbx7.Location = new System.Drawing.Point(604, 24);
            this.cbx7.Name = "cbx7";
            this.cbx7.Size = new System.Drawing.Size(77, 21);
            this.cbx7.TabIndex = 36;
            this.cbx7.Text = "ADRES";
            this.cbx7.UseVisualStyleBackColor = true;
            // 
            // cbx8
            // 
            this.cbx8.AutoSize = true;
            this.cbx8.ForeColor = System.Drawing.SystemColors.Window;
            this.cbx8.Location = new System.Drawing.Point(687, 24);
            this.cbx8.Name = "cbx8";
            this.cbx8.Size = new System.Drawing.Size(96, 21);
            this.cbx8.TabIndex = 37;
            this.cbx8.Text = "HASTALIK";
            this.cbx8.UseVisualStyleBackColor = true;
            // 
            // cbx9
            // 
            this.cbx9.AutoSize = true;
            this.cbx9.ForeColor = System.Drawing.SystemColors.Window;
            this.cbx9.Location = new System.Drawing.Point(789, 24);
            this.cbx9.Name = "cbx9";
            this.cbx9.Size = new System.Drawing.Size(59, 21);
            this.cbx9.TabIndex = 38;
            this.cbx9.Text = "İLAÇ";
            this.cbx9.UseVisualStyleBackColor = true;
            // 
            // groupBoxColumns
            // 
            this.groupBoxColumns.Controls.Add(this.cbx1);
            this.groupBoxColumns.Controls.Add(this.cbx9);
            this.groupBoxColumns.Controls.Add(this.cbx2);
            this.groupBoxColumns.Controls.Add(this.cbx8);
            this.groupBoxColumns.Controls.Add(this.cbx3);
            this.groupBoxColumns.Controls.Add(this.cbx7);
            this.groupBoxColumns.Controls.Add(this.cbx4);
            this.groupBoxColumns.Controls.Add(this.cbx6);
            this.groupBoxColumns.Controls.Add(this.cbx5);
            this.groupBoxColumns.Location = new System.Drawing.Point(27, 506);
            this.groupBoxColumns.Name = "groupBoxColumns";
            this.groupBoxColumns.Size = new System.Drawing.Size(860, 48);
            this.groupBoxColumns.TabIndex = 39;
            this.groupBoxColumns.TabStop = false;
            this.groupBoxColumns.Text = "GÖRÜNMESİNİ İSTEDİĞİN SÜTUNU SEÇ";
            // 
            // chckbxASC
            // 
            this.chckbxASC.AutoSize = true;
            this.chckbxASC.Location = new System.Drawing.Point(252, 31);
            this.chckbxASC.Name = "chckbxASC";
            this.chckbxASC.Size = new System.Drawing.Size(18, 17);
            this.chckbxASC.TabIndex = 42;
            this.chckbxASC.UseVisualStyleBackColor = true;
            this.chckbxASC.CheckedChanged += new System.EventHandler(this.chckbxASC_CheckedChanged);
            // 
            // chckbxDESC
            // 
            this.chckbxDESC.AutoSize = true;
            this.chckbxDESC.Location = new System.Drawing.Point(507, 32);
            this.chckbxDESC.Name = "chckbxDESC";
            this.chckbxDESC.Size = new System.Drawing.Size(18, 17);
            this.chckbxDESC.TabIndex = 43;
            this.chckbxDESC.UseVisualStyleBackColor = true;
            this.chckbxDESC.CheckedChanged += new System.EventHandler(this.chckbxDESC_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "KÜÇÜKTEN BÜYÜĞE SIRALA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "BÜYÜKTEN KÜÇÜĞE SIRALA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1524, 665);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chckbxDESC);
            this.Controls.Add(this.chckbxASC);
            this.Controls.Add(this.groupBoxColumns);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnBilgiGetir);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.lblTCUpdate);
            this.Controls.Add(this.tbxTCUpdate);
            this.Controls.Add(this.tbxTCSil);
            this.Controls.Add(this.lblSil);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.tbxilac);
            this.Controls.Add(this.tbxTeshis);
            this.Controls.Add(this.tbxAdres);
            this.Controls.Add(this.tbxDYer);
            this.Controls.Add(this.tbxDTarih);
            this.Controls.Add(this.tbxTelefon);
            this.Controls.Add(this.tbxSoyad);
            this.Controls.Add(this.tbxAd);
            this.Controls.Add(this.tbxTC);
            this.Controls.Add(this.lblilac);
            this.Controls.Add(this.lblTeshis);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblDYeri);
            this.Controls.Add(this.lblDTarihi);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.dgvHasta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHasta)).EndInit();
            this.groupBoxColumns.ResumeLayout(false);
            this.groupBoxColumns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHasta;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblDTarihi;
        private System.Windows.Forms.Label lblDYeri;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTeshis;
        private System.Windows.Forms.Label lblilac;
        private System.Windows.Forms.TextBox tbxTC;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.TextBox tbxSoyad;
        private System.Windows.Forms.TextBox tbxTelefon;
        private System.Windows.Forms.TextBox tbxDTarih;
        private System.Windows.Forms.TextBox tbxDYer;
        private System.Windows.Forms.TextBox tbxAdres;
        private System.Windows.Forms.TextBox tbxTeshis;
        private System.Windows.Forms.TextBox tbxilac;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label lblSil;
        private System.Windows.Forms.TextBox tbxTCSil;
        private System.Windows.Forms.TextBox tbxTCUpdate;
        private System.Windows.Forms.Label lblTCUpdate;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnBilgiGetir;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.CheckBox cbx1;
        private System.Windows.Forms.CheckBox cbx2;
        private System.Windows.Forms.CheckBox cbx3;
        private System.Windows.Forms.CheckBox cbx4;
        private System.Windows.Forms.CheckBox cbx5;
        private System.Windows.Forms.CheckBox cbx6;
        private System.Windows.Forms.CheckBox cbx7;
        private System.Windows.Forms.CheckBox cbx8;
        private System.Windows.Forms.CheckBox cbx9;
        private System.Windows.Forms.GroupBox groupBoxColumns;
        private System.Windows.Forms.CheckBox chckbxASC;
        private System.Windows.Forms.CheckBox chckbxDESC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

