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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace стили
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();          
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Button_Vxod_Click_1(object sender, RoutedEventArgs e)
        {
            Laborant laborant = new Laborant();
            laborant.Show();
            this.Hide();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        { 
        }
    }
}
