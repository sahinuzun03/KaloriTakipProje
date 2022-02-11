using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public enum ScaleTypes{ Kepçe=1,Tabak=2,Porsiyon=3,Gram=4,Kase=5,Dilim=6,TatlıKaşığı=7,ÇorbaKaşığı=8}
   public class Scale
    {
        public int ScaleID { get; set; }
        public string ScaleType { get; set; }
        public double UnitCalorie { get; set; }
        public ICollection<Nutrient> Nutrients { get; set; }

        public Scale()
        {
            Nutrients = new HashSet<Nutrient>();

        }

    }
}
