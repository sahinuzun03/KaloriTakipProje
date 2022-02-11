using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaloriDeneme_1111.DataBase;
using KaloriDeneme_1111.ModelCluster;


namespace KaloriDeneme_1111
{
    public partial class Rapor1 : Form
    {
        Rapor1 rapor1;
        ÖğünKAyıt1 öğünKayıt1;
        public Rapor1()
        {
            InitializeComponent();
        }

        private void Rapor1_Load(object sender, EventArgs e)
        {
            KaloriDbContext db = new KaloriDbContext();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            rapor1 = new Rapor1();
            this.Hide();
            rapor1.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            öğünKayıt1 = new ÖğünKAyıt1();
            this.Hide();
            öğünKayıt1.ShowDialog();
        }
    }
}
