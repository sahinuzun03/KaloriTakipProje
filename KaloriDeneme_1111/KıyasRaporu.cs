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
    public partial class KıyasRaporu : Form
    {
        public KıyasRaporu()
        {
            InitializeComponent();
        }
        KaloriDbContext db;
        public User NewUser
        {
            get { return User.UserGenerate(); }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            db = new KaloriDbContext();
            dgv_AylıkRapor.DataSource = db.Users
                .Where(x =>
            x.UserDetail.CustomerAge.AgeInterval == NewUser.UserDetail.CustomerAge.AgeInterval &&
            x.UserDetail.BMI.BMIInterval == NewUser.UserDetail.BMI.BMIInterval &&
            x.UserDetail.Gender == NewUser.UserDetail.Gender &&
            x.UserDetail.WeightTarget == NewUser.UserDetail.WeightTarget &&
            x.UserDetail.Activity == NewUser.UserDetail.Activity &&
            x.UserDetail.Diet == NewUser.UserDetail.Diet)
                .SelectMany(a => a.Meals.Where(b => b.RecordDate.Month == dateTimePicker1.Value.Month).Select(x => x.Nutrients.Select(y => y.NutrientCategory))).ToList();
            DateTime dt1 = (DateTime)dateTimePicker1.Value.AddDays(-7);


            dgv_HaftalıkRapor.DataSource = db.Users
                    .Where(x =>
                x.UserDetail.CustomerAge.AgeInterval == NewUser.UserDetail.CustomerAge.AgeInterval &&
                x.UserDetail.BMI.BMIInterval == NewUser.UserDetail.BMI.BMIInterval &&
                x.UserDetail.Gender == NewUser.UserDetail.Gender &&
                x.UserDetail.WeightTarget == NewUser.UserDetail.WeightTarget &&
                x.UserDetail.Activity == NewUser.UserDetail.Activity &&
                x.UserDetail.Diet == NewUser.UserDetail.Diet)
                    .SelectMany(a => a.Meals.Where(b => b.RecordDate> dt1).Select(x => x.Nutrients.Select(y => y.NutrientCategory))).ToList();
        }
    }
}
