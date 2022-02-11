using KaloriDeneme_1111.DataBase;
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
    public partial class KullaniciVerileri_9 : Form
    {
        ÖğünKAyıt1 ÖğünKAyıt1;
        KaloriDbContext db;
        
        public KullaniciVerileri_9()
        {
            InitializeComponent();
        }

        public User NewUser
        {
            get { return User.UserGenerate(); }
        }
        private void KullaniciVerileri_9_Load(object sender, EventArgs e)
        {
            db = new KaloriDbContext();

            if (NewUser.UserDetail.WeightTarget!=null)
            {
                label1.BackColor = Color.BlueViolet;
                label1.ForeColor = Color.AntiqueWhite;
                this.BackColor = Color.AntiqueWhite;
            }
            if (NewUser.UserDetail.Gender != null)
            {
                label2.BackColor = Color.BlueViolet;
                label2.ForeColor = Color.AntiqueWhite;
                this.BackColor = Color.AntiqueWhite;
            }
            if (NewUser.UserDetail.Activity != null)
            {
                label3.BackColor = Color.BlueViolet;
                label3.ForeColor = Color.AntiqueWhite;
                this.BackColor = Color.AntiqueWhite;
            }
            if (NewUser.UserDetail.CustomerAge != null)
            {
                label4.BackColor = Color.BlueViolet;
                label4.ForeColor = Color.AntiqueWhite;
                this.BackColor = Color.AntiqueWhite;
            }
            if (NewUser.UserDetail.BMI != null)
            {
                label5.BackColor = Color.BlueViolet;
                label5.ForeColor = Color.AntiqueWhite;
                this.BackColor = Color.AntiqueWhite;
            }
            if (NewUser.UserDetail.Diet != null)
            {
                label6.BackColor = Color.BlueViolet;
                label6.ForeColor = Color.AntiqueWhite;
                this.BackColor = Color.AntiqueWhite;
            }
        }

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            ÖğünKAyıt1 = new ÖğünKAyıt1();
            this.Close();
            ÖğünKAyıt1.ShowDialog();
        }
    }
}
