using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetMachine
{
    //Смартфон
    class Smartphone : Gadget
    {
        private byte SIMslotsAmount;
        private byte cameraMpx;
        private short batteryPower;

        public Smartphone(short width, short height, byte SIMslotsAmount, byte cameraMpx, short batteryPower) : base(width, height)
        {
            this.SIMslotsAmount = SIMslotsAmount;
            this.cameraMpx = cameraMpx;
            this.batteryPower = batteryPower;
        }

        public override string GetInfo()
        {
            string info = "Смартфон:";
            info += String.Format("\nРазрешение экрана: {0}x{1} px", display.width, display.height);
            info += String.Format("\nЧисло слотов под SIM: {0}", SIMslotsAmount);
            info += String.Format("\nРазрешение камеры: {0} Mpx", cameraMpx);
            info += String.Format("\nМощность батареи: {0} mAh", batteryPower);

            return info;
        }
    }
}
