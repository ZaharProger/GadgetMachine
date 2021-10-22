using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetMachine
{
    //Декоратор
    abstract class Decorator<T> : Gadget
    {
        protected T gadget;
        
        protected Decorator(T gadget)
        {
            this.gadget = gadget;
        }
    }
}
