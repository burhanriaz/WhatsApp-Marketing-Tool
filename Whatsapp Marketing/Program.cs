using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Creator
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
        Application.Run(new Whatsapp_Marketing.loading());
         //   Application.Run(new Whatsapp_Marketing.Login());
             // Application.Run(new Whatsapp_Marketing.NumberGenrator());

        }
    }
}
