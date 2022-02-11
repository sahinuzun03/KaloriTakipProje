using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public enum MealType { Sabah=1,Öğlen=2,Akşam=3,Aperatifler=4}
    
   public class Meal
    {
        public int MealID { get; set; }
        public MealType MealType { get; set; }
        public DateTime RecordDate { get; set; }

        public virtual ICollection<Nutrient> Nutrients { get; set; }


        public virtual ICollection<User> Users { get; set; }
        public Meal()
        {
            Nutrients = new List<Nutrient>();
            Users = new List<User>();
        }

    }
}
