using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail; // Mail için çağırmam gereken kütüphane eklendi
using KaloriDeneme_1111.ModelCluster;
using KaloriDeneme_1111.DataBase;
using KaloriDeneme_1111.Exceptions;


namespace KaloriDeneme_1111
{
    public partial class ÜyeKayıt_2 : Form
    {
        UyeKayit_3 uyeKayit_3;
        public ÜyeKayıt_2()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        string onaykodu;
        private void btnMailOnay_Click(object sender, EventArgs e)
        {
            MailOnaylamaMetodu();
        }
        public User NewUser
        {
            get { return User.UserGenerate(); }
        }

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.TextLength < 3)
            {
                throw new ExceptionKullanıcıAdıUzunluk();

            }
            if (txtOnayKodu.Text != onaykodu)
            {
                throw new ExceptionMailOnayKoduHatası();
            }
            else
            {
                NewUser.MailAddress = txtMailGir.Text;
                NewUser.NickName = txtKullaniciAdi.Text;
                this.Hide();
                uyeKayit_3 = new UyeKayit_3();
                uyeKayit_3.ShowDialog();
            }
        }
        private void lblSartlarveKosullar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kullanıcıların tamamı, Fatfighters'yi yalnızca hukuka uygun ve şahsi amaçlarla kullanacaklarını ve üçüncü kişinin haklarına tecavüz teşkil edecek nitelikteki herhangi bir faaliyette bulunmayacağını taahhüt eder. Fatfighters dâhilinde yaptıkları işlem ve eylemlerindeki, hukuki ve cezai sorumlulukları kendilerine aittir. İşbu iş ve eylemler sebebiyle, üçüncü kişilerin uğradıkları veya uğrayabilecekleri zararlardan dolayı Fatfighters'nin doğrudan ve/veya dolaylı hiçbir sorumluluğu yoktur. \nFatfighters'de mevcut bilgilerin doğruluk ve güncelliğini sağlamak için elimizden geleni yapmaktayız. Lakin gösterdiğimiz çabaya rağmen, bu bilgiler, fiili değişikliklerin gerisinde kalabilir, birtakım farklılıklar olabilir. Bu sebeple, site içerisinde yer alan bilgilerin doğruluğu ve güncelliği ile ilgili tarafımızca, açık veya zımni, herhangi bir garanti verilmemekte, hiçbir taahhütte bulunulmamaktadır.\n Fatfighters'yi virüslerden temizlenmiş tutmak konusunda elimizden geleni yapsak da, virüslerin tamamen bulunmadığı garantisini vermemekteyiz. Bu nedenle veri indirirken, virüslere karşı gerekli önlemi almak, kullanıcıların sorumluluğundadır. Virüs vb. kötü amaçlı programlar, kodlar veya materyallerin sebep olabileceği zararlardan dolayı sorumluluk kabul etmemekteyiz.\nFatfighters'de sunulan hizmetlerde, kusur veya hata olmayacağına ya da kesintisiz hizmet verileceğine dair garanti vermemekteyiz. Fatfighters'ye ve sitenin hizmetlerine veya herhangi bir bölümüne olan erişiminizi önceden bildirmeksizin herhangi bir zamanda sonlandırabiliriz.", "Şartlar ve Koşullar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblGizlilikPolitikasi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gizlilik, ayrı bir sayfada, kişisel verilerinizin tarafımızca işlenmesinin esaslarını düzenlemek üzere mevcuttur. Fatfighters'yi kullandığınız takdirde, bu verilerin işlenmesinin gizlilik politikasına uygun olarak gerçekleştiğini kabul edersiniz.", "Gizlilik", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void MailOnaylamaMetodu()
        {
            onaykodu = uyeKayit_3.OtomatikŞifreOluşturmaMetodu();
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential("fatfightersonproje@gmail.com", "fatfatfat");
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("fatfightersonproje@gmail.com", "FatFighters");
            mail.To.Add(txtMailGir.Text);
            mail.Subject = "OnayKodu"; mail.IsBodyHtml = true; mail.Body = onaykodu;
            sc.Send(mail);
        }
    }
}
