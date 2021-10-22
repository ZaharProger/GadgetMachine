using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetMachine
{
    //Декоратор ноутбука в офисный
    class OfficeNotebook : Decorator<Notebook>
    {
        private string GPU;
        public OfficeNotebook(Notebook notebook) : base(notebook)
        {
            GPU = "GT 730M";
        }

        public override string GetInfo()
        {
            gadget.SetType("Офисный ноутбук");
            gadget.SetCoresAmount((byte)(gadget.GetCoresAmount() / 2));
            gadget.SetHDDCapacity((byte)(gadget.GetHDDCapacity() / 2));
            gadget.SetCPUFrequency((byte)(gadget.GetCPUFrequency() / 2));
            gadget.SetRAMCapacity((byte)(gadget.GetRAMCapacity() / 2));

            return gadget.GetInfo() + "\nВидеокарта: " + GPU;
        }
    }
}
