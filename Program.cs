using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Button_Jmyak;


namespace OurFirstVisualApplication
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Button_Jmyak.Button_Jmyak());            
        }
    }
}
