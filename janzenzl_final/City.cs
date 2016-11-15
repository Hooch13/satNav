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
using System.Xml.Linq;
using System.Xml;
using System.Text.RegularExpressions;

namespace janzenzl_final
{
    public partial class City : UserControl
    {
        public City()
        {
            InitializeComponent();
        }


        private void City_Load(object sender, EventArgs e)
        {

        }

        // list of city objects
        List<object> cities = new List<object>();

        // buttons to add text to the textbox
        private void btnA_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "A";
        }


        private void btnB_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "B";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "C";
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "D";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "E";
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "F";
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "G";
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "H";
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "I";
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "J";
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "K";
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "L";
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "M";
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "N";
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "O";
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "P";
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "Q";
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "R";
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "S";
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "T";
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "U";
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "V";
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "W";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "X";
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "Y";
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "Z";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtHoldCity.Text.Length > 0)
            {
                txtHoldCity.Text = txtHoldCity.Text.Remove(txtHoldCity.Text.Length - 1, 1);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + "0";
        }


        private void lblState_Click(object sender, EventArgs e)
        {

        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            txtHoldCity.Text = txtHoldCity.Text + " ";


        }

        // text changed event on text box
        private void txtHoldCity_TextChanged(object sender, EventArgs e)
        {
            // list of cities with no duplicates
            List<object> newCities = new List<object>();

            // https://msdn.microsoft.com/en-us/library/system.xml.xmlreader%28v=vs.110%29.aspx
            // https://msdn.microsoft.com/en-us/library/9khb6435%28v=vs.100%29.aspx     Creating the XMLReader
            // https://msdn.microsoft.com/en-us/library/9d83k261%28v=vs.100%29.aspx     Reading with the XMLReader
            // https://msdn.microsoft.com/en-us/library/ayf5ffy5%28v=vs.110%29.aspx     XmlReader.ReadToDescendant Method 

            //xml reader
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Fragment;
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            
            using (XmlReader reader = XmlReader.Create("..\\..\\..\\location.xml", settings))
            {
                reader.MoveToContent();
                do
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            //Console.Write("{0} : ", reader.Name);
                            while (reader.MoveToNextAttribute())
                            {
                                //Console.Write(" {0}='{1}'", reader.Name, reader.Value);
                            }
                            //Console.Write(">");
                            break;
                        case XmlNodeType.Text:

                            string compare1 = reader.Value.ToUpper();
                            compare1 = Regex.Replace(compare1, @"\t|\n|\r", "");
                            string compare2 = lblState.Text;

                            // compare element in xml to state
                            if (compare1 == compare2)
                            {
                                reader.Read();

                                if (reader.Name == "City")
                                {
                                    do
                                    {

                                        // string manipulation to get cities out of city node and add to cities list
                                        string innerXML = reader.ReadInnerXml();
                                        innerXML = Regex.Replace(innerXML, @"\s+", "");
                                        string[] listOfCities = innerXML.Split(new[] { "<" }, StringSplitOptions.None);
                                        string city = listOfCities[0].ToUpper();

                                        cities.Add(city);

                                    } while (reader.Name == "City");
                                }
                            }
                            break;
                        case XmlNodeType.EndElement:
                            //Console.Write("</{0}>", reader.Name);
                            break;

                    }
                } while (reader.Read());

            }

            // for each city in the cities list
            foreach (string city in cities)
            {
                char[] myCharArray = city.ToCharArray();

                // my attempt at disabling buttons
                //foreach (char chars in myCharArray) {
                //    foreach(Control c in Controls) { 
                //    Button b = c as Button;
                //    if (b != null) {
                //        b.Enabled = false;
                //    }
                //    }
                //}
                
                // the buttons we want to appear are the textbox.text.length+1

                //length of text in textbox
                int tblength = txtHoldCity.Text.Length;

                string test = city;

                if (city.Length > tblength)
                {
                    test = city.Substring(0, tblength);

                }



                // if test equal the text in city text box
                if (test.Equals(txtHoldCity.Text))
                {
                    // add the city to the new city list
                    
                    newCities.Add(city);
                }


            }

            // sort and make sure new cities is distinct.
            newCities = newCities.Distinct().ToList();
            newCities.Sort();
            // clear listbox
            lbOfCities.Items.Clear();
            // for each city in the new distinct city list
            foreach (string asdCity in newCities)
            {
                // add the city to the listbox
                lbOfCities.Items.Add(asdCity);
            }

            // if theres nothing typed in the textbox
            if (txtHoldCity.Text == "")
            {
                // clear the listbox
                lbOfCities.Items.Clear();
            }

        }

        // click listbox event handler
        private void lbOfCities_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbOfCities.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                // instantiate a new street object and add it to the main forms panel.
                Street myStreet = new Street();
                frmMain myParent = (frmMain)this.Parent.Parent;
                string street = lbOfCities.Text;
                myParent.pMain.Controls.Clear();
                myStreet.lblStreet.Text = street.ToUpper();
                myStreet.lblStateVariable.Text = lblState.Text;
                myStreet.lblCityVariable.Text = street;
                myParent.pMain.Controls.Add(myStreet);
            }
        }

        private void lbOfCities_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }

}

