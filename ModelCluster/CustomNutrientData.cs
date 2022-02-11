using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriDeneme_1111.ModelCluster
{
   public class CustomNutrientData
    {
        public int CustomNutrientDataID { get; set; }
        public string CustomNutrientName { get; set; }
        public Meal Meal { get; set; }
        public int MealID { get; set; }
        public double TotalCalorie { get; set; }

}
}
