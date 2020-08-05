using SirketOtomasyonu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketOtomasyonu
{
    public partial class KayitOl : Form
    {

        Random rastgele = new Random();
        SirketOtomasyonu.kullaniciGiris model = new SirketOtomasyonu.kullaniciGiris();

        public KayitOl()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
        }

        void Clear()
        {
            textBoxAdSoyadKayit.Text = textBoxDepartmanKayit.Text = textBoxAdresKayit.Text = textBoxSifreKayit.Text = textBoxMailKayit.Text = textBoxTelefonKayit.Text = "";
        }

        private void kayitButton_Click(object sender, EventArgs e)
        {
            List<int> listNumbers = new List<int>(); // Kullanıcı ID'leri listede tutulacak eğer listede mevcutsa farklı bir ID atanacak.
                do
                {
                  model.kullaniciID = rastgele.Next(100000000, 1000000000); // 100 Milyon ile 1 Milyar Arasında Rastgele bir ID atayacak.
                } while (listNumbers.Contains(model.kullaniciID));
                listNumbers.Add(model.kullaniciID);
  
            
            model.adSoyad = textBoxAdSoyadKayit.Text.Trim();
            model.departman = textBoxDepartmanKayit.Text.Trim();
            model.mailAdres = textBoxMailKayit.Text.Trim();
            model.telefonNo = textBoxTelefonKayit.Text.Trim();
            model.sifre = textBoxSifreKayit.Text.Trim();
            model.adres = textBoxAdresKayit.Text.Trim();
            

            using (SirketEntities db = new SirketEntities())
            {
                   //Kullanici kaydet - Insert user
                    db.kullaniciGiris.Add(model);
                    db.SaveChanges();
            }

            Clear();

            MessageBox.Show("Başarıyla kaydedildi!","Kayıt İşlemi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void KayitOl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;

        private void KayitOl_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void kayitYazi_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirisYap g1 = new GirisYap();
            g1.Show();
        }
    }
}
