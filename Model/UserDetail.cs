using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public enum ActivityType { AktiviteYok=1, AzAktif=2,Aktif=3,ÇokAktif=4}
    public enum GenderType { Kadın=1,Erkek=2}
    public enum WeightTargetType {KiloAl=1,KiloKoru=2,KiloVer=3 }
    public enum DietType { Vejetaryen=1,Vegan=2,Pasketaryen=3,Paleo=4,Normal=5}
    public enum UserTypeDefinitions { BasicInfoSharedUser=1, FullInfoSharedUser=2, LimitedInfoSharedUser=3 }
    public enum BadgeType {AktiviteRozeti=1,DietRozeti=2,KiloHedefiRozeti=3,VKIRozeti=4,YaşRozeti=5,CinsiyetRozeti=6 }


    public class UserDetail
    {
        public int UserDetailID { get; set; }

        public virtual Age Age { get; set; }
        public int? AgeID { get; set; }

        public virtual BMI BMI { get; set; }
        public int? BMIID { get; set; }
        public ActivityType? Activity { get; set; }
        public GenderType? Gender { get; set; }
        public WeightTargetType? WeightTarget { get; set; }
        public DietType? Diet { get; set; }
        
        private int _UserTypes;

        public int UserTypes
        {
            
            get
            {

                if (_RozetListesi.Count == 0)
                {
                   return _UserTypes = (int)UserTypeDefinitions.BasicInfoSharedUser;
                }
                if (_RozetListesi.Count > 1 && _RozetListesi.Count < 6)
                {
                   return _UserTypes = (int)UserTypeDefinitions.LimitedInfoSharedUser;
                }
                if (_RozetListesi.Count == 6)
                {
                   return _UserTypes = (int)UserTypeDefinitions.FullInfoSharedUser;
                }
                else
                    return _UserTypes = (int)UserTypeDefinitions.BasicInfoSharedUser;

            }
        }
       
        public virtual ICollection<User> Users { get; set; }
        private List<BadgeType> _RozetListesi;

        public List<BadgeType> RozetListesi
        {
            get { return _RozetListesi; }
            set
            {
                if (this.Activity != null)
                {
                    _RozetListesi.Add(BadgeType.AktiviteRozeti);
                }
                if (this.Diet != null)
                {
                    _RozetListesi.Add(BadgeType.DietRozeti);
                }
                if (this.WeightTarget != null)
                {
                    _RozetListesi.Add(BadgeType.KiloHedefiRozeti);
                }
                if (this.Age != null)
                {
                    _RozetListesi.Add(BadgeType.YaşRozeti);
                }
                if (this.Gender != null)
                {
                    _RozetListesi.Add(BadgeType.CinsiyetRozeti);
                }
                if (this.BMI != null)
                {
                    _RozetListesi.Add(BadgeType.VKIRozeti);
                }
            }
        }


        public UserDetail()
        {
            Users = new HashSet<User>();
        }
    }
}
