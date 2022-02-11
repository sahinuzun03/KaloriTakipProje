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
using KaloriDeneme_1111.DataBase;

namespace KaloriDeneme_1111
{
    public partial class ÖğünKAyıt1 : Form
    {
       
        ÖğünKayıt2 öğünKayıt2;
        ÖğünKAyıt1 öğünKayıt1;
        public ÖğünKAyıt1()
        {
            InitializeComponent();
            ListViewItem lvi = new ListViewItem();
        }
        private void ÖğünKAyıt1_Load(object sender, EventArgs e)
        {
                  
        }
        private void btnKahvaltıEkle_Click(object sender, EventArgs e)
        {
        }

        private void btnOgleYemegiEkle_Click(object sender, EventArgs e)
        {
        }

        private void btnAksamYemegiEkle_Click(object sender, EventArgs e)
        {
        }

        private void btnAperatifYemegiEkle_Click(object sender, EventArgs e)
        {
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            öğünKayıt2 = new ÖğünKayıt2();
            öğünKayıt2.RecordDate = dateTimePicker1.Value;
            switch (btn.Name)
            {
                case "btnKahvaltıEkle":
                    öğünKayıt2.MealType = MealType.Sabah;
                    break;
                case "btnOgleYemegiEkle":
                    öğünKayıt2.MealType = MealType.Öğlen;
                    break;
                case "btnAksamYemegiEkle":
                    öğünKayıt2.MealType = MealType.Akşam;
                    break;
                case "btnAperatifYemegiEkle":
                    öğünKayıt2.MealType = MealType.Aperatifler;
                    break;
                default:
                    break;
            }
            
            this.Hide();
            öğünKayıt2.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            öğünKayıt1 = new ÖğünKAyıt1();
            this.Hide();
            öğünKayıt1.ShowDialog();
        }
    }
}
