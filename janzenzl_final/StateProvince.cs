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
using System.Collections;

namespace janzenzl_final
{
    public partial class StateProvince : UserControl
    {

        public StateProvince()
        {
            InitializeComponent();
        }

        // for each button clear the listbox of its current contents.
        // then add states that begin with the letters displayed on the buttons to the listbox.
        // this is done for each button on the user control. Uses stateReader from the utils class.
        private void btnABC_Click(object sender, EventArgs e)
        {
            lbStates.Items.Clear();
            string allStates = Utils.stateReader();
            string[] values = allStates.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string state in values)
            {
                if (state.StartsWith("A") || state.StartsWith("B") || state.StartsWith("C"))
                {
                    lbStates.Items.Add(state);
                }
            }
        }

        private void btnDEF_Click(object sender, EventArgs e)
        {
            lbStates.Items.Clear();
            string allStates = Utils.stateReader();
            string[] values = allStates.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string state in values)
            {
                if (state.StartsWith("D") || state.StartsWith("E") || state.StartsWith("F"))
                {
                    lbStates.Items.Add(state);
                }
            }
        }

        private void btnGHI_Click(object sender, EventArgs e)
        {
            lbStates.Items.Clear();
            string allStates = Utils.stateReader();
            string[] values = allStates.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string state in values)
            {
                if (state.StartsWith("G") || state.StartsWith("H") || state.StartsWith("I"))
                {
                    lbStates.Items.Add(state);
                }
            }
        }

        private void btnJKL_Click(object sender, EventArgs e)
        {
            lbStates.Items.Clear();
            string allStates = Utils.stateReader();
            string[] values = allStates.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string state in values)
            {
                if (state.StartsWith("J") || state.StartsWith("K") || state.StartsWith("L"))
                {
                    lbStates.Items.Add(state);
                }
            }
        }

        private void btnMNO_Click(object sender, EventArgs e)
        {
            lbStates.Items.Clear();
            string allStates = Utils.stateReader();
            string[] values = allStates.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string state in values)
            {
                if (state.StartsWith("M") || state.StartsWith("N") || state.StartsWith("O"))
                {
                    lbStates.Items.Add(state);
                }
            }
        }

        private void btnPQRS_Click(object sender, EventArgs e)
        {
            lbStates.Items.Clear();
            string allStates = Utils.stateReader();
            string[] values = allStates.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string state in values)
            {
                if (state.StartsWith("P") || state.StartsWith("Q") || state.StartsWith("R") || state.StartsWith("S"))
                {
                    lbStates.Items.Add(state);
                }
            }
        }

        private void btnTUV_Click(object sender, EventArgs e)
        {
            lbStates.Items.Clear();
            string allStates = Utils.stateReader();
            string[] values = allStates.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string state in values)
            {
                if (state.StartsWith("T") || state.StartsWith("U") || state.StartsWith("V"))
                {
                    lbStates.Items.Add(state);
                }
            }
        }

        private void btnWXYZ_Click(object sender, EventArgs e)
        {
            lbStates.Items.Clear();
            string allStates = Utils.stateReader();
            string[] values = allStates.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string state in values)
            {
                if (state.StartsWith("W") || state.StartsWith("X") || state.StartsWith("Y") || state.StartsWith("Z"))
                {
                    lbStates.Items.Add(state);
                }
            }
        }

        // mouse dbl click on item in lb
        private void lbStates_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbStates.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                // instantiate & declare address object and add it to the form. also enable buttons on myAddress
                Address myAddress = new Address();
                frmMain myParent = (frmMain)this.Parent.Parent;
                string state = lbStates.Text;
                myParent.pMain.Controls.Clear();
                myAddress.txtHoldState.Text = state.ToUpper();
                myParent.pMain.Controls.Add(myAddress);
                myAddress.btnCity.Enabled = true;
                myAddress.btnStreetAddress.Enabled = true;                
           
            }
        }

        // loads all states into listbox on page load
        private void StateProvince_Load(object sender, EventArgs e)
        {
            lbStates.Items.Clear();
            string allStates = Utils.stateReader();
            string[] values = allStates.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string state in values)
            {
                    lbStates.Items.Add(state);               
            }
        }
    }
}
