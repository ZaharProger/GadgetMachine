using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetMachine
{
    //Класс гаджетов
    [Serializable]
    abstract class Gadget
    {
        protected static Random dataGenerator = new Random();
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
            display.width = (short)dataGenerator.Next(1000, 2181);
            display.height = (short)dataGenerator.Next(1000, 2181);
            type = "Гаджет";
        }

        protected Gadget(Gadget gadget)
        {
            display.width = gadget.display.width;
            display.height = gadget.display.height;
            type = gadget.type;
        }

        public void SetType(string type)
        {
            this.type = type;
        }

        public string getType()
        {
            return type;
        }

        public abstract string GetInfo();
    }
}
