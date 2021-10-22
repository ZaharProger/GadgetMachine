using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetMachine
{
    //Класс гаджетов
    abstract class Gadget
    {
        //Структура дисплея: ширина и высота
        protected struct Display
        {
            public short width;
            public short height;
        }
        protected Display display;

        protected Gadget(short width, short height)
        {
            display.width = width;
            display.height = height;
        }

        public abstract string GetInfo();
    }
}
