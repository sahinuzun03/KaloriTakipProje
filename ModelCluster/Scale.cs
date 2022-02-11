using System;
using System.Collections.Generic;
using System.Text;

namespace KaloriDeneme_1111.ModelCluster
{
    public enum ScaleTypes{ Kepçe=1,Tabak=2,Porsiyon=3,Gram=4,Kase=5,Dilim=6,TatlıKaşığı=7,ÇorbaKaşığı=8, SuBardağı=9, MLitre=10, Adet=11, Paket=12, Avuç=13, ÇayBardağı=14}
   public class Scale
    {
        public int ScaleID { get; set; }
        public ScaleTypes ScaleType { get; set; }
        public double UnitCalorie { get; set; }

        public virtual Nutrient Nutrient { get; set; }

        public Scale()
        {

        }

    }
}
