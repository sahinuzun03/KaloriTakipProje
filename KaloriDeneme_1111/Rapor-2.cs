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
    public partial class Rapor_2 : Form
    {
        public Rapor_2()
        {
            InitializeComponent();
        }
        public User NewUser
        {
            get { return User.UserGenerate(); }
        }
        KaloriDbContext db;
        Rapor1 Rapor1 = new Rapor1();


        private void Rapor_2_Load(object sender, EventArgs e)
        {
            

        }
        public void DailyMealCalorieCalculation()
        {
            db = new KaloriDbContext();
            double sumSabah = 0;
            foreach (var item in db.Meals.Where(x => x.RecordDate.Day == Rapor1.dateTimePicker1.Value.Day && x.MealType == MealType.Sabah).Select(a => a.MealTotalCalorie).ToList())
            {
                sumSabah = 0;
                sumSabah += item;
            }
            label6.Text = sumSabah.ToString();

            double sumÖğlen = 0;
            foreach (var item in db.Meals.Where(x => x.RecordDate.Day == Rapor1.dateTimePicker1.Value.Day && x.MealType == MealType.Öğlen).Select(a => a.MealTotalCalorie).ToList())
            {
                sumÖğlen = 0;
                sumÖğlen += item;
            }
            label7.Text = sumÖğlen.ToString();

            double sumAkşam = 0;
            foreach (var item in db.Meals.Where(x => x.RecordDate.Day == Rapor1.dateTimePicker1.Value.Day && x.MealType == MealType.Akşam).Select(a => a.MealTotalCalorie).ToList())
            {
                sumAkşam = 0;
                sumAkşam += item;
            }
            label8.Text = sumAkşam.ToString();

            double sumAperatif = 0;
            foreach (var item in db.Meals.Where(x => x.RecordDate.Day == Rapor1.dateTimePicker1.Value.Day && x.MealType == MealType.Aperatifler).Select(a => a.MealTotalCalorie).ToList())
            {
                sumAperatif = 0;
                sumAperatif += item;
            }
            label9.Text = sumAperatif.ToString();


        }
    }
}
