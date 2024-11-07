using System;
using System.Windows.Forms;
using WinFormsApp2;
using WinFormsApp1;

namespace WinFormsApp2
{
    static class Program
    {
        [STAThread] // N�cessaire pour les applications Windows Forms
        static void Main()
        {
            // Initialisation de l'application

            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Lancement du formulaire principal
        }
    }
}
