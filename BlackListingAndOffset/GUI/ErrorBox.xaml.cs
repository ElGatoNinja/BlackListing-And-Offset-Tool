﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ZOT.GUI
{
    /// <summary>
    /// Lógica de interacción para ErrorPop.xaml
    /// </summary>
    public partial class ErrorBox : Window
    {
        public ErrorBox(string error)
        {
            InitializeComponent();
            ErrorTextBox.Text = error;
        }
    } 
}
