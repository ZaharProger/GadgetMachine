using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetMachine
{
    //Планшет
    [Serializable]
    class Tablet : Gadget
    {
        private bool hasCam;
        private short dpi;

        public Tablet() : base()
        {
            type = "Планшет";
            hasCam = dataGenerator.Next(0, 9) % 2 == 0;
            dpi = (short)dataGenerator.Next(80, 501);
        }

        public override string GetInfo()
        {
            string info = type;
            info += String.Format("\nРазрешение экрана: {0}x{1} px", display.width, display.height);
            if (hasCam)
                info += "\nНаличие камеры: Да";
            else
                info += "\nНаличие камеры: Нет";
            info += String.Format("\nЧисло точек на дюйм: {0} dpi", dpi);

            return info;
        }
    }
}
