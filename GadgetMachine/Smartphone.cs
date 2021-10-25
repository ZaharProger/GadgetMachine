using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetMachine
{
    //Смартфон
    [Serializable]
    class Smartphone : Gadget
    {
        private byte SIMslotsAmount;
        private byte cameraMpx;
        private short batteryPower;

        public Smartphone()
        {
            display.width = (short)dataGenerator.Next(1000, 2181);
            display.height = (short)dataGenerator.Next(1000, 2181);
            type = "Смартфон";
            SIMslotsAmount = (byte)dataGenerator.Next(1, 4);
            cameraMpx = (byte)dataGenerator.Next(1, 21);
            batteryPower = (short)dataGenerator.Next(1000, 5001);
        }

        public override string GetInfo()
        {
            string info = type;
            info += String.Format("\nРазрешение экрана: {0}x{1} px", display.width, display.height);
            info += String.Format("\nЧисло слотов под SIM: {0}", SIMslotsAmount);
            info += String.Format("\nРазрешение камеры: {0} Mpx", cameraMpx);
            info += String.Format("\nМощность батареи: {0} mAh", batteryPower);

            return info;
        }
    }
}
