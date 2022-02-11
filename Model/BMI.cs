using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public enum BMIDescription {ÇokZayıf=1,Normal=2,Kilolu=3, Obez=4, MorbitObez=5}
    public class BMI
    {
        public int BMIID { get; set; }
        public double CustomerWeight { get; set; }
        public double CustomerHeight { get; set; }

        private double _bodyMassIndex;

        public double BodyMassIndex
        {
            get { return _bodyMassIndex; }
            private set
            {
                value = (CustomerWeight / (this.CustomerHeight * this.CustomerHeight) / Math.Pow(100, 2));
                _bodyMassIndex = value;

            }
        }
 
        private int _bmiInterval;

        public int BMIInterval
        {
            get { return _bmiInterval; }
            set 
            {
                if (0<value&&value<=18.5)
                {
                    _bmiInterval = (int)BMIDescription.ÇokZayıf;
                }
                if (18.50 < value && value <= 24.90)
                {
                    _bmiInterval = (int)BMIDescription.Normal;
                }
                if (24.90 < value && value <= 29.90)
                {
                    _bmiInterval = (int)BMIDescription.Kilolu;
                }
                if (29.90 < value && value <= 39.90)
                {
                    _bmiInterval = (int)BMIDescription.Obez;
                }
                if (39.90 < value)
                {
                    _bmiInterval = (int)BMIDescription.MorbitObez;
                }
            }
        }

        public ICollection<UserDetail> UserDetails { get; set; }
        public BMI()
        {
            UserDetails = new List<UserDetail>();
        }
    }
}