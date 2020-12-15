using System.Windows;
using System.IO;
using Newtonsoft.Json;
using System;
using Microsoft.Win32;
using System.Xml;
using ICSharpCode.AvalonEdit.Highlighting;
using System.Windows.Input;

namespace Chester
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LuaEditor.Options.EnableHyperlinks = false;
            LuaEditor.Options.EnableEmailHyperlinks = false;
            LuaEditor.Options.AllowScrollBelowDocument = false;

            using (var streamReader = new StreamReader("lua.xshd"))
            {
                using (var reader = new XmlTextReader(streamReader))
                {
                    LuaEditor.SyntaxHighlighting = ICSharpCode.AvalonEdit.Highlighting.Xshd.HighlightingLoader.Load(reader, HighlightingManager.Instance);
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (!File.Exists("user-data.json"))
            {
                File.WriteAllText("user-data.json", JsonConvert.SerializeObject(Data.Default(), Newtonsoft.Json.Formatting.Indented));
            }
            else
            {
                try
                {
                    Manager.GetMain = JsonConvert.DeserializeObject<Data.Main>(File.ReadAllText("user-data.json"));
                    var Main = Manager.GetMain.MainWindow;
                }
                catch (Exception ex)
                {
                    var Result = MessageBox.Show(
                        "Chester has encountered an error while loading Themes. Would you like to copy the exception?",
                        "Chester - Exception",
                        MessageBoxButton.YesNo,
                        MessageBoxImage.Error);

                    if (Result != MessageBoxResult.Yes) Environment.Exit(0);
                    else { Clipboard.SetText(ex.ToString()); Environment.Exit(0); }
                }
            }

            if (!Settings.Instance.TopMost) this.Topmost = false;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Top_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == System.Windows.Input.MouseButton.Left && e.ButtonState == MouseButtonState.Pressed)
            {
                this.ResizeMode = ResizeMode.NoResize;
                this.DragMove();
                this.ResizeMode = ResizeMode.CanResize;
            }
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void MaximizeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
        }

        private void ExecuteBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            LuaEditor.Text = "";
        }

        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            var OpenFile = new OpenFileDialog
            {
                Title = "Chester - Open File",
                Filter = "Script Files (*.lua, *.txt)|*.lua;*.txt",
            };

            if (OpenFile.ShowDialog() == true)
            {
                try
                {
                    LuaEditor.Text = File.ReadAllText(OpenFile.FileName);
                }
                catch (Exception ex)
                {
                    var Result = MessageBox.Show(
                        "Chester has encountered an error. Would you like to copy the exception?",
                        "Chester - Exception",
                        MessageBoxButton.YesNo,
                         MessageBoxImage.Error);

                    if (Result != MessageBoxResult.Yes) Environment.Exit(0);
                    else { Clipboard.SetText(ex.ToString()); Environment.Exit(0); }
                }
            }
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs re)
        {
            var SaveFile = new SaveFileDialog
            {
                Title = "Chester - Save File",
                Filter = "Script Files (*.lua, *.txt)|*.lua;*.txt",
                FileName = "",
            };

            if (SaveFile.ShowDialog() == true)
            {
                try
                {
                    File.WriteAllText(SaveFile.FileName, LuaEditor.Text);
                }
                catch (Exception ex)
                {
                    var Result = MessageBox.Show(
                        "Chester has encountered an error. Would you like to copy the exception?",
                        "Chester - Exception",
                        MessageBoxButton.YesNo,
                         MessageBoxImage.Error);

                    if (Result != MessageBoxResult.Yes) Environment.Exit(0);
                    else { Clipboard.SetText(ex.ToString()); Environment.Exit(0); }
                }
            }
        }

        private void AttachBtn_Click(object sender, RoutedEventArgs e)
        {
            MultiApi.Attach();
        }

        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
