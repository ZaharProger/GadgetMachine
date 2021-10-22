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
        private byte HDDCapacity;
        private double CPUFrequency;
        private byte RAMCapacity;
        public Notebook(short width, short height, byte red, byte green, byte blue, byte coresAmount, byte HDDCapacity, double CPUFrequency, byte RAMCapacity) : base(width, height, "Ноутбук")
        {
            keyboardColor.red = red;
            keyboardColor.green = green;
            keyboardColor.blue = blue;
            this.coresAmount = coresAmount;
            this.HDDCapacity = HDDCapacity;
            this.CPUFrequency = CPUFrequency;
            this.RAMCapacity = RAMCapacity;
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

        public void SetCoresAmount(byte coresAmount)
        {
            this.coresAmount = coresAmount;
        }

        public void SetHDDCapacity(byte HDDCapacity)
        {
            this.HDDCapacity = HDDCapacity;
        }

        public void SetCPUFrequency(double CPUFrequency)
        {
            this.CPUFrequency = CPUFrequency;
        }

        public void SetRAMCapacity(byte RAMCapacity)
        {
            this.RAMCapacity = RAMCapacity;
        }

        public byte GetCoresAmount()
        {
            return coresAmount;
        }

        public byte GetHDDCapacity()
        {
            return HDDCapacity;
        }

        public double GetCPUFrequency()
        {
            return CPUFrequency;
        }

        public byte GetRAMCapacity()
        {
            return RAMCapacity;
        }

        public override string GetInfo()
        {
            string info = type;
            info += String.Format("\nРазрешение экрана: {0}x{1} px", display.width, display.height);
            info += "\nПодсветка клавиатуры:";
            info += String.Format("\nЧисло ядер: {0}", coresAmount);
            info += String.Format("\nОбъем жесткого диска {0} GB", HDDCapacity);
            info += String.Format("\nЧастота процессора: {0} MHz", CPUFrequency);
            info += String.Format("\nОбъем оперативной памяти: {0} GB", RAMCapacity);

            return info;
        }
    }
}
