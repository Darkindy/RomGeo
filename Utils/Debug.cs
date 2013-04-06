using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageBoxButton = System.Windows.Forms.MessageBoxButtons;
using MessageBoxImage = System.Windows.Forms.MessageBoxIcon;

namespace RomGeo.Utils
{
    public static class Debug
    {
        public static void Log(string message)
        {
            Console.WriteLine(message);
        }

        public static void ExitWithErrorMessage(string message = "Application was forced to quit.",int code = 0)
        {
            MessageBox.Show(message + "\nERROR CODE: " + code, "FATAL ERROR",
            MessageBoxButton.OK, MessageBoxImage.Error);
            Application.Exit(code);
        }
    }
}
