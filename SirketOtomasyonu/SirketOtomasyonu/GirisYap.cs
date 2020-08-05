using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketOtomasyonu
{
    public partial class GirisYap : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        SirketOtomasyonu.kullaniciGiris model = new SirketOtomasyonu.kullaniciGiris();

        public GirisYap()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            string mail = textBoxMailGiris.Text;
            string sifre = textBoxSifreGiris.Text;
            con = new SqlConnection("server=(localdb)\\MSSQLLocalDB; Initial Catalog=SirketOtomasyon; Integrated Security=SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kullaniciGiris where mailAdres='" + textBoxMailGiris.Text + "' AND sifre='" + textBoxSifreGiris.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                Anasayfa ana = new Anasayfa();
                ana.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.","Hata!");
            }

            con.Close();

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
          
        }

         Point lastPoint;

        public FormWindowState WindowsState { get; private set; }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

  
        private void kayitYazi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form kayit = new KayitOl();
            kayit.Show();
        }

      
    }
}
