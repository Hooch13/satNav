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
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.Text.RegularExpressions;

namespace janzenzl_final {
    public partial class StartPage : UserControl {
        public StartPage() {
            InitializeComponent();
           
        }



        private void btnAddress_Click(object sender, EventArgs e) {
            // create and instantiate a new Address object to be added to the main form.
            Address myAddress = new Address();
            frmMain myParent = (frmMain)this.Parent.Parent;
            myParent.pMain.Controls.Clear();
            myParent.pMain.Controls.Add(myAddress);
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void StartPage_Load(object sender, EventArgs e) {

        }
    }

}



