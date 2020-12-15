using System.Windows;
using System.Windows.Media;

public static class Data
{
    public class Border
    {
        public SolidColorBrush Background;
        public SolidColorBrush BorderBrush;
        public Thickness BorderThickness;
        public double Opacity;
    }

    public class Button
    {
        public SolidColorBrush Background;
        public SolidColorBrush BorderBrush;
        public Thickness BorderThickness;
        public double Opacity;
    }

    public class TextEditor
    {
        public SolidColorBrush Background;
        public SolidColorBrush BorderBrush;
        public Thickness BorderThickness;
        public double Opacity;
        public FontFamily FontFamily;
        public SolidColorBrush Foreground;
    }

    public class ListView 
    {
        public SolidColorBrush Background;
        public SolidColorBrush BorderBrush;
        public Thickness BorderThickness;
        public double Opacity;
    }

    public class MainWindow
    {
        public string Title;
        public Border Background;
        public Border TopBorder;
        public Button ExitBtn;
        public Button MinimizeBtn;
        public Button MaximizerBtn;
        public Button ExecuteBtn;
        public Button ClearBtn;
        public Button OpenBtn;
        public Button SaveBtn;
        public Button AttachBtn;
        public Button SettingsBtn;
        public TextEditor LuaEditor;
        public ListView ScriptList;
    }

    public class Main
    {
        public MainWindow MainWindow;
    }

    public static Main Default()
    {
        var Main = new Main
        {
            MainWindow = new MainWindow
            {
                Title = "Chester - MainWindow",
                Background = new Border
                {
                    Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#141414")),
                    BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#0000ffff")),
                    BorderThickness = new Thickness(0),
                    Opacity = 1
                },
                TopBorder = new Border
                {
                    Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#141414")),
                    BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#0000ffff")),
                    BorderThickness = new Thickness(0),
                    Opacity = 1
                },
                ExitBtn = new Button
                {
                    Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF605C")),
                    BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#0000ffff")),
                    BorderThickness = new Thickness(0),
                    Opacity = 1
                },
                MinimizeBtn = new Button
                {
                    Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFBD44")),
                    BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#0000ffff")),
                    BorderThickness = new Thickness(0),
                    Opacity = 1
                },
                MaximizerBtn = new Button
                {
                    Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#161616")),
                    BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#181818")),
                    BorderThickness = new Thickness(0),
                    Opacity = 1
                },
                ExecuteBtn = new Button
                {
                    Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#161616")),
                    BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#181818")),
                    BorderThickness = new Thickness(0),
                    Opacity = 1
                },
                ClearBtn = new Button
                {
                    Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#161616")),
                    BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#181818")),
                    BorderThickness = new Thickness(0),
                    Opacity = 1
                },
                OpenBtn = new Button
                {
                    Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#161616")),
                    BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#181818")),
                    BorderThickness = new Thickness(0),
                    Opacity = 1
                },
                SaveBtn = new Button
                {
                    Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#161616")),
                    BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#181818")),
                    BorderThickness = new Thickness(0),
                    Opacity = 1
                },
                AttachBtn = new Button
                {
                    Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#161616")),
                    BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#181818")),
                    BorderThickness = new Thickness(0),
                    Opacity = 1
                },
                SettingsBtn = new Button
                {
                    Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#161616")),
                    BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#181818")),
                    BorderThickness = new Thickness(0),
                    Opacity = 1
                },
                LuaEditor = new TextEditor
                {
                    Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#161616")),
                    BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#181818")),
                    BorderThickness = new Thickness(0),
                    Opacity = 1,
                    FontFamily = new FontFamily("Consolas"),
                    Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFFFFF")),
                },
                ScriptList = new ListView
                {
                    Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#161616")),
                    BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#181818")),
                    BorderThickness = new Thickness(0),
                    Opacity = 1
                },
            }
        };

        return Main;
    } 
}