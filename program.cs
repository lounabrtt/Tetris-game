using System;
using System.Windows.Forms;

namespace Tetris
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); // Point d'entrée pour l'interface
        }
    }
}
