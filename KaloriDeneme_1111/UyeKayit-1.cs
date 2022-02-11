using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaloriDeneme_1111
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYeniKullanici_Click(object sender, EventArgs e)
        {
            // Kullanıcı kaydı için gereken form ekranını açıyor, gelen ekran mail giriniz ekranı yani ÜyeKayit-2 formu açılacak.
            ÜyeKayıt_2 üyeKayıt_2 = new ÜyeKayıt_2();
            // normal şekilde formu açar. İki form arasında geçiş yapabilir formun arkasında ilk form kalır ve ona tekrar dönülebilir
            // mailAdresiniGir.Show(); 
            // dialog modda açar. Formlar arasında geçiş sağlanmaz bizim bunu kullanacağız.
            this.Hide();
            üyeKayıt_2.ShowDialog();
            

        }

        private void btnHesabimVar_Click(object sender, EventArgs e)
        {
            UyeKayit_4 uyeKayit_4 = new UyeKayit_4();
            this.Hide();
            uyeKayit_4.ShowDialog();
            
        }
    }
}
