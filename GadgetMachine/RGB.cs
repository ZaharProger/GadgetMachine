using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetMachine
{
    public class RGB
    {
        private double red;
        private double green;
        private double blue;

        public RGB()
        {
            red = 0;
            green = 0;
            blue = 0;
        }

        public RGB(double red, double green, double blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public void SetRed(double value)
        {
            red = value;
        }

        public void SetGreen(double value)
        {
            green = value;
        }

        public void SetBlue(double value)
        {
            blue = value;
        }

        public double GetRed()
        {
            return red;
        }

        public double GetGreen()
        {
            return green;
        }

        public double GetBlue()
        {
            return blue;
        }

        public void AddRed(double value)
        {
            red += value;
        }

        public void AddGreen(double value)
        {
            green += value;
        }

        public void AddBlue(double value)
        {
            blue += value;
        }
    }
}
