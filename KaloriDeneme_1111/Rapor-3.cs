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
    public partial class Rapor_3 : Form
    {
        public Rapor_3()
        {
            InitializeComponent();
        }
        public User NewUser
        {
            get { return User.UserGenerate(); }
        }
        KaloriDbContext db = new KaloriDbContext();
        private void Rapor_3_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString()=="Sabah")
            {
                dataGridView1.DataSource = db.Meals.Where(x => x.RecordDate.Day == dateTimePicker1.Value.Day && x.MealType == MealType.Sabah && x.UserID == NewUser.UserID).SelectMany(a => a.Nutrients).ToList();
            }
            if (comboBox1.SelectedItem.ToString() == "Öğlen")
            {
                dataGridView1.DataSource = db.Meals.Where(x => x.RecordDate.Day == dateTimePicker1.Value.Day && x.MealType == MealType.Sabah && x.UserID == NewUser.UserID).SelectMany(a => a.Nutrients).ToList();
            }
            if (comboBox1.SelectedItem.ToString() == "Akşam")
            {
                dataGridView1.DataSource = db.Meals.Where(x => x.RecordDate.Day == dateTimePicker1.Value.Day && x.MealType == MealType.Akşam && x.UserID == NewUser.UserID).SelectMany(a => a.Nutrients).ToList();
            }
            if (comboBox1.SelectedItem.ToString() == "Aperatifler")
            {
                dataGridView1.DataSource = db.Meals.Where(x => x.RecordDate.Day == dateTimePicker1.Value.Day && x.MealType == MealType.Aperatifler && x.UserID == NewUser.UserID).SelectMany(a => a.Nutrients).ToList();
            }

        }
    }
}
