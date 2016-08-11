using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace DocTrace
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
            Application.Run(new FormMain());

            //System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            //Application.Run(new PrintDialogForm(doc));
        }
    }
}