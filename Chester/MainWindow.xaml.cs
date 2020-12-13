using System.Windows;
using System.IO;
using Newtonsoft.Json;
using System;

namespace Chester
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (!File.Exists("user-data.json"))
            {
                File.WriteAllText("user-data.json", JsonConvert.SerializeObject(Data.Default(), Formatting.Indented));
            }
            else
            {
                try
                {
                    Manager.GetMain = JsonConvert.DeserializeObject<Data.Main>(File.ReadAllText("user-data.json"));
                    var Main = Manager.GetMain.MainWindow;

                    Data.ApplyBorder(Background, Main.Background);
                }
                catch (Exception ex)
                {
                    var Result = MessageBox.Show(
                        "Everest has encountered an error while loading Themes. Would you like to copy the exception?",
                        "Everest - Exception",
                        MessageBoxButton.YesNo,
                        MessageBoxImage.Error);

                    if (Result != MessageBoxResult.Yes) return;
                    else { Clipboard.SetText(ex.ToString()); Environment.Exit(0); }
                }
            }

            if (!Settings.Instance.TopMost) this.Topmost = false;
        }
    }
}
