using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetMachine
{
    //Декоратор Стилус
    class GadgetWithPencil : Decorator
    {
        public GadgetWithPencil(Gadget gadget) : base(gadget)
        { }

        public override string GetInfo()
        {
            return gadget.GetInfo() + "\nНаличие стилуса: Да";
        }
    }
}
