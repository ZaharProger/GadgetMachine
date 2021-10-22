using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetMachine
{
    //Планшет
    class Tablet : Gadget
    {
        private bool hasCam;
        private short dpi;

        public Tablet(short width, short height, bool hasCam, short dpi) : base(width, height)
        {
            this.hasCam = hasCam;
            this.dpi = dpi;
        }

        public override string GetInfo()
        {
            string info = "Планшет:";
            info += String.Format("Разрешение экрана: {0}x{1} px", display.width, display.height);
            if (hasCam)
                info += "\nНаличие камеры: Да";
            else
                info += "\nНаличие камеры: Нет";
            info += String.Format("\nЧисло точек на дюйм: {0} dpi", dpi);

            return info;
        }
    }
}
