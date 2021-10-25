using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GadgetMachine
{
    public partial class MainWindow : Form
    {
        private List<Gadget> gadgets;
        public MainWindow()
        {
            InitializeComponent();
            gadgets = new List<Gadget>();
            notebookAmount.Text = Properties.Settings.Default.notebooks;
            tabletAmount.Text = Properties.Settings.Default.tablets;
            smartphoneAmount.Text = Properties.Settings.Default.smartphones;
        }

        //Закрытие окна клавишей Escape
        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        //Открытие окна "О программе"
        private void infoButton_Click(object sender, EventArgs e)
        {
            Hide();
            infoWindow window = new infoWindow();
            window.Show();
        }

        //Заполнение автомата
        private void fillButton_Click(object sender, EventArgs e)
        {
            clear();
            Random random = new Random();
            short amount = (short)random.Next(10, 101);
            short i = 0;
            while (i < amount)
            {
                byte gadgetType = (byte)random.Next(1, 4);
                if (gadgetType == 1)
                {
                    Notebook notebook = new Notebook();
                    string decoratorOrder = "";
                    byte k = 0;
                    while (k < 3)
                    {
                        byte decoratorType = (byte)random.Next(0, 4);
                        decoratorOrder += decoratorType;
                        if (!decoratorOrder.Contains(decoratorType.ToString()))
                        {
                            if (decoratorType == 1)
                            {
                                GadgetWithFingerPrint gadgetWithFingerPrint = new GadgetWithFingerPrint(notebook);
                                notebook = (Notebook)gadgetWithFingerPrint.GetGadget();
                            }
                            else if (decoratorType == 2)
                            {
                                GadgetWithPencil gadgetWithPencil = new GadgetWithPencil(notebook);
                                notebook = (Notebook)gadgetWithPencil.GetGadget();
                            }
                            else if (decoratorType == 3)
                            {
                                GadgetWithSSD gadgetWithSSD = new GadgetWithSSD(notebook);
                                notebook = (Notebook)gadgetWithSSD.GetGadget();
                            }
                        }                       
                        ++k;
                    }
                    gadgets.Add(notebook);
                    notebookAmount.Text = (Convert.ToInt16(notebookAmount.Text) + 1).ToString();
                }
                else if (gadgetType == 2)
                {
                    Tablet tablet = new Tablet();
                    string decoratorOrder = "";
                    byte k = 0;
                    while (k < 3)
                    {
                        byte decoratorType = (byte)random.Next(0, 4);
                        decoratorOrder += decoratorType;
                        if (!decoratorOrder.Contains(decoratorType.ToString()))
                        {
                            if (decoratorType == 1)
                            {
                                GadgetWithFingerPrint gadgetWithFingerPrint = new GadgetWithFingerPrint(tablet);
                                tablet = (Tablet)gadgetWithFingerPrint.GetGadget();
                            }
                            else if (decoratorType == 2)
                            {
                                GadgetWithPencil gadgetWithPencil = new GadgetWithPencil(tablet);
                                tablet = (Tablet)gadgetWithPencil.GetGadget();
                            }
                            else if (decoratorType == 3)
                            {
                                GadgetWithNFC gadgetWithNFC = new GadgetWithNFC(tablet);
                                tablet = (Tablet)gadgetWithNFC.GetGadget();
                            }
                        }
                        ++k;
                    }
                    gadgets.Add(tablet);
                    tabletAmount.Text = (Convert.ToInt16(tabletAmount.Text) + 1).ToString();
                }
                else if (gadgetType == 3)
                {
                    Smartphone smartphone = new Smartphone();
                    string decoratorOrder = "";
                    byte k = 0;
                    while (k < 3)
                    {
                        byte decoratorType = (byte)random.Next(0, 4);
                        decoratorOrder += decoratorType;
                        if (!decoratorOrder.Contains(decoratorType.ToString()))
                        {
                            if (decoratorType == 1)
                            {
                                GadgetWithFingerPrint gadgetWithFingerPrint = new GadgetWithFingerPrint(smartphone);
                                smartphone = (Smartphone)gadgetWithFingerPrint.GetGadget();
                            }
                            else if (decoratorType == 2)
                            {
                                GadgetWithPencil gadgetWithPencil = new GadgetWithPencil(smartphone);
                                smartphone = (Smartphone)gadgetWithPencil.GetGadget();
                            }
                            else if (decoratorType == 3)
                            {
                                GadgetWithNFC gadgetWithNFC = new GadgetWithNFC(smartphone);
                                smartphone = (Smartphone)gadgetWithNFC.GetGadget();
                            }
                        }
                        ++k;
                    }
                    gadgets.Add(smartphone);
                    smartphoneAmount.Text = (Convert.ToInt16(smartphoneAmount.Text) + 1).ToString();
                }
                ++i;
            }
            i = 0;
            gadgets.ForEach((gadget) => { queueField.Text += gadget.getType() + "\n"; });
        }

        //Нажатие кнопки очистить
        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        //Очистка списка
        private void clear()
        {
            notebookAmount.Text = "0";
            tabletAmount.Text = "0";
            smartphoneAmount.Text = "0";
            gadgets.Clear();
            queueField.Text = "";
            gadgetInfoField.Text = "";
            gadgetPicture.BackColor = Color.AliceBlue;
        }

        //Сохранение данных
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        //Выдача гаджета из автомата  
        private void showButton_Click(object sender, EventArgs e)
        {
            if (gadgets.Count != 0)
            { 
                Image image;
                Random random = new Random();
                int pos = random.Next(0, gadgets.Count);

                if (gadgets[pos] is Notebook)
                {
                    image = Image.FromFile("\\notebook.jpg");
                    notebookAmount.Text = (Convert.ToInt16(notebookAmount.Text) - 1).ToString();
                }
                else if (gadgets[pos] is Smartphone)
                {
                    image = Image.FromFile("\\smartphone.jpg");
                    smartphoneAmount.Text = (Convert.ToInt16(smartphoneAmount.Text) - 1).ToString();
                }
                else
                {
                    image = Image.FromFile("\\tablet.jpg");
                    tabletAmount.Text = (Convert.ToInt16(tabletAmount.Text) - 1).ToString();
                }

                gadgetPicture.Image = image;
                gadgetInfoField.Text = gadgets[pos].GetInfo();
                gadgets.RemoveAt(pos);
                queueField.Text = "";
                gadgets.ForEach((gadget) => { queueField.Text += gadget.getType() + "\n"; });
                image.Dispose();
            }
            else
            {
                MessageBox.Show("Автомат не заполнен!");
            }
        }
    }
}
