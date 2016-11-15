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

namespace janzenzl_final
{
    public partial class Results : UserControl
    {
        public Results()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            // add final variables to the text box to display results
            txtHoldMe.Text = lblFinalNumber.Text + " " + lblFinalStreet.Text;
            txtHoldMe.AppendText("\n");
            txtHoldMe.AppendText(lblFinalCity.Text + ", " + lblFinalState.Text);
        }
    }
}
