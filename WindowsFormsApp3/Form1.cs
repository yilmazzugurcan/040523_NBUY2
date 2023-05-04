using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 dbOgrenciEntities db=new dbOgrenciEntities();
        private void btnOgrenciListele_Click(object sender, EventArgs e)
        {
           // dbOgrenciEntities db = new dbOgrenciEntities();//başlarken
            dgvListe.DataSource= db.tblOgrenci.ToList();
        }

        private void btnNotListesi_Click(object sender, EventArgs e)
        {
            //linq
            var query = from item in db.tblNotlar
                        select new {
                            item.NotId, item.OgrId, item.Ders,
                            item.Sinav1,item.Sinav2, item.Sinav3, item.Ortalama, item.Durum
                            //,item.tblOgrenci.Adi,item.tblDersler.DersAd
                        };
            dgvListe.DataSource = query.ToList();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            tblOgrenci t=new tblOgrenci();
            t.Adi = txtOgrenciAd.Text;
            t.Soyadi = txtOgrenciSoyad.Text;
            db.tblOgrenci.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ekleme tamamlanı");
            dgvListe.DataSource = db.tblOgrenci.ToList();
            //yeni ders ekleme
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtOgrenciId.Text==string.Empty)
            {
                MessageBox.Show("Boş geçme");
            }
            else
            {
                int id = Convert.ToInt32(txtOgrenciId.Text);
                var x = db.tblOgrenci.Find(id);
                db.tblOgrenci.Remove(x);
                db.SaveChanges();
               dgvListe.DataSource =db.tblOgrenci.ToList();
                MessageBox.Show("ogrencı sılını");
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dgvListe.DataSource = db.tblOgrenci.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOgrenciId.Text);
            var x = db.tblOgrenci.Find(id);
            x.Adi=txtOgrenciAd.Text;
            x.Soyadi = txtOgrenciSoyad.Text;
            x.Fotograf = txtFotograf.Text;
            db.SaveChanges();
            MessageBox.Show("Guncelleme tamamlanı");

        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            dgvListe.DataSource = db.notlistesi();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            dgvListe.DataSource = db.tblOgrenci.Where(x => x.Adi == txtOgrenciAd.Text | x.Soyadi ==txtOgrenciSoyad.Text ).ToList();  
        }

        private void txtOgrenciAd_TextChanged(object sender, EventArgs e)
        {
            string aranan=txtOgrenciAd.Text;
            var degerler=from s in db.tblOgrenci
                         where s.Adi.Contains(aranan)
                         select s;
            dgvListe.DataSource = degerler.ToList();

        }

        private void btnLinqEntity_Click(object sender, EventArgs e)
        {
            if (rbAdaGore.Checked)
            {
                //asc
                List<tblOgrenci> liste1=db.tblOgrenci.OrderBy(p=>p.Adi).ToList();
                dgvListe.DataSource =liste1;
            }
            else if (rbAdaGoreTersten.Checked) 
            {
                List<tblOgrenci> liste2 = db.tblOgrenci.OrderByDescending(p => p.Adi).ToList(); 
                dgvListe.DataSource =liste2;
            }
            else if (rbIlkUc.Checked)
            {
                List<tblOgrenci> liste3 = db.tblOgrenci.OrderBy(p => p.Adi).Take(3).ToList(); 
                dgvListe.DataSource =liste3;
            }
            else if (rbId.Checked)
            {
                int arananId=int.Parse(txtOgrenciId.Text);
                List<tblOgrenci> liste4 = db.tblOgrenci.Where(p => p.Id ==arananId).ToList();
                dgvListe.DataSource = liste4;
            }
            else if (rbAIlebaslayan.Checked)
            {
                List<tblOgrenci> liste5 = db.tblOgrenci.Where(p => p.Adi.StartsWith("a")).ToList();
                dgvListe.DataSource = liste5;
            }
            else if (rbAIlebiten.Checked)
            {
                List<tblOgrenci> liste6 = db.tblOgrenci.Where(p => p.Adi.EndsWith("a")).ToList();
                dgvListe.DataSource = liste6;
            }
            else if (rbKayitvarmi.Checked)
            {
                bool deger = db.tblOgrenci.Any();
                MessageBox.Show(deger.ToString(),"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information );
            }
            else if (rbToplamSayi.Checked)
            {
                int toplam = db.tblOgrenci.Count();
                MessageBox.Show(toplam.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rbSnav1toplam.Checked)
            {
                var toplam = db.tblNotlar.Sum(p => p.Sinav1);
                MessageBox.Show("Toplam"+toplam.ToString());
            }
            else if (rbOrtalama.Checked)
            {
                var ortalama = db.tblNotlar.Average(p => p.Sinav1);
                MessageBox.Show("Ortalama",ortalama.ToString());
            }
            else if (rbEnyksk.Checked)
            {
                var enysk = db.tblNotlar.Max(p => p.Sinav1);
                MessageBox.Show("En Yuksek", enysk.ToString());
            }

            /*
             1.Sınavın Ortalamasından yüksek not alan kişiler listelensin
if (radioButton13.Checked == true)
            {
                var ortyuksek = db.TBLNOTLAR.Average(p => p.SINAV1);
                List<NOTLISTESI_Result> liste = db.NOTLISTESI().Where(p => p.SINAV1 > ortyuksek).ToList();
                dataGridView1.DataSource = liste;
            }
             

            En yüksek sınav notu kime ait?
if (radioButton14.Checked == true)
            {
                var enyuksekisim = db.TBLNOTLAR.Max(p => p.SINAV1);
                dataGridView1.DataSource = db.NOTLISTESI().Where(p => p.SINAV1 == enyuksekisim).ToList();
            }



             */

        }

        private void rbId_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            var sorgu = from d1 in db.tblNotlar
                        join d2 in db.tblOgrenci
                        on d1.OgrId equals d2.Id
                        join d3 in db.tblDersler
                        on d1.Ders equals d3.DersId
                        select new
                        {
                            Ogrenci = d2.Adi+ " "+ d2.Soyadi,
                           // Soyad=d2.Soyadi,
                           d3.DersAd,
                            Sınav1 = d1.Sinav1,
                            Sınav2 = d1.Sinav2,
                            Sınav3 = d1.Sinav3,
                            Ortalama = d1.Ortalama
                        };
            dgvListe.DataSource = sorgu.ToList();
        }

        private void btnDersListesi_Click(object sender, EventArgs e)
        {
            dgvListe.DataSource = db.tblDersler;
        }
    }
}
