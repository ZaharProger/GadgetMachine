using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetMachine
{
    //Декоратор ноутбука в офисный
    class OfficeNotebook : Decorator
    {
        private string GPU;
        public OfficeNotebook(Notebook notebook) : base(notebook)
        {
            notebook.SetType("Офисный ноутбук");
            notebook.SetCoresAmount((byte)(notebook.GetCoresAmount() / 2));
            notebook.SetHDDCapacity((byte)(notebook.GetHDDCapacity() / 2));
            notebook.SetCPUFrequency((byte)(notebook.GetCPUFrequency() / 2));
            notebook.SetRAMCapacity((byte)(notebook.GetRAMCapacity() / 2));
            GPU = "GT 730M";
        }

        public override string GetInfo()
        {          
            return gadget.GetInfo() + "\nВидеокарта: " + GPU;
        }
    }
}
