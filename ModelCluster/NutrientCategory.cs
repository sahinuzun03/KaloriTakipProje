using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace KaloriDeneme_1111.ModelCluster
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
