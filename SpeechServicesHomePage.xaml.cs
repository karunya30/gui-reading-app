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
    /// Interaction logic for SpeechServicesHomePage.xaml
    /// </summary>
    public partial class SpeechServicesHomePage : Page
    {
        MainWindow _window;
        public SpeechServicesHomePage(MainWindow window)
        {
            _window = window;
            InitializeComponent();
        }

        private void ReadThisForMeCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (ReadThisForMeCheckBox.IsChecked == true)
            {
                Application.Current.Properties["UseReadThisForMe"] = true;
            }
            else
            {
                Application.Current.Properties["UseReadThisForMe"] = false;
            }
            

        }

        private void AskKITA_Click(object sender, RoutedEventArgs e)
        {
            _window.Content = new AskKITASettingsPage(_window);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            _window.Content = new Home(_window);
        }
    }
}
