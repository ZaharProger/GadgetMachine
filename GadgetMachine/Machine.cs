using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetMachine
{
    //Класс автомата
    class Machine
    {
        private List<Gadget> gadgets;

        public Machine()
        {
            gadgets = new List<Gadget>();
        }

        public void Fill()
        {
            Random random = new Random();
            short amount = (short)random.Next(10, 101);
            short i = 0;
            while (i < amount)
            {
                byte gadgetType = (byte)random.Next(1, 4);
                if (gadgetType == 1)
                {
                    Notebook notebook = new Notebook();
                    byte decoratorsAmount = (byte)random.Next(0, 4);
                    if (decoratorsAmount == 0)
                        gadgets.Add(notebook);
                    else if (decoratorsAmount == 1)
                    {
                        byte decoratorType = (byte)random.Next(1, 4);
                        if (decoratorType == 1)
                            gadgets.Add(new GadgetWithSSD(notebook));
                        else if (decoratorType == 2)
                            gadgets.Add(new GadgetWithFingerPrint(notebook));
                        else
                            gadgets.Add(new GadgetWithPencil(notebook));
                    }
                    else if (decoratorsAmount == 2)
                    {
                        byte decoratorType1 = 0;
                        byte decoratorType2 = 0;
                        while (decoratorType1 == decoratorType2)
                        {
                            decoratorType1 = (byte)random.Next(1, 4);
                            decoratorType2 = (byte)random.Next(1, 4);
                        }
                        if ((decoratorType1 == 1 && decoratorType2 == 2) || (decoratorType1 == 2 && decoratorType2 == 1))
                            gadgets.Add(new GadgetWithFingerPrint(new GadgetWithSSD(notebook)));
                        else if ((decoratorType1 == 1 && decoratorType2 == 3 || decoratorType1 == 3 && decoratorType2 == 1))
                            gadgets.Add(new GadgetWithPencil(new GadgetWithSSD(notebook)));
                        else
                            gadgets.Add(new GadgetWithFingerPrint(new GadgetWithPencil(notebook)));
                    }
                    else
                    {
                        gadgets.Add(new GadgetWithFingerPrint(new GadgetWithPencil(new GadgetWithSSD(notebook))));
                    }
                }
                else if (gadgetType == 2)
                {
                    Tablet tablet = new Tablet();
                    byte decoratorsAmount = (byte)random.Next(0, 4);
                    if (decoratorsAmount == 0)
                        gadgets.Add(tablet);
                    else if (decoratorsAmount == 1)
                    {
                        byte decoratorType = (byte)random.Next(1, 4);
                        if (decoratorType == 1)
                            gadgets.Add(new GadgetWithNFC(tablet));
                        else if (decoratorType == 2)
                            gadgets.Add(new GadgetWithFingerPrint(tablet));
                        else
                            gadgets.Add(new GadgetWithPencil(tablet));
                    }
                    else if (decoratorsAmount == 2)
                    {
                        byte decoratorType1 = 0;
                        byte decoratorType2 = 0;
                        while (decoratorType1 == decoratorType2)
                        {
                            decoratorType1 = (byte)random.Next(1, 4);
                            decoratorType2 = (byte)random.Next(1, 4);
                        }
                        if ((decoratorType1 == 1 && decoratorType2 == 2) || (decoratorType1 == 2 && decoratorType2 == 1))
                            gadgets.Add(new GadgetWithFingerPrint(new GadgetWithNFC(tablet)));
                        else if ((decoratorType1 == 1 && decoratorType2 == 3 || decoratorType1 == 3 && decoratorType2 == 1))
                            gadgets.Add(new GadgetWithPencil(new GadgetWithNFC(tablet)));
                        else
                            gadgets.Add(new GadgetWithFingerPrint(new GadgetWithPencil(tablet)));
                    }
                    else
                    {
                        gadgets.Add(new GadgetWithFingerPrint(new GadgetWithPencil(new GadgetWithNFC(tablet))));
                    }
                }
                else
                {
                    Smartphone smartphone = new Smartphone();
                    byte decoratorsAmount = (byte)random.Next(0, 4);
                    if (decoratorsAmount == 0)
                        gadgets.Add(smartphone);
                    else if (decoratorsAmount == 1)
                    {
                        byte decoratorType = (byte)random.Next(1, 4);
                        if (decoratorType == 1)
                            gadgets.Add(new GadgetWithNFC(smartphone));
                        else if (decoratorType == 2)
                            gadgets.Add(new GadgetWithFingerPrint(smartphone));
                        else
                            gadgets.Add(new GadgetWithPencil(smartphone));
                    }
                    else if (decoratorsAmount == 2)
                    {
                        byte decoratorType1 = 0;
                        byte decoratorType2 = 0;
                        while (decoratorType1 == decoratorType2)
                        {
                            decoratorType1 = (byte)random.Next(1, 4);
                            decoratorType2 = (byte)random.Next(1, 4);
                        }
                        if ((decoratorType1 == 1 && decoratorType2 == 2) || (decoratorType1 == 2 && decoratorType2 == 1))
                            gadgets.Add(new GadgetWithFingerPrint(new GadgetWithNFC(smartphone)));
                        else if ((decoratorType1 == 1 && decoratorType2 == 3 || decoratorType1 == 3 && decoratorType2 == 1))
                            gadgets.Add(new GadgetWithPencil(new GadgetWithNFC(smartphone)));
                        else
                            gadgets.Add(new GadgetWithFingerPrint(new GadgetWithPencil(smartphone)));
                    }
                    else
                    {
                        gadgets.Add(new GadgetWithFingerPrint(new GadgetWithPencil(new GadgetWithNFC(smartphone))));
                    }
                }
                ++i;
            }
        }

        public Gadget GetElement()
        {
            Gadget gadget = (gadgets.Count != 0) ? gadgets[gadgets.Count - 1] : null;
            if (gadget != null)
                gadgets.RemoveAt(gadgets.Count - 1);
            return gadget;
        }

        public string[] VisualizeElements()
        {
            string[] result = new string[] { "", "0", "0", "0" };
            foreach (Gadget gadget in gadgets)
            {
                result[0] += gadget.getType() + "\n";
                if (gadget.getType().ToLower().Contains("ноутбук"))
                    result[1] = (Convert.ToInt16(result[1]) + 1).ToString();
                else if (gadget.getType().ToLower().Contains("планшет"))
                    result[2] = (Convert.ToInt16(result[2]) + 1).ToString();
                else
                    result[3] = (Convert.ToInt16(result[3]) + 1).ToString();
            }

            return result;
        }

        public void Clear()
        {
            gadgets.Clear();
        }
    }
}
