using FitnessApp.Controllers;
using FitnessApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessApp.Forms;

namespace FitnessApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (String.IsNullOrEmpty(InitialStartController.checkServerPath()) || InitialStartController.checkServerPath() == "")
            {
                Application.Run(new InitialStart());
            }
            else
            {
                Application.Run(new Login());
            }
            
            
        }
    }
}
