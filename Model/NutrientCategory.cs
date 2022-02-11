using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class NutrientCategory
    {

        public int NutrientCategoryID { get; set; }
        public string NutrientCategoryName { get; set; }
        public ICollection<Nutrient> Nutrients { get; set; }
        public NutrientCategory()
        {
            Nutrients = new List<Nutrient>();
        }

    }
}
