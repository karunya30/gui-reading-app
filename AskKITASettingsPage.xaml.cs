using System;
using System.Collections.Generic;
using System.IO;
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
using Path = System.IO.Path;


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
                LanguageDropDown.SelectedValue = language;

                //if (language == "English(US)")
                //{
                    //LanguageDropDown.SelectedValue = "English(US)";
                //}
                

            }
            if (model == "sphinx")
            {
                modelDropDown.SelectedIndex = 1;
                LanguageDropDown.SelectedValue = language;
                    
            }
            //change_LanguageDropDown_items();
        }

        private void LanguageDropDown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            if (LanguageDropDown.SelectedValue == null)
            {
                return;
            }
            Application.Current.Properties["AskKITA_langauge"] = LanguageDropDown.SelectedValue.ToString();

            //if (LanguageDropDown.SelectedValue.ToString() == "English(US)")
            //{
              //  Application.Current.Properties["AskKITA_langauge"] = "English(US)";
            //}
            
            
        }

        private void change_LanguageDropDown_items()
        {
            string sub_directory = @"funReaders/models/" + model + "/";


            string startup_directory = Directory.GetCurrentDirectory();

            LanguageDropDown.Items.Clear();
            string path_to_models = System.IO.Path.GetFullPath(System.IO.Path.Combine(startup_directory, sub_directory));
            Console.WriteLine(path_to_models);
            string[] filePaths = Directory.GetDirectories(path_to_models, "*", SearchOption.TopDirectoryOnly);
            Console.WriteLine(filePaths);
            
            Console.WriteLine(sub_directory);

            //if (model == "vosk")
            //{

                





              //  LanguageDropDown.Items.Add("English(US)");
                //LanguageDropDown.Items.Add("German");
                //LanguageDropDown.Items.Add("Spanish");
                //LanguageDropDown.Items.Add("French");
                //LanguageDropDown.Items.Add("Arabic");
                //LanguageDropDown.Items.Add("Chinese");
                //LanguageDropDown.Items.Add("Hindi");



            //}
            //if (model == "sphinx")
            //{
              //  LanguageDropDown.Items.Clear();

               
                //LanguageDropDown.Items.Add("English(US)");
                //LanguageDropDown.Items.Add("Tamil");
            //}

            int index = 0;
            int english_index = -1;
            foreach (string filePath in filePaths)
            {


                Console.WriteLine("Hmm");
                Console.WriteLine(filePath);

                string[] found  = filePath.Split('\\');
                int length = found.Length;
                string lang_found = found[length - 1];
                if (filePath == "English(US)")
                {
                    english_index = index;
                }


                LanguageDropDown.Items.Add(lang_found);





                index++;

            }
            LanguageDropDown.SelectedIndex = english_index;


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
