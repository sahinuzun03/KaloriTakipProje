using System;
using System.Collections.Generic;
using System.Text;

namespace KaloriDeneme_1111.ModelCluster
{
    //BURAYA TEKRAR BAKILACAK--> RAPORLAMA SAYFASINDAKİ ÇIKTI İÇİN YAŞ ARALIĞI NASIL GÖSTERİLECEK??
    public enum AgeType { aralık1 = 1, aralık2 = 2, aralık3 = 3, aralık4 = 4, aralık5 = 5,aralık6=6 }
    public class Age
    {
        public int UserID { get; set; }
        public int CustomerAge { get; set; }
        public UserDetail UserDetail { get; set; }
        //private int _ageInterval;


        public int AgeInterval
        {
            get
            {
                if (this.CustomerAge <= 24)
                {
                   return /*_ageInterval =*/ (int)AgeType.aralık1;
                }
                if (24 < this.CustomerAge && CustomerAge <= 35)
                {
                   return /*_ageInterval =*/ (int)AgeType.aralık2;
                }
                if (35 < this.CustomerAge && this.CustomerAge <= 45)
                {
                   return /*_ageInterval =*/ (int)AgeType.aralık3;
                }
                if (45 < this.CustomerAge && this.CustomerAge <= 55)
                {
                   return /*_ageInterval =*/ (int)AgeType.aralık4;
                }
                if (55 < this.CustomerAge && this.CustomerAge <= 65)
                {
                   return /*_ageInterval =*/ (int)AgeType.aralık5;
                }
                else
                {
                   return /*_ageInterval = */(int)AgeType.aralık6;
                }
            }
            protected set { }
        }
        public Age()
        {

        }
    }
}
