using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    //BURAYA TEKRAR BAKILACAK--> RAPORLAMA SAYFASINDAKİ ÇIKTI İÇİN YAŞ ARALIĞI NASIL GÖSTERİLECEK??
    public enum AgeType { aralık1=1, aralık2=2, aralık3=3, aralık4=4, aralık5=5 }
    public class Age
    {
        public int AgeID { get; set; }
        public int CustomerAge { get; set; }
        private int _ageInterval;

        public int AgeInterval
        {
            get { return _ageInterval; }
            set
            {
                if (value <= 24)
                {
                    _ageInterval = (int)AgeType.aralık1;
                }
                if (24 < value && value <= 35)
                {
                    _ageInterval = (int)AgeType.aralık2;
                }
                if (35 < value && value <=45)
                {
                    _ageInterval = (int)AgeType.aralık3;
                }
                if (45 < value && value <= 55)
                {
                    _ageInterval = (int)AgeType.aralık4;
                }
                if (55 < value && value <= 65)
                {
                    _ageInterval = (int)AgeType.aralık5;
                }
            }
        }
        public ICollection<UserDetail> UserDetails { get; set; }
        public Age()
        {
            UserDetails = new List<UserDetail>();
        }
    }
}
