﻿using System;
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
            
        }
    }
}
