using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaloriDeneme_1111.ModelCluster;

namespace KaloriDeneme_1111
{
    public partial class UyeBilgiGiris_2 : Form
    {
        KullaniciVerileri_1 kullaniciVerileri_1;
        public string MailAddress;
        ÖğünKAyıt1 öğünKAyıt1;
        public UyeBilgiGiris_2()
        {
            InitializeComponent();
        }
        public User NewUser
        {
            get { return User.UserGenerate(); }
        }
        private void btnBilgiGirisiYap_Click(object sender, EventArgs e)
        {
            kullaniciVerileri_1 = new KullaniciVerileri_1();
            this.Hide();
            kullaniciVerileri_1.ShowDialog();
            
        }

        private void btnBilgiGirisiYapma_Click(object sender, EventArgs e)
        {
            öğünKAyıt1 = new ÖğünKAyıt1();
            this.Hide();
            öğünKAyıt1.ShowDialog();
        }
    }
}
