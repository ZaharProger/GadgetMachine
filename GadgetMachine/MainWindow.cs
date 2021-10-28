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
            gadgetPicture.Hide();
            keyboardColor.Hide();
            colorLabel.Hide();
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
            colorLabel.Hide();
            gadgetPicture.Hide();
            keyboardColor.Hide();
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
                if (gadget.getType().ToLower() == "ноутбук")
                {
                    gadgetInfoField.Text = gadget.GetInfo();
                    string[] splittedInfo = gadgetInfoField.Text.Split(new char[] { ' ', '\n'}, StringSplitOptions.RemoveEmptyEntries);
                    //Извлекаем цвет для установки в PictureBox
                    var color = from data in splittedInfo
                                let hexCode = new char[] {'a', 'b', 'c', 'd', 'e', 'f',
                                                          '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }
                                where data.IndexOfAny(hexCode) != -1 && data.Length == 8
                                select data;
                    
                    //Удаляем информацию о цвете в текстовом поле                  
                    gadgetInfoField.Text = gadgetInfoField.Text.Replace(color.ElementAt(0), "Да");

                    //Визуализируем цвет, переводим из 16 ричной системы в RGB
                    string[] convertedColor = new string[] { color.ElementAt(0).Substring(2, 2),
                                                             color.ElementAt(0).Substring(4, 2),
                                                             color.ElementAt(0).Substring(6)};
                    RGB rgb = new HexToRGBConverter(convertedColor).Convert();
                    keyboardColor.Show();
                    colorLabel.Show();
                    keyboardColor.BackColor = Color.FromArgb((int)rgb.GetRed(), (int)rgb.GetGreen(), (int)rgb.GetBlue());
                }
                else
                {
                    colorLabel.Hide();
                    keyboardColor.Hide();
                    gadgetInfoField.Text = gadget.GetInfo();
                }

                gadgetPicture.Show();
                if (gadget.getType().ToLower() == "ноутбук")
                    gadgetPicture.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + String.Format("\\Pics\\Notebooks\\notebook{0}.jpg", new Random().Next(0, 10)));
                else if (gadget.getType().ToLower() == "планшет")
                    gadgetPicture.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + String.Format("\\Pics\\Tablets\\tablet{0}.jpg", new Random().Next(0, 10)));
                else 
                    gadgetPicture.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + String.Format("\\Pics\\Smartphones\\smartphone{0}.jpg", new Random().Next(0, 10)));
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

        //Копирование значения цвета при нажатии на него
        private void keyboardColor_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(keyboardColor.BackColor.Name.Substring(2));
            MessageBox.Show(String.Format("Значение цвета скопировано в буфер обмена!\nЗначение: {0}", Clipboard.GetText()));
        }
    }
}
