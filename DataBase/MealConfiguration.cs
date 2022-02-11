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
  public class MealConfiguration:EntityTypeConfiguration<Meal>
    {
        public MealConfiguration()
        {
            this.ToTable("Öğün_Tablosu")
                .HasKey(m => m.MealID);

            this.Property(m=>m.MealID).HasColumnName("Öğün_ID")
                .HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(m => m.MealType).HasColumnName("Öğün_Tipi")
                .HasColumnType("int").IsRequired();

            this.Property(m => m.RecordDate).HasColumnName("Öğün_Kayıt_Tarihi")
                .HasColumnType("DateTime2").IsRequired();

            this.Property(m => m.MealTotalCalorie).HasColumnName("Öğün_Toplam_Kalorisi")
                .HasColumnType("float").IsRequired();

            //MEAL &&NUTRIENT MAPPING

            this.HasMany<Nutrient>(m => m.Nutrients)
                         .WithMany(n => n.Meals)
                       .Map(nm =>
                       {
                           nm.MapLeftKey("Besin_ID")
                               .MapRightKey("Öğün_ID")
                               .ToTable("ÖğünveBesinTablosu");
                       });

            //MEAL &&CUSTOM NUTRIENT MAPPING
            this.HasMany(m => m.CustomNutrients)
                .WithRequired(cn => cn.Meal);

            //MEAL&&USER MAPPING
            this.HasRequired<User>(m => m.User)
                .WithMany(u => u.Meals);

        }
    }
}
