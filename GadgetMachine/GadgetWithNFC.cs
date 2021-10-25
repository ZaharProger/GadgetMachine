using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetMachine
{
    //Декоратор NFC
    [Serializable]
    class GadgetWithNFC : Decorator
    {
        public GadgetWithNFC(Gadget gadget) : base(gadget)
        { }

        public override string GetInfo()
        {
            return gadget.GetInfo() + "\nНаличие бесконтактной оплаты NFC: Да";
        }
    }
}
