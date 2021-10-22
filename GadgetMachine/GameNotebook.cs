using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetMachine
{
    //Декоратор ноутбука в игровой
    class GameNotebook : Decorator
    {
        private string GPU;
        public GameNotebook(Notebook notebook) : base(notebook)
        {
            notebook.SetType("Игровой ноутбук");
            notebook.SetCoresAmount((byte)(notebook.GetCoresAmount() * 2));
            notebook.SetHDDCapacity((byte)(notebook.GetHDDCapacity() * 2));
            notebook.SetCPUFrequency((byte)(notebook.GetCPUFrequency() * 2));
            notebook.SetRAMCapacity((byte)(notebook.GetRAMCapacity() * 2));
            GPU = "RTX 3080";
        }

        public override string GetInfo()
        {
            return gadget.GetInfo() + "\nВидеокарта: " + GPU;
        }
    }
}
