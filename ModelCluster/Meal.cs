using System;
using System.Collections.Generic;
using System.Text;

namespace KaloriDeneme_1111.ModelCluster
{
    public enum MealType { Sabah=1,Öğlen=2,Akşam=3,Aperatifler=4}
    
   public class Meal
    {
        public int MealID { get; set; }
        public MealType MealType { get; set; }
        public DateTime RecordDate { get; set; }

        public virtual ICollection<Nutrient> Nutrients { get; set; }
        public virtual ICollection<CustomNutrientData> CustomNutrients { get; set; }
        public virtual User User { get; set; }
        public virtual int UserID { get; set; }
        public double MealTotalCalorie { get; set; }



        public Meal()
        {
            Nutrients = new List<Nutrient>();
            CustomNutrients = new List<CustomNutrientData>();

        }

    }
}
