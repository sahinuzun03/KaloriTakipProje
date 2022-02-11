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
    public partial class ÖğünKayıt2 : Form
    {
        KaloriDbContext db;
        public DateTime RecordDate;
        public MealType MealType;
        ÖğünKAyıt1 ÖğünKAyıt1 = new ÖğünKAyıt1();

        public ÖğünKayıt2()
        {
            InitializeComponent();
        }
        public User NewUser
        {
            get { return User.UserGenerate(); }
        }
        private void cmbBesinler_Click(object sender, EventArgs e)
        {
            string besin = txtBesinAdiGir.Text;
            db = new KaloriDbContext();
            List<Nutrient> nutrientList = new List<Nutrient>();
            nutrientList = db.Nutrients.Where(x => x.NutrientName.Contains(txtBesinAdiGir.Text.ToLower())).ToList();
            foreach (Nutrient nutr in nutrientList)
            {
                cmbBesinler.Items.Add(nutr.NutrientName);
            }
        }

        private void cmbBesinler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbÖlçekler.Items.Clear();

            string secilenBesin = cmbBesinler.SelectedItem.ToString();
            List<Scale> scaleList = new List<Scale>();
            scaleList = db.Nutrients.Where(x => x.NutrientName == secilenBesin).SelectMany(x => x.Scales).ToList();

            foreach (Scale item in scaleList)
            {
                cmbÖlçekler.Items.Add(item.ScaleType);
            }
            for (int i = 1; i < 21; i++)
            {
                cmbMiktar.Items.Add(i);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MEAL EKLE
            NewUser.Meals = new List<Meal>() { };

            for (int i = 0; i < Convert.ToInt32(cmbMiktar.SelectedItem.ToString()); i++)
            {
                Meal newMeal = new Meal() { UserID = NewUser.UserID, RecordDate = this.RecordDate, MealType = this.MealType };
                db.Meals.Add(newMeal);
                db.SaveChanges();

                //Nutrient ID
                Nutrient newNutrient = new Nutrient();
                int nutrientID = db.Nutrients.Where(x => x.NutrientName == cmbBesinler.SelectedItem.ToString()).FirstOrDefault().NutrientID;
                newNutrient.NutrientID = nutrientID;

                Nutrient nutr = db.Nutrients.Where(x => x.NutrientID == nutrientID).FirstOrDefault();
                newNutrient = nutr;

                //Nutrient CategoryID

                int nutrientCategoryID = db.Nutrients.Where(x => x.NutrientName == cmbBesinler.SelectedItem.ToString()).FirstOrDefault().NutrientCategoryID;
                newNutrient.NutrientCategoryID = nutrientCategoryID;

                NutrientCategory nutrientCategory = db.NutrientCategories.Where(x => x.NutrientCategoryID == nutrientCategoryID).FirstOrDefault();
                newNutrient.NutrientCategory = nutrientCategory;

                string nutrientCategoryName = db.Nutrients.Where(x => x.NutrientName == cmbBesinler.SelectedItem.ToString()).FirstOrDefault().NutrientName;
                newNutrient.NutrientName = nutrientCategoryName;


                //BESİN NESNESİNİN İÇİNDEKİ SCALE'İ OLUŞTURMA
                Scale newScale = new Scale();

                int scaleID = db.Scales.Where(x => x.Nutrient.NutrientID == nutrientID && x.ScaleType == (ScaleTypes)cmbÖlçekler.SelectedItem).FirstOrDefault().ScaleID;

                newScale = db.Scales.Where(x => x.ScaleID == scaleID).FirstOrDefault();

                //SCALE NESNESİNİ BESİN NESNESİNE KAYDETME
                newNutrient.Scales.Add(newScale);
                newMeal.Nutrients.Add(newNutrient);
                if (newMeal.MealTotalCalorie != 0)
                    newMeal.MealTotalCalorie += newScale.UnitCalorie * Convert.ToInt32(cmbMiktar.SelectedItem.ToString());
                newMeal.MealTotalCalorie = newScale.UnitCalorie * Convert.ToInt32(cmbMiktar.SelectedItem.ToString());

                db.SaveChanges();

                FillTheDailyList();
                DailyMealCalorieCalculation();
                ÖğünKAyıt1.Show();
            }
        }
        public void FillTheDailyList()
        {
            foreach (Nutrient ntr in db.Meals.Where(x => x.RecordDate.Day == RecordDate.Day && x.MealType == MealType.Sabah && x.UserID == NewUser.UserID).SelectMany(a => a.Nutrients).ToList())
            {
                ListViewItem sabahListesi = new ListViewItem();
                sabahListesi.Text = ntr.NutrientName.ToString();
                sabahListesi.SubItems.Add(ntr.NutrientCategoryID.ToString());
                ÖğünKAyıt1.lst_kahvaltı.Items.Add(sabahListesi);
                sabahListesi.Tag = ntr;
            }

            foreach (Nutrient ntr in db.Meals.Where(x => x.RecordDate.Day == RecordDate.Day && x.MealType == MealType.Akşam && x.UserID == NewUser.UserID).SelectMany(a => a.Nutrients).ToList())
            {
                ListViewItem akşamListesi = new ListViewItem();
                akşamListesi.Text = ntr.NutrientName.ToString();
                akşamListesi.SubItems.Add(ntr.NutrientCategoryID.ToString());
                ÖğünKAyıt1.list_aksam.Items.Add(akşamListesi);
                akşamListesi.Tag = ntr;
            }

            foreach (Nutrient ntr in db.Meals.Where(x => x.RecordDate.Day == RecordDate.Day && x.MealType == MealType.Öğlen && x.UserID == NewUser.UserID).SelectMany(a => a.Nutrients).ToList())
            {
                ListViewItem öğlenListesi = new ListViewItem();
                öğlenListesi.Text = ntr.NutrientName.ToString();
                öğlenListesi.SubItems.Add(ntr.NutrientCategoryID.ToString());
                ÖğünKAyıt1.list_ogleyemeği.Items.Add(öğlenListesi);
                öğlenListesi.Tag = ntr;
            }

            foreach (Nutrient ntr in db.Meals.Where(x => x.RecordDate.Day == RecordDate.Day && x.MealType == MealType.Aperatifler && x.UserID == NewUser.UserID).SelectMany(a => a.Nutrients).ToList())
            {
                ListViewItem aperatifListesi = new ListViewItem();
                aperatifListesi.Text = ntr.NutrientName.ToString();
                aperatifListesi.SubItems.Add(ntr.NutrientCategoryID.ToString());
                ÖğünKAyıt1.lst_aperatif.Items.Add(aperatifListesi);
                aperatifListesi.Tag = ntr;
            }
        }
        public void DailyMealCalorieCalculation()
        {
            double sumSabah = 0;
            foreach (var item in db.Meals.Where(x => x.RecordDate.Day == RecordDate.Day && x.MealType == MealType.Sabah).Select(a => a.MealTotalCalorie).ToList())
            {
                sumSabah = 0;
                sumSabah += item;
            }
            ÖğünKAyıt1.lblkahvaltıKalori.Text = sumSabah.ToString();

            double sumÖğlen = 0;
            foreach (var item in db.Meals.Where(x => x.RecordDate.Day == RecordDate.Day && x.MealType == MealType.Öğlen).Select(a => a.MealTotalCalorie).ToList())
            {
                sumÖğlen = 0;
                sumÖğlen += item;
            }
            ÖğünKAyıt1.lbloglenKalori.Text = sumÖğlen.ToString();

            double sumAkşam = 0;
            foreach (var item in db.Meals.Where(x => x.RecordDate.Day == RecordDate.Day && x.MealType == MealType.Akşam).Select(a => a.MealTotalCalorie).ToList())
            {
                sumAkşam = 0;
                sumAkşam += item;
            }
            ÖğünKAyıt1.lblaksamKalori.Text = sumAkşam.ToString();

            double sumAperatif = 0;
            foreach (var item in db.Meals.Where(x => x.RecordDate.Day == RecordDate.Day && x.MealType == MealType.Aperatifler).Select(a => a.MealTotalCalorie).ToList())
            {
                sumAperatif = 0;
                sumAperatif += item;
            }
            ÖğünKAyıt1.lblaperatifKalori.Text = sumAperatif.ToString();
            ÖğünKAyıt1.lblToplamKalori.Text = (sumAperatif + sumAkşam + sumÖğlen + sumSabah).ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            KullaniciVerileri_9 kullaniciVerileri_9 = new KullaniciVerileri_9();
            this.Close();
            kullaniciVerileri_9.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            ÖğünKAyıt1.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Rapor1 rapor1 = new Rapor1();
            this.Close();
            rapor1.Show();
        }
    }
}