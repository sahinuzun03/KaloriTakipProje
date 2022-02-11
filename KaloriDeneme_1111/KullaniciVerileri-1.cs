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
    public partial class KullaniciVerileri_1 : Form
    {
        KullaniciVerileri_9 KullaniciVerileri_9;
        public KullaniciVerileri_1()
        {
            InitializeComponent();
        }

        KaloriDbContext db = new KaloriDbContext();

        public User NewUser
        {
            get { return User.UserGenerate(); }
        }

        private void Veriler_1_Load(object sender, EventArgs e)
        {
            db = new KaloriDbContext();
            
            ComboboxlarıDoldurMetodu();
        }

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            NewUser.UserDetail = new UserDetail() { User=NewUser, UserID=NewUser.UserID };

            foreach (Control item in grpHedef.Controls)
            {
                if (item is CheckBox)
                {
                    if (((CheckBox)item).Checked)
                    {
                        if (item.Name == "chkKiloAl")
                        {
                            
                            NewUser.UserDetail.WeightTarget = WeightTargetType.KiloAl;
                        }
                        if (item.Name == "chkKilomuKoru")
                        {
                            NewUser.UserDetail.WeightTarget = WeightTargetType.KiloKoru;
                        }
                        if (item.Name == "chkKiloVer")
                        {
                            NewUser.UserDetail.WeightTarget = WeightTargetType.KiloVer;
                        }
                    }
                }

            }

            foreach (Control act in grpAktivite.Controls)
            {
                if (act is CheckBox)
                {
                    if (((CheckBox)act).Checked)
                    {
                        if (act.Name == "chkAktiviteYok")
                        {
                            NewUser.UserDetail.Activity = ActivityType.AktiviteYok;
                        }
                        if (act.Name == "chkAzAktif")
                        {
                            NewUser.UserDetail.Activity = ActivityType.AzAktif;
                        }
                        if (act.Name == "chkAktif")
                        {
                            NewUser.UserDetail.Activity = ActivityType.Aktif;
                        }
                        if (act.Name == "chkCokAktif")
                        {
                            NewUser.UserDetail.Activity = ActivityType.ÇokAktif;
                        }
                    }
                }

            }
            foreach (Control diet in grpDiet.Controls)
            {
                if (diet is CheckBox)
                {
                    if (((CheckBox)diet).Checked)
                    {
                        if (diet.Name == "chkVejeteryan")
                        {
                            NewUser.UserDetail.Diet = DietType.Vejetaryen;
                        }
                        if (diet.Name == "chkVegan")
                        {
                            NewUser.UserDetail.Diet = DietType.Vegan;
                        }
                        if (diet.Name == "chkPesketaryen")
                        {
                            NewUser.UserDetail.Diet = DietType.Pasketaryen;
                        }
                        if (diet.Name == "chkPaleo")
                        {
                            NewUser.UserDetail.Diet = DietType.Paleo;
                        }
                        if (diet.Name == "chkKisitlamaYok")
                        {
                            NewUser.UserDetail.Diet = DietType.Normal;
                        }
                    }
                }


            }
            foreach (Control ctrl in grpCinsiyet.Controls)
            {
                if (ctrl is CheckBox)
                {
                    if (((CheckBox)ctrl).Checked)
                    {
                        if (ctrl.Name == "chkErkek")
                        {
                            NewUser.UserDetail.Gender = GenderType.Erkek;
                        }
                        if (ctrl.Name == "chkKadin")
                        {
                            NewUser.UserDetail.Gender = GenderType.Kadın;
                        }
                    }
                }

                if (ctrl is ComboBox)
                {
                    if (((ComboBox)ctrl).SelectedIndex != -1)
                    {
                        NewUser.UserDetail.CustomerAge = new Age() { CustomerAge = Convert.ToInt32(cmbYas.SelectedItem.ToString()) };
                    }
                }
            }


            if (cmbBoy.SelectedIndex != -1 && cmbKilo.SelectedIndex != -1)
            {
                NewUser.UserDetail.BMI = new BMI()
                {
                    CustomerHeight = Convert.ToDouble(cmbBoy.SelectedItem.ToString()),
                    CustomerWeight = Convert.ToDouble(cmbBoy.SelectedItem.ToString())
                };

                lblVKIHesabi.Text = NewUser.UserDetail.BMI.BodyMassIndex.ToString();

            }
            UserDetail updateddetail = db.UserDetails.Find(NewUser.UserID);
            updateddetail.Gender = NewUser.UserDetail.Gender;
            updateddetail.WeightTarget = NewUser.UserDetail.WeightTarget;
            updateddetail.Activity = NewUser.UserDetail.Activity;
            updateddetail.Diet = NewUser.UserDetail.Diet;
            updateddetail.BMI = NewUser.UserDetail.BMI;
            updateddetail.CustomerAge = NewUser.UserDetail.CustomerAge;
            db.SaveChanges();
            KullaniciVerileri_9 = new KullaniciVerileri_9();
            this.Hide();
            KullaniciVerileri_9.ShowDialog();
            
        }

        #region Seçimler Birden Çok Olamaz
        //Hedef Seçimi
        private void chkKiloAl_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKiloAl.Checked == true)
            {
                chkKilomuKoru.Checked = false;
                chkKiloVer.Checked = false;
            }

        }

        private void chkKilomuKoru_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKilomuKoru.Checked == true)
            {
                chkKiloAl.Checked = false;
                chkKiloVer.Checked = false;
            }

        }

        private void chkKiloVer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKiloVer.Checked == true)
            {
                chkKiloAl.Checked = false;
                chkKilomuKoru.Checked = false;
            }

        }

        // Cinsiyet Seçimi
        private void chkErkek_CheckedChanged(object sender, EventArgs e)
        {
            if (chkErkek.Checked == true)
            {
                chkKadin.Checked = false;
            }
        }

        private void chkKadin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKadin.Checked == true)
            {
                chkErkek.Checked = false;
            }
        }


        // Aktivite Seçimi
        private void chkAktiviteYok_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAktiviteYok.Checked == true)
            {
                chkAzAktif.Checked = false;
                chkAktif.Checked = false;
                chkCokAktif.Checked = false;
            }
        }

        private void chkAzAktif_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAzAktif.Checked == true)
            {
                chkAktiviteYok.Checked = false;
                chkAktif.Checked = false;
                chkCokAktif.Checked = false;
            }
        }

        private void chkAktif_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAktif.Checked == true)
            {
                chkAktiviteYok.Checked = false;
                chkAzAktif.Checked = false;
                chkCokAktif.Checked = false;
            }
        }

        private void chkCokAktif_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCokAktif.Checked == true)
            {
                chkAktiviteYok.Checked = false;
                chkAzAktif.Checked = false;
                chkAktif.Checked = false;
            }
        }


        // Diet Seçimi
        private void chkVejeteryan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVejeteryan.Checked == true)
            {
                chkVegan.Checked = false;
                chkPesketaryen.Checked = false;
                chkPaleo.Checked = false;
                chkKisitlamaYok.Checked = false;
            }
        }

        private void chkVegan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVegan.Checked == true)
            {
                chkVejeteryan.Checked = false;
                chkPesketaryen.Checked = false;
                chkPaleo.Checked = false;
                chkKisitlamaYok.Checked = false;
            }
        }

        private void chkPesketaryen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPesketaryen.Checked == true)
            {
                chkVegan.Checked = false;
                chkVejeteryan.Checked = false;
                chkPaleo.Checked = false;
                chkKisitlamaYok.Checked = false;
            }
        }

        private void chkPaleo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPaleo.Checked == true)
            {
                chkVegan.Checked = false;
                chkPesketaryen.Checked = false;
                chkVejeteryan.Checked = false;
                chkKisitlamaYok.Checked = false;
            }
        }

        private void chkKisitlamaYok_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKisitlamaYok.Checked == true)
            {
                chkVegan.Checked = false;
                chkPesketaryen.Checked = false;
                chkPaleo.Checked = false;
                chkVejeteryan.Checked = false;
            }
        }

        #endregion
        public void ComboboxlarıDoldurMetodu()
        {
            for (int i = 18; i < 100; i++)
            {
                cmbYas.Items.Add((i));
            }
            for (double i = 35; i < 200; i += 0.5)
            {
                cmbKilo.Items.Add(i);
            }
            for (int i = 130; i < 210; i++)
            {
                cmbBoy.Items.Add(i);
            }
        }

    }
}


