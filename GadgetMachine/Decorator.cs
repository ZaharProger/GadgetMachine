using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetMachine
{
    //Декоратор
    abstract class Decorator : Gadget
    {
        private Gadget gadget;
        
        protected Decorator(Gadget gadget)
        {
            this.gadget = gadget;
        }
    }
}
