using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnaliseAlgoritmoOrdenacao
{
    static class Program
    {
        static string log = "";
        public static void setLog(string l)
        {
            log = l;
        }
        public static string getLog()
        {
            return log;
        }

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        
    }
}
