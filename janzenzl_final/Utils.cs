/* ****************************************************************************************************************
 * Name: Zach Janzen
 * Assignment #: Final
 * Due Date: 12/8/2015
 * Course/Term/Section: IT3045C
 * Short Description: This form application closely resembles the functionality of  
 * the satallite navigation system in Professor Bill Nicholson's Toyota Sienna.
 * ****************************************************************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace janzenzl_final
{
    class Utils
    {


        /*
            Utils class. Contains different readers of XML files
        */

        public static string stateReader()
        {

            string lineText;
            string states = "";

            // Read the file line by line. https://msdn.microsoft.com/en-us/library/aa287535(v=vs.71).aspx
            StreamReader file = new StreamReader("..\\..\\..\\location.xml");
            while ((lineText = file.ReadLine()) != null)
            {
                
                if (lineText.Contains("<State>"))
                {
                    // seperate on break tag
                    string[] separators = { "<State>" };
                    // each line becomes part of a string array, broken up by break tag
                    string[] lines = lineText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    
                    foreach (string line in lines)
                    {
                        states = states + line.Trim() + ",";
                    }
                }
                
            }

            return states;
        }

        public static string cityReader()
        {
            

            string lineText;
            string cities = "";

            // Read the file line by line. https://msdn.microsoft.com/en-us/library/aa287535(v=vs.71).aspx
            StreamReader file = new StreamReader("..\\..\\..\\location.xml");
            while ((lineText = file.ReadLine()) != null)
            {

                if (lineText.Contains("<City>"))
                {
                    // seperate on break tag
                    string[] separators = { "<City>" };
                    // each line becomes part of a string array, broken up by break tag
                    string[] lines = lineText.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string line in lines)
                    {
                        cities = cities + line.Trim() + ",";
                    }
                }

            }

            return cities;
        }

        public static string streetReader()
        {
            

            string lineText;
            string streets = "";

            // Read the file line by line. https://msdn.microsoft.com/en-us/library/aa287535(v=vs.71).aspx
            StreamReader file = new StreamReader("..\\..\\..\\location.xml");
            while ((lineText = file.ReadLine()) != null)
            {

                if (lineText.Contains("<Street>"))
                {
                    // seperate on break tag
                    string[] separators = { "<Street>" };
                    // each line becomes part of a string array, broken up by break tag
                    string[] lines = lineText.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string line in lines)
                    {
                        streets = streets + line.Trim() + ",";
                    }
                }

            }

            return streets;
        }

        public static string numberReader()
        {
           
            string lineText;
            string numbers = "";

            // Read the file line by line. https://msdn.microsoft.com/en-us/library/aa287535(v=vs.71).aspx
            StreamReader file = new StreamReader("..\\..\\..\\location.xml");
            while ((lineText = file.ReadLine()) != null)
            {

                if (lineText.Contains("<Number>"))
                {
                    // seperate on break tag
                    string[] separators = { "<Number>" };
                    // each line becomes part of a string array, broken up by break tag
                    string[] lines = lineText.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string line in lines)
                    {
                        numbers = numbers + line.Trim() + ",";
                    }
                }

            }

            return numbers;
        }

    }

}

