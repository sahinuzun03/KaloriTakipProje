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
   public class NutrientCategoryConfiguration:EntityTypeConfiguration<NutrientCategory>
    {
        public NutrientCategoryConfiguration()
        {
            this.ToTable("Besin_Kategorileri").HasKey(nc => nc.NutrientCategoryID);

            this.Property(nc => nc.NutrientCategoryID).HasColumnName("Besin_ID")
                .HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(nc => nc.NutrientCategoryName).HasColumnName("Besin_Kategori_Adı")
                .HasColumnType("nvarchar").HasMaxLength(50).IsRequired();


            //NUTRIENT CATEGORY && NUTRIENT MAPPING
            this.HasMany<Nutrient>(nc => nc.Nutrients)
                .WithRequired(n => n.NutrientCategory);
        }

     
    }

}
