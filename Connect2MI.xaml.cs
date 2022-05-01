using System;
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
    /// Interaction logic for Connect2MI.xaml
    /// </summary>
    public partial class Connect2MI : Page
    {
        MainWindow _window;
        public Connect2MI(MainWindow window)
        {
            _window = window;
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            _window.Content = new Home(_window);
        }
    }
}
