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
    public partial class Number : UserControl
    {
        public Number()
        {
            InitializeComponent();
        }


        private void City_Load(object sender, EventArgs e)
        {

        }

        // list of city objects
        List<object> numbers = new List<object>();

        // buttons to add text to textbox
        private void btnA_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "A";
        }


        private void btnB_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "B";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "C";
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "D";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "E";
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "F";
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "G";
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "H";
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "I";
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "J";
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "K";
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "L";
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "M";
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "N";
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "O";
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "P";
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "Q";
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "R";
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "S";
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "T";
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "U";
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "V";
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "W";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "X";
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "Y";
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "Z";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtHoldNumber.Text.Length > 0)
            {
                txtHoldNumber.Text = txtHoldNumber.Text.Remove(txtHoldNumber.Text.Length - 1, 1);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + "0";
        }


        private void lblState_Click(object sender, EventArgs e)
        {

        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            txtHoldNumber.Text = txtHoldNumber.Text + " ";

        }

        private void txtHoldCity_TextChanged(object sender, EventArgs e)
        {
            // new list of distinct street numbers
            List<object> newNumbers = new List<object>();

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

                            // compare whats in the lbl to text in xml
                            string compare1 = reader.Value.ToUpper();
                            compare1 = Regex.Replace(compare1, @"\t|\n|\r", "");
                            compare1 = Regex.Replace(compare1, @"\s+", ""); 
                            string compare2 = lblNumber.Text;

                            if (compare1 == compare2)
                            {
                                reader.Read();

                                if (reader.Name == "Number")
                                {
                                    do
                                    {
                                        // read each number node and add to the list of numbers
                                        string innerXML = reader.ReadInnerXml();
                                        innerXML = Regex.Replace(innerXML, @"\s+", "");
                                        string[] listOfNumbers = innerXML.Split(new[] { "<" }, StringSplitOptions.None);
                                        string number = listOfNumbers[0].ToUpper();

                                        numbers.Add(number);

                                    } while (reader.Name == "Number");
                                }
                            }
                            break;
                        case XmlNodeType.EndElement:
                            //Console.Write("</{0}>", reader.Name);
                            break;

                    }
                } while (reader.Read());

            }

            // for each number
            foreach (string number in numbers)
            {

                //char[] myCharArray = city.ToCharArray();
                //length of text in textbox currently
                int tblength = txtHoldNumber.Text.Length;

                string test = number;
                if (number.Length > tblength)
                {
                    test = number.Substring(0, tblength);
                }

                // add number to list of numbers
                if (test.Equals(txtHoldNumber.Text))
                {
                    newNumbers.Add(number);
                }


            }

            // distinct list of numbers, sorted
            newNumbers = newNumbers.Distinct().ToList();
            newNumbers.Sort();
            lbOfNumbers.Items.Clear();
            // clear listbox and add distinct number to list
            foreach (string asdNumber in newNumbers)
            {
                lbOfNumbers.Items.Add(asdNumber);
            }

            // clear lb if nothing is in the textbox
            if (txtHoldNumber.Text == "")
            {
                lbOfNumbers.Items.Clear();
            }

        }

        private void lbOfCities_MouseDoubleClick(object sender, MouseEventArgs e)
        {
 
        }

        private void lbOfNumbers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbOfNumbers.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                // instantiate and declare new result object to add to main form panel.
                Results myResult = new Results();
                frmMain myParent = (frmMain)this.Parent.Parent;
                string number = lbOfNumbers.Text;
                myParent.pMain.Controls.Clear();
                myResult.lblFinalNumber.Text = number;
                myResult.lblFinalCity.Text = lblCityVariable2.Text;
                myResult.lblFinalState.Text = lblStateVariable2.Text;
                myResult.lblFinalStreet.Text = lblStreetVariable2.Text;
                myResult.lblFinalNumber.Text = number;
                myParent.pMain.Controls.Add(myResult);
            }
        }
    }

}

