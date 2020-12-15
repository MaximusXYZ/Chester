using System;
using System.IO;
using System.IO.Pipes;
using System.Windows;

namespace Chester
{
    public static class MultiApi
    {
        public static void Execute(string Data, int TimeOut = 0)
        {
            if (Settings.Instance.ShadowCheats == true) MessageBox.Show("1");
            else if (Settings.Instance.EasyExploits == true) MessageBox.Show("2");
        }

        public static void Attach()
        {
            if (Settings.Instance.ShadowCheats == true) MessageBox.Show("1");
            else if (Settings.Instance.EasyExploits == true) MessageBox.Show("2");
        }
    }
}