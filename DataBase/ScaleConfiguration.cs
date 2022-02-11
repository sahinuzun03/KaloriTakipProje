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
   public class ScaleConfiguration:EntityTypeConfiguration<Scale>
    {
        public ScaleConfiguration()
        {
            this.ToTable("Ölçekler").HasKey(s => s.ScaleID);

            this.Property(s => s.ScaleID).HasColumnName("Ölçek_ID")
                .HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(s => s.ScaleType).HasColumnName("Ölçek_Tipi")
                .HasColumnType("int").IsRequired();

            this.Property(s => s.UnitCalorie).HasColumnName("Birim_Kalori")
                .HasColumnType("float").IsRequired();

            //SCALE && NUTRIENT MAPPING
            this.HasRequired<Nutrient>(s => s.Nutrient)
                .WithMany(n => n.Scales);

        }
    }
}
