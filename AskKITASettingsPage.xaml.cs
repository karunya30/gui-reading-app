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
    /// Interaction logic for AskKITASettingsPage.xaml
    /// </summary>
    public partial class AskKITASettingsPage : Page
    {
        MainWindow _window;
        string model = Application.Current.Properties["AskKITA_model"].ToString();
        string language = Application.Current.Properties["AskKITA_langauge"].ToString(); 
        public AskKITASettingsPage(MainWindow window)
        {
            _window = window;
            InitializeComponent();
            //LanguageDropDown.Items.Add("English");
            Console.WriteLine(language);


            

            if (model == "vosk")
            {
                modelDropDown.SelectedIndex = 0;

                if (language == "en-US")
                {
                    LanguageDropDown.SelectedValue = "English";
                }
                if (language == "es-SP")
                {
                    LanguageDropDown.SelectedValue = "Spanish";
                }
                if (language == "de-GE")
                {
                    LanguageDropDown.SelectedValue = "German";
                }
            }
            if (model == "sphinx")
            {
                modelDropDown.SelectedIndex = 1;
                if (language == "en-US")
                {
                    LanguageDropDown.SelectedValue = "English";
                }
                if (language == "ta-TA")
                {
                    LanguageDropDown.SelectedValue = "Tamil";
                }
            }
            //change_LanguageDropDown_items();
        }

        private void LanguageDropDown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            if (LanguageDropDown.SelectedValue == null)
            {
                return;
            }
            if (LanguageDropDown.SelectedValue.ToString() == "English")
            {
                Application.Current.Properties["AskKITA_langauge"] = "en-US";
            }
            if (LanguageDropDown.SelectedValue.ToString() == "Spanish")
            {
                Application.Current.Properties["AskKITA_langauge"] = "es-SP";
            }
            if (LanguageDropDown.SelectedValue.ToString() == "German")
            {
                Application.Current.Properties["AskKITA_langauge"] = "de-GE";
            }
            if (LanguageDropDown.SelectedValue.ToString() == "Tamil")
            {
                Application.Current.Properties["AskKITA_langauge"] = "ta-TA";
            }
        }

        private void change_LanguageDropDown_items()
        {
            if (model == "vosk")
            {
                LanguageDropDown.Items.Clear();
                LanguageDropDown.Items.Add("English");
                LanguageDropDown.Items.Add("German");
                LanguageDropDown.Items.Add("Spanish");
            }
            if (model == "sphinx")
            {
                LanguageDropDown.Items.Clear();
                LanguageDropDown.Items.Add("English");
                LanguageDropDown.Items.Add("Tamil");
            }

        }
        private void modelDropDown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            
            
            if (modelDropDown.SelectedIndex == 0)
            {
                Application.Current.Properties["AskKITA_model"] = "vosk";
                model = "vosk";
            }
            if (modelDropDown.SelectedIndex == 1)
            {
                model = "sphinx";
                Application.Current.Properties["AskKITA_model"] = "sphinx";
                
                Console.WriteLine("I just reset the model");
            }
            change_LanguageDropDown_items();
        }

       

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            _window.Content = new SpeechServicesHomePage(_window);
        }

        

        
    }
}
