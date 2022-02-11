using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaloriDeneme_1111.ModelCluster;
using System.Data.Entity;
using KaloriDeneme_1111.DataBase;


namespace KaloriDeneme_1111.DataBase
{
   public class KaloriDbContext:DbContext
    {
        public KaloriDbContext()
        {
            Database.Connection.ConnectionString = @"Server=DESKTOP-7628CQK;Database=FatFightersProje;Uid=sa; Pwd=11411141;";
        }

        public DbSet<User>Users{ get; set; }
        public DbSet<UserDetail>UserDetails { get; set; }
        public DbSet<Age>Ages { get; set; }
        public DbSet<BMI>BMIs { get; set; }
        public DbSet<Meal>Meals { get; set; }
        public DbSet<Nutrient>Nutrients { get; set; }
        public DbSet<CustomNutrientData>CustomNutrients { get; set; }
        public DbSet<NutrientCategory>NutrientCategories { get; set; }
        public DbSet<Scale>Scales { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new AgeConfiguration());
            modelBuilder.Configurations.Add(new BMIConfiguration());
            modelBuilder.Configurations.Add(new MealConfiguration());
            modelBuilder.Configurations.Add(new NutrientCategoryConfiguration());
            modelBuilder.Configurations.Add(new NutrientConfiguration());
            modelBuilder.Configurations.Add(new ScaleConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new UserDetailConfiguration());
            modelBuilder.Configurations.Add(new CustomNutrientConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

    }
}
