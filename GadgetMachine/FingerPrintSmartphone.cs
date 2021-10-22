using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetMachine
{
    //Декоратор смартфона в смартфон с отпечатком пальца
    class FingerPrintSmartphone : Decorator<Smartphone>
    {
        public FingerPrintSmartphone(Smartphone smartphone) : base (smartphone)
        {}

        public override string GetInfo()
        {
            return gadget.GetInfo() + "\nНаличие сканнера отпечатка пальца: Да";
        }
    }
}
