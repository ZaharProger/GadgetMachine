using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetMachine
{
    //Ноутбук
    [Serializable]
    class Notebook : Gadget
    {
        private RGB keyboardColor;
        private byte coresAmount;
        private byte HDDCapacity;
        private double CPUFrequency;
        private byte RAMCapacity;
        public Notebook() : base()
        {
            type = "Ноутбук";
            keyboardColor = new RGB(dataGenerator.Next(0, 256), dataGenerator.Next(0, 256), dataGenerator.Next(0, 256));
            coresAmount = (byte)dataGenerator.Next(2, 9);
            HDDCapacity = (byte)dataGenerator.Next(1, 2049);
            CPUFrequency = Math.Round(dataGenerator.NextDouble() + dataGenerator.Next(1, 5), 1);
            RAMCapacity = (byte)dataGenerator.Next(1, 33);
        }

        public override string GetInfo()
        {
            string info = type;
            info += String.Format("\nРазрешение экрана: {0}x{1} px", display.width, display.height);
            info += String.Format("\nПодсветка клавиатуры: {0}", System.Drawing.Color.FromArgb((int)keyboardColor.GetRed(), (int)keyboardColor.GetGreen(), (int)keyboardColor.GetBlue()).Name);
            info += String.Format("\nЧисло ядер: {0}", coresAmount);
            info += String.Format("\nОбъем жесткого диска {0} GB", HDDCapacity);
            info += String.Format("\nЧастота процессора: {0} GHz", CPUFrequency);
            info += String.Format("\nОбъем оперативной памяти: {0} GB", RAMCapacity);

            return info;
        }
    }
}
