using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace Bogatinovski_Player
{
    static class Program
    {
        public static string path = Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location), "runing.run");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>  
        [STAThread]
        static void Main(string[] argv)
        {
            Class1.input = argv;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2(argv.ToList<String>()));
        }
    }
}
