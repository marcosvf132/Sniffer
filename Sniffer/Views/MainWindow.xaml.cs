﻿using System.Windows;

namespace Sniffer.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ViewModels.MainViewModel._window = this;
        }
    }
}
