using System;
using System.Windows.Forms;

//AUGUSTO DOS SANTOS CORRÊA
namespace Biblioteca
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BibliotecaForm()); // ← Substitua por seu formulário principal, se tiver outro nome
        }
    }
}