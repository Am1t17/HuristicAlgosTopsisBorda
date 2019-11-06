using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HuristicAlgosTopsis
{
    public class Program
    {

        public Claculations A_Claculations; 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Program p = new Program();
            p.LoadProg();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(p));
        }

        public void LoadProg()
        {
            A_Claculations = new Claculations(this);
            A_Claculations.loadData("C:\\Users\\adibr\\source\\repos\\HuristicAlgosTopsis\\HuristicAlgosTopsis\\LaptopDB.csv");
        }

    }
}
