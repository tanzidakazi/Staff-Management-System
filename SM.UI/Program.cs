using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SM.LogicLayer;
using SM.Entity;
using System.Data.Linq;
using System.Data.Linq.Mapping;
namespace SM.UI
{
    [Table(Name = "Infoes")]

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
            Application.Run(new Form1());

           



        }
    }
}
