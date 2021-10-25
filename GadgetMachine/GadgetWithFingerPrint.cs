using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetMachine
{
    //Декоратор Сканер отпечатка пальца
    [Serializable]
    class GadgetWithFingerPrint : Decorator
    {
        public GadgetWithFingerPrint(Gadget gadget) : base(gadget)
        { }
        public override string GetInfo()
        {
            return gadget.GetInfo() + "\nНаличие сканнера отпечатка пальца: Да";
        }
    }
}
