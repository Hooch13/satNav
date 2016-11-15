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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace janzenzl_final {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            // instantiate a new page1 object and add it to the panel on form load
            StartPage myStartPage = new StartPage();
            pMain.Controls.Add(myStartPage);
        }

        private void pMain_Paint(object sender, PaintEventArgs e) {

        }
    }
}
