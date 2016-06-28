using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptIt
{
    static class Program
    {
        private static bool _running = false;
        public static bool Running { get { return _running; } }
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            _running = true;
            if (args.Length > 0 && args[0] == "/updated")
                Application.Run(new GotUpdatedForm(args));
            else
                Application.Run(new MainForm());
        }
    }
}
