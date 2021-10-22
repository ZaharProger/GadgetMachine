using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetMachine
{
    //Ноутбук
    class Notebook : Gadget
    {
        //Структура цвета
        struct RGB
        {
            public byte red;
            public byte green;
            public byte blue;
        }
        private RGB keyboardColor;
        private byte coresAmount;
        private short HDDCapacity;

        public Notebook(short width, short height, byte red, byte green, byte blue, byte coresAmount, short HDDCapacity) : base(width, height)
        {
            keyboardColor.red = red;
            keyboardColor.green = green;
            keyboardColor.blue = blue;
            this.coresAmount = coresAmount;
            this.HDDCapacity = HDDCapacity;
        }

        public byte GetRed()
        {
            return keyboardColor.red;
        }

        public byte GetGreen()
        {
            return keyboardColor.green;
        }

        public byte GetBlue()
        {
            return keyboardColor.blue;
        }

        public override string GetInfo()
        {
            string info = "Ноутбук:";
            info += String.Format("Разрешение экрана: {0}x{1}", display.width, display.height);
            info += "\nПодсветка клавиатуры:";
            info += String.Format("\nЧисло ядер: {0}", coresAmount);
            info += String.Format("\nОбъем жесткого диска {0}", HDDCapacity);

            return info;
        }
    }
}
