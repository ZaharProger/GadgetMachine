using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetMachine
{
    class NFCSmartphone
    {
        //Декоратор смартфона в смартфон с NFC
        class FingerPrintSmartphone : Decorator<Smartphone>
        {
            public FingerPrintSmartphone(Smartphone smartphone) : base(smartphone)
            { }

            public override string GetInfo()
            {
                return gadget.GetInfo() + "\nНаличие бесконтактной оплаты NFC: Да";
            }
        }
    }
}
