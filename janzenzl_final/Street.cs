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
    public partial class Street : UserControl
    {
        public Street()
        {
            InitializeComponent();
           
        }


        private void City_Load(object sender, EventArgs e)
        {

        }

        // list of city objects
        List<object> streets = new List<object>();

        // for each button, adds that buttons text to the textbox.
        private void btnA_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "A";
        }


        private void btnB_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "B";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "C";
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "D";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "E";
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "F";
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "G";
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "H";
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "I";
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "J";
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "K";
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "L";
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "M";
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "N";
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "O";
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "P";
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "Q";
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "R";
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "S";
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "T";
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "U";
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "V";
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "W";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "X";
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "Y";
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "Z";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtHoldStreet.Text.Length > 0)
            {
                txtHoldStreet.Text = txtHoldStreet.Text.Remove(txtHoldStreet.Text.Length - 1, 1);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + "0";
        }


        private void lblState_Click(object sender, EventArgs e)
        {

        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            txtHoldStreet.Text = txtHoldStreet.Text + " ";


        }

        private void txtHoldCity_TextChanged(object sender, EventArgs e)
        {
            // newstreets list is a distinct version of streets.
            List<object> newStreets = new List<object>();
            //xml stuff
            // https://msdn.microsoft.com/en-us/library/system.xml.xmlreader%28v=vs.110%29.aspx
            // https://msdn.microsoft.com/en-us/library/9khb6435%28v=vs.100%29.aspx     Creating the XMLReader
            // https://msdn.microsoft.com/en-us/library/9d83k261%28v=vs.100%29.aspx     Reading with the XMLReader
            // https://msdn.microsoft.com/en-us/library/ayf5ffy5%28v=vs.110%29.aspx     XmlReader.ReadToDescendant Method 

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

                            // compare street labels text to text in xml doc
                            string compare1 = reader.Value.ToUpper();
                            compare1 = Regex.Replace(compare1, @"\t|\n|\r", "");
                            string compare2 = lblStreet.Text;

                            if (compare1 == compare2)
                            {
                                reader.Read();

                                if (reader.Name == "Street")
                                {
                                    do
                                    {
                                        // while there are street nodes, add the street text to the streets list
                                        string innerXML = reader.ReadInnerXml();
                                        innerXML = Regex.Replace(innerXML, @"\s+", "");
                                        string[] listOfStreets = innerXML.Split(new[] { "<" }, StringSplitOptions.None);
                                        string street = listOfStreets[0].ToUpper();

                                        streets.Add(street);

                                    } while (reader.Name == "Street");
                                }
                            }
                            break;
                        case XmlNodeType.EndElement:
                            //Console.Write("</{0}>", reader.Name);
                            break;

                    }
                } while (reader.Read());

            }

            // for each street in list streets
            foreach (string street in streets)
            {

                //char[] myCharArray = city.ToCharArray();
                // length of text in txtbox currently
                int tblength = txtHoldStreet.Text.Length;

                string test = street;

                // if the length of the street is longer than whats in the textbox
                if (street.Length > tblength)
                {
                    // test is equal to the start of itself until the length of whats in the textbox
                    test = street.Substring(0, tblength);
                }

                // if test(part of street) is equal to the text in the textbox
                if (test.Equals(txtHoldStreet.Text))
                {
                    // add the street to the new list of streets
                    newStreets.Add(street);
                }


            }
            // make sure newStreets is distinct and sorted
            newStreets = newStreets.Distinct().ToList();
            newStreets.Sort();
            //clear the lb
            lbOfStreets.Items.Clear();
            // for each street in the distinct version of streets
            foreach (string asdStreet in newStreets)
            {
                // add street to lb
                lbOfStreets.Items.Add(asdStreet);
            }

            // if nothing in the textbox
            if (txtHoldStreet.Text == "")
            {
                // clear the lb
                lbOfStreets.Items.Clear();
            }

        }

        private void lbOfCities_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void lbOfStreets_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbOfStreets.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                // declare and instantiate new number object
                // add the new number object with variables to the main form.
                Number myNumber = new Number();
                frmMain myParent = (frmMain)this.Parent.Parent;
                string street = lbOfStreets.Text;
                myParent.pMain.Controls.Clear();
                myNumber.lblNumber.Text = street.ToUpper();
                myNumber.lblStateVariable2.Text = lblStateVariable.Text;
                myNumber.lblCityVariable2.Text = lblCityVariable.Text;
                myNumber.lblStreetVariable2.Text = street;
                myParent.pMain.Controls.Add(myNumber);
            }
        }
    }

}

