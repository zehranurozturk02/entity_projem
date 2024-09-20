using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace entity_projem
{
    public partial class kitaplık : Form
    {
        public kitaplık()
        {
            InitializeComponent();
        }

        
        EntityFrameworkStajProjemEntities2 db = new EntityFrameworkStajProjemEntities2();

        private void kitaplık_Load(object sender, EventArgs e)
        {
           
        }

        private void button1Ekle_Click(object sender, EventArgs e)
        {
            kitaplar kitap = new kitaplar();
            
            kitap.kitap_id = Convert.ToInt32(textBox1kitap_id.Text);
            kitap.baslık = textBox2baslık.Text;
            kitap.yazar = textBox3yazar.Text;
            kitap.yayınlanma_yılı = Convert.ToInt32(textBox4yayınlanma_yılı.Text);
            kitap.tur = textBox5tur.Text;

            db.kitaplar.Add(kitap);
            db.SaveChanges();
            MessageBox.Show("öğrenci listeye eklenmiştir");
        }

        private void button1sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1kitap_id.Text);
            var kitap= db.kitaplar.Find(id);
            db.kitaplar.Remove(kitap);
            db.SaveChanges();
            MessageBox.Show("kitap silindi");
        }

        private void button1güncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1kitap_id.Text);
            var kitap = db.kitaplar.Find(id);
            kitap.baslık = textBox2baslık.Text;
            kitap.yazar = textBox3yazar.Text;
            kitap.yayınlanma_yılı = Convert.ToInt32(textBox4yayınlanma_yılı.Text);
            kitap.tur = textBox5tur.Text;

            db.SaveChanges();
            MessageBox.Show("kitap güncellendi");

        }
    }
}
