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
    public class NutrientConfiguration : EntityTypeConfiguration<Nutrient>
    {
        public NutrientConfiguration()
        {
            this.ToTable("Besin_Tablosu")
                .HasKey(n => n.NutrientID);

            this.Property(n => n.NutrientID).HasColumnName("Besin_ID")
                .HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(n => n.NutrientName).HasColumnName("Besin_Adı")
                .HasColumnType("nvarchar").HasMaxLength(100).IsRequired();

            this.Property(n => n.Quantity).HasColumnName("Miktar")
                .HasColumnType("float").IsRequired();


            //NUTRIENT && MEAL MAPPING
            this.HasMany<Meal>(n => n.Meals)
                            .WithMany(m => m.Nutrients)
                             .Map(nm =>
                             {
                                 nm.MapLeftKey("Öğün_ID")
                                     .MapRightKey("Besin_ID")
                                     .ToTable("ÖğünveBesinTablosu");
                             });

            //NUTRIENT && NUTRIENT CATEGORY MAPPING
            this.HasRequired<NutrientCategory>(n => n.NutrientCategory)
                .WithMany(nc => nc.Nutrients);

            //NUTRIENT && SCALE MAPPING
            //USER &&MEAL MAPPING
            this.HasMany<Scale>(n => n.Scales)
                .WithRequired(s => s.Nutrient);
        }
    }
}
