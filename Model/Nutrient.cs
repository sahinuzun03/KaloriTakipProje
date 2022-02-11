using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Nutrient
    {
        public int NutrientID { get; set; }
        public string NutrientName { get; set; } //En geniş kapsamlı yazıcaz--> Hatay kırma zeytin
        public NutrientCategory NutrientCategory { get; set; }
        public int NutrientCategoryID { get; set; }

        public ICollection<Scale> Scales { get; set; }
        public double Quantity { get; set; }

        public virtual ICollection<Meal> Meals { get; set; }

        public Nutrient()
        {
            Meals = new List<Meal>();
            Scales = new HashSet<Scale>();
        }

        //public Scale SelectedScale { get; set; }

        //private double _totalCatories;

        //public double TotalCalories
        //{
        //    get { return _totalCatories; }
        //    private set
        //    {
        //        value = this.SelectedScale.UnitCalorie*this.Quantity;
        //        _totalCatories = value;


        //    }
        //}

    }
}

