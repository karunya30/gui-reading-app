using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfFunReader
{
    /// <summary>
    /// Interaction logic for Subscribe.xaml
    /// </summary>
    public partial class Subscribe : Page
    {
        MainWindow _window;

        public Subscribe(MainWindow window)
        {
            InitializeComponent();
            _window = window;
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            _window.Content = new Home(_window);
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            using (Process exe_process = new Process())
            {

                string model = Application.Current.Properties["AskKITA_model"].ToString();
                string language = Application.Current.Properties["AskKITA_langauge"].ToString();


                Console.WriteLine(language);
                Console.WriteLine(model);
                string startup_directory = Directory.GetCurrentDirectory();
                string path_to_exe = System.IO.Path.GetFullPath(System.IO.Path.Combine(startup_directory, @"funReaders/funReaders.exe"));


                Console.WriteLine(path_to_exe);

                string directory_of_model = @"funReaders/models/" + model;
                Console.WriteLine(directory_of_model);

                string location_of_models = System.IO.Path.GetFullPath(System.IO.Path.Combine(startup_directory, directory_of_model));

                Console.WriteLine(location_of_models);

                string function = Application.Current.Properties["Function"].ToString();

                Console.WriteLine("THIS ISSSSSS");
                Console.WriteLine(function);
                //configuring the process start info class
                //string location_of_vosk = @"C:\Users\karus\Documents\Final Year\FYP\Sam - Askkita and sphinx integration\Ask-kita-poc\models\vosk";//System.IO.Path.GetFullPath(System.IO.Path.Combine(startup_directory, @"funReaders/models/vosk")); //
                exe_process.StartInfo.FileName = path_to_exe;//@"C:\Users\karus\Documents\Final Year\FYP\Sam - Askkita and sphinx integration\Ask-kita-poc\dist\funReaders.exe";
                exe_process.StartInfo.Arguments = $" \"{language}\" \"{model}\" \"subtitle\" \"{location_of_models}\"";
                exe_process.StartInfo.UseShellExecute = true;
                //exe_process.StartInfo.RedirectStandardOutput = true;

                // Set gui to a "waiting state" whilst starting up python process

                exe_process.Start();
                exe_process.WaitForExit();
            }

        }
    }
}
