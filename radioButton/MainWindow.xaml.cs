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

namespace radioButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnChecar_Click(object sender, RoutedEventArgs e)
        {
            if (rdbMasculino.IsChecked == true)
            {
                MessageBox.Show("Selecionado sexo masculino", "RadioButton",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Selecionado sexo feminino", "RadioButton",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
