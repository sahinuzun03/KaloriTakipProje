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
   public class BMIConfiguration:EntityTypeConfiguration<BMI>
    {
        public BMIConfiguration()
        {
            this.ToTable("Vücut_Kitle_Indeksi")
                .HasKey<int>(b => b.UserID);

            this.Property(ud => ud.UserID).HasColumnName("Kullanıcı_ID")
                .HasColumnType("int").IsRequired();

            this.Property(b => b.CustomerHeight).HasColumnName("Boy")
                .HasColumnType("float").IsRequired();

            this.Property(b => b.BodyMassIndex).HasColumnName("VKI_Değeri")
                .HasColumnType("float").IsRequired();

            this.Property(b => b.BMIInterval).HasColumnName("VKI_Aralığı")
                .HasColumnType("int").IsRequired();


            //BMI && User Detail Configuration
            this.HasRequired(bmi => bmi.UserDetail)
                .WithOptional(userDetail => userDetail.BMI);
        }
    }
}
