using System;
using System.Collections.Generic;
using System.Text;

namespace KaloriDeneme_1111.ModelCluster
{
    public enum ActivityType { AktiviteYok = 1, AzAktif = 2, Aktif = 3, ÇokAktif = 4 }
    public enum GenderType { Kadın = 1, Erkek = 2 }
    public enum WeightTargetType { KiloAl = 1, KiloKoru = 2, KiloVer = 3 }
    public enum DietType { Vejetaryen = 1, Vegan = 2, Pasketaryen = 3, Paleo = 4, Normal = 5 }
    public enum UserTypeDefinitions { BasicInfoSharedUser = 1, FullInfoSharedUser = 2, LimitedInfoSharedUser = 3 }
    public enum BadgeType { AktiviteRozeti = 1, DietRozeti = 2, KiloHedefiRozeti = 3, VKIRozeti = 4, YaşRozeti = 5, CinsiyetRozeti = 6 }

    public class UserDetail
    {
        public int UserID { get; set; }

        public virtual Age CustomerAge { get; set; }

        public virtual BMI BMI { get; set; }

        public ActivityType? Activity { get; set; }
        public GenderType? Gender { get; set; }
        public WeightTargetType? WeightTarget { get; set; }
        public DietType? Diet { get; set; }



        // ilk atama yapıldığında kullanıcı türü basic olacak ondan sonra rozet sayısına göre işlem usertype'a atama işlemleri gerçekleştirilecek.

        public virtual int UserTypes
        {
            get
            {
                if (BadgeQty>1 && BadgeQty<6)
                {
                    return (int)UserTypeDefinitions.LimitedInfoSharedUser;
                }
                if (BadgeQty == 6)
                {
                    return (int)UserTypeDefinitions.FullInfoSharedUser;
                }
                return (int)UserTypeDefinitions.BasicInfoSharedUser;
            }
            protected set
            {

            }
        }

        public User User { get; set; }
        public virtual int BadgeQty
        {
            get { return this.RozetSay(); }
            protected set { }
        }
    

        public int RozetSay()
        {
            List<int> BadgeQty = new List<int>();
            if (this.Activity != null) { BadgeQty.Add(((int)BadgeType.AktiviteRozeti)); }
            if (this.Diet != null) { BadgeQty.Add((((int)BadgeType.DietRozeti))); }
            if (this.WeightTarget != null) { BadgeQty.Add((((int)BadgeType.KiloHedefiRozeti))); }
            if (this.CustomerAge != null) { BadgeQty.Add((((int)BadgeType.YaşRozeti))); }
            if (this.Gender != null) { BadgeQty.Add((((int)BadgeType.CinsiyetRozeti))); }
            if (this.BMI != null) { BadgeQty.Add((((int)BadgeType.VKIRozeti))); }
            return BadgeQty.Count;
        }
        public UserDetail()
        {

        }
    }
}
