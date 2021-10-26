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
        protected static Random dataGenerator;
        //Структура дисплея: ширина и высота
        protected struct Display
        {
            public short width;
            public short height;
        }
        protected Display display;
        protected string type;
        protected Gadget()
        {
            dataGenerator = new Random();
            display.width = (short)dataGenerator.Next(1000, 2181);
            display.height = (short)dataGenerator.Next(1000, 2181);
            type = "Гаджет";
        }
        protected Gadget(short width, short height, string type)
        {
            display.width = width;
            display.height = height;
            this.type = type;
        }

        public void SetType(string type)
        {
            this.type = type;
        }
        public abstract string GetInfo();
    }
}
