using System;
using System.Collections.Generic;
using System.Text;

namespace KaloriDeneme_1111.ModelCluster
{
    public enum BMIDescription {ÇokZayıf=1,Normal=2,Kilolu=3, Obez=4, MorbitObez=5}
    public class BMI
    {
        public int UserID { get; set; }
        public double CustomerWeight { get; set; }
        public double CustomerHeight { get; set; }

        //private double _bodyMassIndex;

        public virtual double BodyMassIndex
        {
            
            get
            {
               return (this.CustomerWeight / (this.CustomerHeight * this.CustomerHeight));
            }
            protected set { }
        }
 
        //private int _bmiInterval;

        public virtual int BMIInterval
        {

           get 
            {
                if (0<this.BodyMassIndex&& BodyMassIndex<=18.5)
                {
                    return (int)BMIDescription.ÇokZayıf;

                }
                if (18.50 < BodyMassIndex && BodyMassIndex <= 24.90)
                {
                    return (int)BMIDescription.Normal;

                }
                if (24.90 < BodyMassIndex && BodyMassIndex <= 29.90)
                {
                   return (int)BMIDescription.Kilolu;

                }
                if (29.90 < BodyMassIndex && BodyMassIndex <= 39.90)
                {
                    return (int)BMIDescription.Obez;

                }
                if (39.90 < BodyMassIndex)
                {
                    return (int)BMIDescription.MorbitObez;

                }
                else

                    return (int)BMIDescription.MorbitObez;
            }
            protected set { }
        }

        public UserDetail UserDetail { get; set; }
        public BMI()
        {

        }
    }
}