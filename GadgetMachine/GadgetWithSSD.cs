using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetMachine
{
    //Декоратор SSD
    [Serializable]
    class GadgetWithSSD : Decorator
    {
        public GadgetWithSSD(Gadget gadget) : base(gadget) 
        { }

        public override string GetInfo()
        {
            return gadget.GetInfo() + "\nНаличие SSD: Да";
        }
    }
}
