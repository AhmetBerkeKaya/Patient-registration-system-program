using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Npgsql;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaKayit
{
    public partial class Form1 : Form
    {
        // Bağlantı kuruluyor
        NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=HastaKayit; user Id=postgres; password=1234");
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnListele_Click(object sender, EventArgs e)
        {
            // Veritabanından verilerin hepsi alınıyor
            string txt = "SELECT * FROM hasta";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(txt, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dgvHasta.DataSource = dataSet.Tables[0];
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Boş kontrolü
                if (string.IsNullOrWhiteSpace(tbxTC.Text) || string.IsNullOrWhiteSpace(tbxAd.Text) ||
                    string.IsNullOrWhiteSpace(tbxSoyad.Text) || string.IsNullOrWhiteSpace(tbxTelefon.Text) ||
                    string.IsNullOrWhiteSpace(tbxDTarih.Text) || string.IsNullOrWhiteSpace(tbxDYer.Text) ||
                    string.IsNullOrWhiteSpace(tbxAdres.Text) || string.IsNullOrWhiteSpace(tbxTeshis.Text) ||
                    string.IsNullOrWhiteSpace(tbxilac.Text))
                {
                    DialogResult result = MessageBox.Show("Bazı bilgiler boş bırakılmış. Yine de kayıt etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result != DialogResult.Yes)
                    {
                        return; // Kayıt etme
                    }

                }
                // TC numarasının uzunluğunu kontrol et
                if (tbxTC.Text.Length != 11)
                {
                    MessageBox.Show("TC numarası 11 haneli olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kayıt etme
                }

                // Bağlantının kapalı olma durumu
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open(); // Bağlantıyı Aç
                                       // Veritabanına bilgiler ekleniyor
                    NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO hasta (tcno,ad,soyad,telefon,dogumtarihi,dogumyeri,adres,hastalik,ilac) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", connection);
                    cmd.Parameters.AddWithValue("@p1", tbxTC.Text);
                    cmd.Parameters.AddWithValue("@p2", tbxAd.Text);
                    cmd.Parameters.AddWithValue("@p3", tbxSoyad.Text);
                    cmd.Parameters.AddWithValue("@p4", tbxTelefon.Text);
                    cmd.Parameters.AddWithValue("@p5", tbxDTarih.Text);
                    cmd.Parameters.AddWithValue("@p6", tbxDYer.Text);
                    cmd.Parameters.AddWithValue("@p7", tbxAdres.Text);
                    cmd.Parameters.AddWithValue("@p8", tbxTeshis.Text);
                    cmd.Parameters.AddWithValue("@p9", tbxilac.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarıyla eklendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnListele_Click(null, null); // Otomatik liste yenileniyor
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message); // Hata mesajı
            }
            finally
            {
                // En son bağlantı kapatılıyor
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                // Bağlantı kontrolü
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    // Silinmesini sorma durumu
                    if (result == DialogResult.Yes)
                    {
                        NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM HASTA WHERE tcno=@p1", connection);
                        cmd.Parameters.AddWithValue("@p1", tbxTCSil.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ürün silme işlemi başarılı!!");
                        btnListele_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Ürün silme işlemi iptal edildi!!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // Son olarak bağlantı kapatma
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // Bağlantı Durumu
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    // verileri güncelleme 
                    NpgsqlCommand updateCmd = new NpgsqlCommand("UPDATE HASTA SET ad=@p2, soyad=@p3, telefon=@p4, dogumtarihi=@p5, dogumyeri=@p6, adres=@p7, hastalik=@p8, ilac=@p9 WHERE tcno=@p1", connection);
                    updateCmd.Parameters.AddWithValue("@p1", tbxTC.Text);
                    updateCmd.Parameters.AddWithValue("@p2", tbxAd.Text);
                    updateCmd.Parameters.AddWithValue("@p3", tbxSoyad.Text);
                    updateCmd.Parameters.AddWithValue("@p4", tbxTelefon.Text);
                    updateCmd.Parameters.AddWithValue("@p5", tbxDTarih.Text);
                    updateCmd.Parameters.AddWithValue("@p6", tbxDYer.Text);
                    updateCmd.Parameters.AddWithValue("@p7", tbxAdres.Text);
                    updateCmd.Parameters.AddWithValue("@p8", tbxTeshis.Text);
                    updateCmd.Parameters.AddWithValue("@p9", tbxilac.Text);

                    // Değişiklik kontrolü
                    if (updateCmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Güncelleme başarıyla tamamlandı!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnListele_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Hiçbir şey değiştirilmedi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // Bağlantı durumu
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnBilgiGetir_Click(object sender, EventArgs e)
        {
            try
            {
                // Bağlantı durumu
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();

                    // Kimliğe göre bilgiler getirme
                    NpgsqlCommand selectCmd = new NpgsqlCommand("SELECT * FROM HASTA WHERE tcno=@p1", connection);
                    selectCmd.Parameters.AddWithValue("@p1", tbxTCUpdate.Text);

                    using (NpgsqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Bilgileri textbox'lara getirme
                            tbxTC.Text = reader["tcno"].ToString();
                            tbxAd.Text = reader["ad"].ToString();
                            tbxSoyad.Text = reader["soyad"].ToString();
                            tbxTelefon.Text = reader["telefon"].ToString();
                            tbxDTarih.Text = reader["dogumTarihi"].ToString();
                            tbxDYer.Text = reader["dogumYeri"].ToString();
                            tbxAdres.Text = reader["adres"].ToString();
                            tbxTeshis.Text = reader["hastalik"].ToString();
                            tbxilac.Text = reader["ilac"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Hasta bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // Bağlantı Sonlandırma
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            // Tüm textbox'ları seç
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();  //Textbox temizle
                }
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // CheckBox'ın adından sütun numarasını al
            string checkBoxName = ((CheckBox)sender).Name;
            int columnIndex = int.Parse(checkBoxName.Substring(3)); // cbx1, cbx2, ... cbx9

            // DataGridView sütunlarını göster veya gizle
            dgvHasta.Columns[columnIndex].Visible = ((CheckBox)sender).Checked;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde tüm checkbox'ları seçili yap
            foreach (Control control in groupBoxColumns.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = true;
                    checkBox.CheckedChanged += CheckBox_CheckedChanged; // Olaya dinleyici ekle
                }
            }
        }

        private void SortDGV(string sortOrder)
        {
            string columnName = "ad"; // Sıralama yapılacak sütun adı, burada örnek olarak "ad" kullanıldı. İhtiyacınıza göre değiştirebilirsiniz.

            // Sıralama işlemi
            dgvHasta.Sort(dgvHasta.Columns[columnName], sortOrder == "asc" ? ListSortDirection.Ascending : ListSortDirection.Descending);
        }

        private void chckbxASC_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbxASC.Checked)
            {
                chckbxDESC.Checked = false; // Diğer checkbox'ı kaldır
                SortDGV("asc");
            }
        }

        private void chckbxDESC_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbxDESC.Checked)
            {
                chckbxASC.Checked = false; // Diğer checkbox'ı kaldır
                SortDGV("desc");
            }
        }

    }
}
