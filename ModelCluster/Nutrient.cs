using System;
using System.Collections.Generic;
using System.Text;

namespace KaloriDeneme_1111.ModelCluster
{
    public class Nutrient
    {
        public int NutrientID { get; set; }
        public string NutrientName { get; set; } //En geniş kapsamlı yazıcaz--> Hatay kırma zeytin

        public double Quantity { get; set; }

        public NutrientCategory NutrientCategory { get; set; }
        public int NutrientCategoryID { get; set; }

        public ICollection<Scale> Scales { get; set; }
        public ICollection<Meal> Meals { get; set; }

        public Nutrient()
        {
            Scales = new HashSet<Scale>();
            Meals = new List<Meal>();

        }

        public Scale SelectedScale { get; }

        private double _totalCatories;

        public double TotalCalories
        {
            get { return _totalCatories; }
            private set
            {
                value = 0;
                _totalCatories = value;


            }
        }

    }
}

