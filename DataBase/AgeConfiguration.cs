using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using KaloriDeneme_1111.ModelCluster;
using System.ComponentModel.DataAnnotations.Schema;



namespace KaloriDeneme_1111.DataBase
{
   public class AgeConfiguration:EntityTypeConfiguration<Age>
    {
        public AgeConfiguration()
        {
            this.ToTable("Yaş")
                .HasKey<int>(a => a.UserID);


            this.Property(ud => ud.UserID).HasColumnName("Kullanıcı_ID")
                .HasColumnType("int").IsRequired();

            this.Property(a => a.CustomerAge).HasColumnName("Kullanıcı_Yaşı")
                .HasColumnType("int").IsRequired();

            //AGE-USER DETAIL MAPPING
            this.HasRequired(age => age.UserDetail)
                .WithOptional(userDetail => userDetail.CustomerAge);

        }
    }
}
