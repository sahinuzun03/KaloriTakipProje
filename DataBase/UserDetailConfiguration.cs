using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using KaloriDeneme_1111.ModelCluster;

namespace KaloriDeneme_1111.DataBase
{
   public class UserDetailConfiguration:EntityTypeConfiguration<UserDetail>
    {
        public UserDetailConfiguration()
        {
            this.ToTable("Kullanıcı_Detayları")
              .HasKey<int>(ud => ud.UserID);

            this.Property(ud => ud.UserID).HasColumnName("Kullanıcı_ID")
                .HasColumnType("int").IsRequired();

            this.Property(ud => ud.Activity).HasColumnName("Aktiflik_Durumu")
                .HasColumnType("int").IsOptional();

            this.Property(ud => ud.Gender).HasColumnName("Cinsiyet")
                .HasColumnType("int").IsOptional();

            this.Property(ud => ud.WeightTarget).HasColumnName("Kilo_Hedefi")
                .HasColumnType("int").IsOptional();

            this.Property(ud => ud.Diet).HasColumnName("Beslenme_Şekli")
                .HasColumnType("int").IsOptional();

            this.Property(ud => ud.UserTypes).HasColumnName("Kullanıcı_Tipleri")
                .HasColumnType("int").IsOptional();

            this.Property(ud => ud.BadgeQty).HasColumnName("Rozet_Adedi")
                .HasColumnType("int").IsOptional();


            //USER-DETAIL && USER
            this.HasRequired<User>(ud => ud.User)
                .WithRequiredDependent(u => u.UserDetail);

            //USER-DETAIL && AGE MAPPING
            this.HasOptional<Age>(userDetail => userDetail.CustomerAge)
                .WithRequired(age => age.UserDetail);

            //USER-DETAIL && BMI MAPPING
            this.HasOptional<BMI>(userDetail => userDetail.BMI)
                .WithRequired(bmi => bmi.UserDetail);

           

        }
    }
}
