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
using KaloriDeneme_1111.Exceptions;

namespace KaloriDeneme_1111
{

    public partial class UyeKayit_4 : Form
    {

        KaloriDbContext db = new KaloriDbContext();
        UyeBilgiGiris_2 uyeBilgiGiris_2;
        public UyeKayit_4()
        {
            InitializeComponent();
            txtEpostaGir.Text = "uzunvalorant@gmail.com";
            txtSifreGir.Text = "Su.3!Su.3!";
        }
        public User NewUser
        {
            get
            {
                return User.UserGenerate();
            }
        }

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            RegenerateUserObjectFromDB();
            if (NewUser.Password == txtSifreGir.Text)
            {
                uyeBilgiGiris_2 = new UyeBilgiGiris_2();
                this.Hide();
                uyeBilgiGiris_2.ShowDialog();
            }
            else
            {
                throw new ExceptionŞifreHatalı();
            }
        }
        private void btnHesabimiSil_Click(object sender, EventArgs e)
        {
            RegenerateUserObjectFromDB();
            if (chkHesabimiSil.Checked == true)
            {
                if (NewUser.Password == txtSifreGir.Text)
                {
                    db.Users.Remove(NewUser);
                    db.SaveChanges();
                }
                else
                {
                    throw new ExceptionŞifreHatalı();
                }
            }
            else
            {
                throw new Exception("Lütfen hesabınızı silme isteğinizi onaylayınız");
            }
        }
        private void lblSifremiUnuttum_Click(object sender, EventArgs e)
        {

        }
        public void RegenerateUserObjectFromDB()
        {
            NewUser.UserID = db.Users.Where(x => x.MailAddress == txtEpostaGir.Text).Select(x => x.UserID).FirstOrDefault();
            NewUser.MailAddress = db.Users.Where(x => x.MailAddress == txtEpostaGir.Text).Select(x => x.MailAddress).FirstOrDefault();
            NewUser.Password = db.Users.Where(x => x.MailAddress == txtEpostaGir.Text).Select(x => x.Password).FirstOrDefault();
            NewUser.NickName = db.Users.Where(x => x.MailAddress == txtEpostaGir.Text).Select(x => x.NickName).FirstOrDefault();
        }
    }
}

