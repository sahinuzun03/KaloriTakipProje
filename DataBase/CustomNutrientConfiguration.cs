using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using KaloriDeneme_1111.ModelCluster;
using System.Data.Entity.Infrastructure.Annotations;

namespace KaloriDeneme_1111.DataBase
{
   public class CustomNutrientConfiguration:EntityTypeConfiguration<CustomNutrientData>
    {
        public CustomNutrientConfiguration()
        {
            this.ToTable("Kullanıcı_Özel_Besin_Tablosu")
                .HasKey(cn => cn.CustomNutrientDataID);

            this.Property(cn => cn.CustomNutrientDataID).HasColumnName("Özel_Besin_ID")
                .HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(cn => cn.TotalCalorie).HasColumnName("Girilen_Kalori")
                .HasColumnType("float").IsRequired();

            //CUSTOM NUTRIENT && MEAL
            this.HasRequired(cn => cn.Meal)
                .WithMany(m => m.CustomNutrients);



        }
    }
}
