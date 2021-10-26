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
        private Machine machine;
        public MainWindow()
        {
            InitializeComponent();
            machine = new Machine();
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
            machine.Fill();
            string[] result = machine.VisualizeElements();
            queueField.Text = result[0];
            notebookAmount.Text = result[1];
            tabletAmount.Text = result[2];
            smartphoneAmount.Text = result[3];
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
            machine.Clear();
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
            Gadget gadget = machine.GetElement();
            if (gadget != null)
            {
                gadgetInfoField.Text = gadget.GetInfo();
                try
                {
                    Notebook notebook = (Notebook)gadget;
                    
                }
                catch (InvalidCastException)
                { }
                /*if (gadget is Notebook)
                    gadgetPicture.Image = Image.FromFile(Environment.CurrentDirectory + "\\notebook.jpg");
                else if (gadget is Tablet)
                    gadgetPicture.Image = Image.FromFile(Environment.CurrentDirectory + "\\tablet.jpg");
                else 
                    gadgetPicture.Image = Image.FromFile(Environment.CurrentDirectory + "\\smartphone.jpg");*/
                string[] result = machine.VisualizeElements();
                queueField.Text = result[0];
                notebookAmount.Text = result[1];
                tabletAmount.Text = result[2];
                smartphoneAmount.Text = result[3];
            }
            else
            {
                MessageBox.Show("Автомат не заполнен!");
            }
        }
    }
}
