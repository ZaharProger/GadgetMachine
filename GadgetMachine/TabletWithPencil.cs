using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetMachine
{
    //Декоратор планшета со стилусом
    class TabletWithPencil : Decorator
    {
        public TabletWithPencil(Tablet tablet) : base(tablet)
        { }

        public override string GetInfo()
        {
            return gadget.GetInfo() + "\nНаличие стилуса: Да";
        }
    }
}
