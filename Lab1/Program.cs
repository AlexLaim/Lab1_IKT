using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
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
            // ДВАЖДЫ ОТКРЫВАЕТ 1 ЧАСТЬ ПРОГРАММЫ
           //Application.Run(new Init());         

            Init f = new Init();
            
            
            //ОТКРЫВАЕТ ОРГАНАЙЗЕР
            if (f.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormOrganaizer());
            }
        }
    }
}
