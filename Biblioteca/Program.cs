using System;
using System.Windows.Forms;

namespace Biblioteca
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PessoaForm()); // ← Substitua por seu formulário principal, se tiver outro nome
        }
    }
}