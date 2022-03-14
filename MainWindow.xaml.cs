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



namespace WpfFunReader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            this.Background = Brushes.AliceBlue;
            
            InitializeComponent();
            Page home = new Home(this);
            this.Content = home;

            //below are the default settings for the ASK-Kita functionality
            Application.Current.Properties["AskKITA_model"] = "vosk";
            Application.Current.Properties["AskKITA_langauge"] = "en-US";

            //
            Application.Current.Properties["UseReadThisForMe"] = false;





        }

        
    }
}