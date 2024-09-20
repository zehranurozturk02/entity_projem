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


namespace entity_projem.form
{
    public partial class üyelik : Form
    {
        public üyelik()
        {
            InitializeComponent();
        }
        EntityFrameworkStajProjemEntities2 db = new EntityFrameworkStajProjemEntities2();
        private void button1Ekle_Click(object sender, EventArgs e)
        {
            üyeler üye = new üyeler();
            üye.uye_id = Convert.ToInt32(textBox1uye_id.Text);
            üye.ilk_ad = textBox2ilk_ad.Text;
            üye.son_ad = textBox3son_ad.Text;
            üye.email = textBox4email.Text;
            üye.numara = textBox5numara.Text;
            üye.uyelik_tarihi = Convert.ToDateTime(textBox1uyelik_tarihi.Text);

            db.üyeler.Add(üye);
            db.SaveChanges();
            MessageBox.Show("yeni üye eklendi");

        }

        private void button1sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1uye_id.Text);
            var bul = db.üyeler.Find(id);
            db.üyeler.Remove(bul);
            db.SaveChanges();
            MessageBox.Show("girilen id'li üye silindi");
        }

        private void button1güncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1uye_id.Text);
            var bul = db.üyeler.Find(id);

           

            bul.uye_id = Convert.ToInt32(textBox1uye_id.Text);
            bul.ilk_ad = textBox2ilk_ad.Text;
            bul.son_ad = textBox3son_ad.Text;
            bul.email = textBox4email.Text;
            bul.numara = textBox5numara.Text;
            bul.uyelik_tarihi = Convert.ToDateTime(textBox1uyelik_tarihi.Text);

            db.SaveChanges();
            MessageBox.Show("güncellendi");
        }

        private void üyelik_Load(object sender, EventArgs e)
        {

        }
    }
}
