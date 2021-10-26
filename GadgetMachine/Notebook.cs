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
        public Notebook()
        {
            display.width = (short)dataGenerator.Next(1000, 2181);
            display.height = (short)dataGenerator.Next(1000, 2181);
            type = "Ноутбук";
            keyboardColor.red = (byte)dataGenerator.Next(0, 256);
            keyboardColor.green = (byte)dataGenerator.Next(0, 256);
            keyboardColor.blue = (byte)dataGenerator.Next(0, 256);
            coresAmount = (byte)dataGenerator.Next(2, 9);
            HDDCapacity = (byte)dataGenerator.Next(1, 2049);
            CPUFrequency = dataGenerator.NextDouble() + dataGenerator.Next(1, 5);
            RAMCapacity = (byte)dataGenerator.Next(1, 129);
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
            info += String.Format("\nЧастота процессора: {0} GHz", CPUFrequency);
            info += String.Format("\nОбъем оперативной памяти: {0} GB", RAMCapacity);

            return info;
        }
    }
}
