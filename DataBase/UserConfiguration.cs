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
   public class UserConfiguration:EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
             this.ToTable("Kullanıcılar")
              .HasKey<int>(u => u.UserID);

            this.Property(u => u.UserID).HasColumnName("Kullanıcı_ID")
                .HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(u => u.MailAddress).HasColumnName("Kullanıcı_MailAdresi").HasColumnType("nvarchar").HasMaxLength(30).IsRequired();

            this.Property(u => u.Password).HasColumnName("Kullanıcı_Şifresi").HasColumnType("nvarchar").HasMaxLength(15).IsRequired();

            this.Property(u => u.NickName).HasColumnName("Kullanıcı_SistemAdı").HasColumnType("nvarchar").HasMaxLength(25).IsRequired();
            this.HasIndex(u => u.MailAddress).IsUnique();
            this.HasIndex(u => u.NickName).IsUnique();

            //USER &&MEAL MAPPING
            this.HasMany<Meal>(u => u.Meals)
                .WithRequired(m => m.User);

            //USER && USER DETAIL MAPPING
            this.HasRequired<UserDetail>(u => u.UserDetail)
                .WithRequiredPrincipal(ud => ud.User);
        }



    }
}
