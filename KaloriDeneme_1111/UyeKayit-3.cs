using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using KaloriDeneme_1111.ModelCluster;
using KaloriDeneme_1111.DataBase;
using System.Windows.Forms;

namespace KaloriDeneme_1111
{
    public partial class UyeKayit_3 : Form
    {
       public string MailAddress;
       public string NickName; 
        UyeKayit_4 uyeKayit_4;
        public UyeKayit_3()
        {
            InitializeComponent();
        }
        KaloriDbContext db = new KaloriDbContext();
        public User NewUser
        {
            get { return User.UserGenerate(); }
        }

        private void btnOtomatikSifreOlustur_Click(object sender, EventArgs e)
        {
            OtomatikŞifreOluşturmaMetodu();
        }

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            ŞifreDüzeyiKontrolEtMetodu();
        }

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            if (txtSifreOlustur.Text != txtSifreTekrarla.Text)
            {
                throw new Exceptions.ExceptionTekrarlıGirilenŞifrelerHatalı();
            }
            else
            {
                NewUser.Password = txtSifreOlustur.Text;
                db.Users.Add(NewUser);
                db.SaveChanges();
                uyeKayit_4 = new UyeKayit_4();
                this.Hide();
                uyeKayit_4.ShowDialog();
            }
        }
        public string OtomatikŞifreOluşturmaMetodu()
        {
            Random Rnd = new Random();
            StringBuilder StrBuild = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                int ASCII = Rnd.Next(32, 127);
                char Karakter = Convert.ToChar(ASCII);
                StrBuild.Append(Karakter);
            }
            string AutoPsw = StrBuild.ToString();
            return AutoPsw;
        }
        public void ŞifreDüzeyiKontrolEtMetodu()
        {
            int counter = 0;
            Regex pass = new Regex(@"[\w]");
            Regex sLetter = new Regex(@"[a-z]");
            Regex cLetter = new Regex(@"[A-Z]");
            Regex number = new Regex(@"[0-9]");
            Regex signs = new Regex(@"[\.]|[\?]|[\\]|[\*]|[\;]|[\,]|[\:]|[-_!']");

            if (pass.IsMatch(txtSifreOlustur.Text))
            {
                string sifre = txtSifreOlustur.Text;
                char[] sifredizisi = sifre.ToCharArray();
                for (int i = 0; i < sifredizisi.Length - 1; i++)
                {
                    if (sLetter.IsMatch(sifredizisi[i].ToString())) { counter++; }
                    if (cLetter.IsMatch(sifredizisi[i].ToString())) { counter++; }
                    if (number.IsMatch(sifredizisi[i].ToString())) { counter++; }
                    if (signs.IsMatch(sifredizisi[i].ToString())) { counter++; }
                }

                if (counter > 6)
                {
                    lblSifreDüzeyiRengi.Text = "Güvenli";
                    lblSifreDüzeyiRengi.BackColor = Color.Green;
                }
                if (counter == 6)
                {
                    lblSifreDüzeyiRengi.Text = "Yeterli";
                    lblSifreDüzeyiRengi.BackColor = Color.Yellow;
                }
                if (counter < 6)
                {
                    lblSifreDüzeyiRengi.Text = "Geçersiz";
                    lblSifreDüzeyiRengi.BackColor = Color.Red;
                }
            }
            else
            {
                throw new Exceptions.ExceptionŞifreTextAlanıBoş();
            }
        }
    }
}
