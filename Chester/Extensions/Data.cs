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

    public class MainWindow
    {
        public string Title;
        public Border Background;
    }

    public class Main
    {
        public MainWindow MainWindow;
    }

    public static void ApplyBorder(System.Windows.Controls.Border Border, Border _Border)
    {
        Border.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom(_Border.Background.ToString()));
        Border.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom(_Border.BorderBrush.ToString()));
        Border.BorderThickness = (_Border.BorderThickness);
        Border.Opacity = (_Border.Opacity);
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
                    BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffffff00")),
                    BorderThickness = new Thickness(0),
                    Opacity = 1
                }
            }
        };

        return Main;
    } 
}