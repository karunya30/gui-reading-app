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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {

        MainWindow _window;
        public Home(MainWindow window)
        {
            
            _window = window;
            InitializeComponent();
        }

        private void btn_reading_Click(object sender, RoutedEventArgs e)
        {
            _window.Content = new ReadingMode(_window);
        }

        private void btn_subscribe_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Properties["Function"] = "subscribe";
            _window.Content = new Subscribe(_window);
        }

        private void btn_transcribe_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Properties["Function"] = "transcribe";
            _window.Content = new TranscriptionMode(_window);  
        }

        private void Speech_Settings_Click(object sender, RoutedEventArgs e)
        {
            _window.Content = new SpeechServicesHomePage(_window);
        }
    }
}
