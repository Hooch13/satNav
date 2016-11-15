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

namespace janzenzl_final {
    public partial class Address : UserControl {
        public Address() {
            InitializeComponent();
        }
        

        private void Page2_Load(object sender, EventArgs e) {
            // adding a city and address cannot be completed until a state is selected
            btnCity.Enabled = false;
            btnStreetAddress.Enabled = false;
        }

        private void btnChangeState_Click(object sender, EventArgs e) {
            // declare and instantiate a new stateprovince object 
            // declare a new frmMain object so new stateobject can be added to panel
            StateProvince myStateProvince = new StateProvince();
            frmMain myParent = (frmMain)this.Parent.Parent;
            myParent.pMain.Controls.Clear();
            myParent.pMain.Controls.Add(myStateProvince);
        }

        private void txtHoldState_TextChanged(object sender, EventArgs e) {

        }

        private void btnCity_Click(object sender, EventArgs e) {
            // create and instantiate new city object, add it to the cleared main forms panel.
            // add the selected state to the state label on the city user control.
            City myCity = new City();
            frmMain myParent = (frmMain)this.Parent.Parent;           
            myParent.pMain.Controls.Clear();
            myCity.lblState.Text = txtHoldState.Text.ToUpper();
            myParent.pMain.Controls.Add(myCity);
        }
    }
}
