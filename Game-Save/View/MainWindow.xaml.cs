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
using Game_Save.ViewModel;

namespace Game_Save
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ItemsControl AllGamesView;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowVM();
            AllGamesView = ViewAllGames;
        }
    }
}