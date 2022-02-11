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
    public partial class UyeKayit_5 : Form
    {
        public UyeKayit_5()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            Form1 ilkGirisSayfasi = new Form1();
            this.Hide();
            ilkGirisSayfasi.ShowDialog();
            
        }

        private void btnOturumAc_Click(object sender, EventArgs e)
        {
            UyeKayit_4 girisYapSayfasi = new UyeKayit_4();
            this.Hide();
            girisYapSayfasi.ShowDialog();
            
        }
    }
}
