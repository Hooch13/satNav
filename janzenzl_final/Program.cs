/* ****************************************************************************************************************
 * Name: Zach Janzen
 * Assignment #: Final
 * Due Date: 12/8/2015
 * Course/Term/Section: IT3045C
 * Short Description: This form application closely resembles the functionality of  
 * the satallite navigation system in Professor Bill Nicholson's Toyota Sienna.
 * ****************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace janzenzl_final {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
            
        }
    }
}
