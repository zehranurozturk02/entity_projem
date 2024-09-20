using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entity_projem
{
    public partial class ödünç_işlemleri : Form
    {
        public ödünç_işlemleri()
        {
            InitializeComponent();
        }
        EntityFrameworkStajProjemEntities2 db = new EntityFrameworkStajProjemEntities2();
        private void textboxgerigetirme_Load(object sender, EventArgs e)
        {

        }

        private void kitap_al_Click(object sender, EventArgs e)
        {

            ödünç_alma ödünç = new ödünç_alma();

            ödünç.uye_id = Convert.ToInt32(textBox2üye_id.Text);
            ödünç.kitap_id = Convert.ToInt32(textBox3kitap_id.Text);
            ödünç.ödünç_tarihi = DateTime.Now;

            ödünç.geriGetirme_tarihi = ödünç.ödünç_tarihi.AddDays(15); //her kitap için alındığı günden 15 gün sonrasına geri getirme
                                                                       //tarihi yazarım bu eski kütüphanemin kuralıydı
            db.ödünç_alma.Add(ödünç);
            db.SaveChanges();
          
            var sorgu = from ödünc in db.ödünç_alma
                        join uye in db.üyeler on ödünc.uye_id equals uye.uye_id
                        join kitap in db.kitaplar on ödünc.kitap_id equals kitap.kitap_id
                        where ödünc.uye_id == ödünc.uye_id // filtreleme üye_id'ye göre
                        select new { BAŞLIK = kitap.baslık, ÜYE_ADI = uye.ilk_ad + " " + uye.son_ad, TÜR = kitap.tur ,GETİRME_TARİHİ=ödünc.geriGetirme_tarihi};

            dataGridView1.DataSource = sorgu.ToList();
            MessageBox.Show("Kitap ödünç alındı.");
        }
    

     
        private void kitap_ver_Click(object sender, EventArgs e)
        {
            int ödünç_id = Convert.ToInt32(textBox1ödünç_id.Text);
            var ödünç = db.ödünç_alma.Find(ödünç_id);

            if (ödünç != null)
            {
                ödünç.getirilen_tarih = DateTime.Now; // Kitap geri alındığı tarih
                db.SaveChanges();
                MessageBox.Show("Kitap başarıyla geri alındı.");

                // Kitapları güncelle ve göster
                var sorgu = from i in db.ödünç_alma
                            join kitap in db.kitaplar on i.kitap_id equals kitap.kitap_id
                            join uye in db.üyeler on i.uye_id equals uye.uye_id
                            where i.uye_id == ödünç.uye_id // Bu üyenin ödünç aldığı kitapları göster
                            select new
                            {
                                BAŞLIK = kitap.baslık,
                                ÜYE_ADI = uye.ilk_ad + " " + uye.son_ad, // Üyenin adı ve soyadı
                                TARİH = ödünç.getirilen_tarih // Kitabın getirildiği tarih
                            };
                dataGridView2.DataSource = sorgu.ToList();
            }
            else
            {
                MessageBox.Show("Belirtilen ID ile ödünç işlemi bulunamadı.");
            }

        }

       
    }
    }

