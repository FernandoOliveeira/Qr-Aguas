using QrAguas.View_Layer;
using QrAguas.ViewLayer;
using System;
using System.Windows.Forms;

namespace QrAguas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SellProduct());
        }
    }
}
