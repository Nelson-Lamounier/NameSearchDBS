// Application that reads the contents of the 2 files into 2 separate Arrays or Lists.
//The user should be able to enter a Boy's name, a Girl's name or both and
//the application should display messages indicating whether the names were among the most popular. 

// File needed is placed on /bin/debug folder

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Variable to hold user's input
            string searchForBoyName = textBoxBoy.Text;
            string searchForGirlName = textBoxGirl.Text;
            int counter = 0; // To track the position of the name against the txt file initialized to 0
            string message = ""; // String message as user will be able to serach only boys names and vice verse
            bool found = false; // If name is found, change boolean to true

            try
            {
                // Create arrays for boy's name and a list for girl's name - Boy's will be read into a string - Girl's populate a list
                string[] boyNames = File.ReadAllLines("C:BoyNames.txt");
                List<string> girlNames = new List<string>();

                // Evaluate boys name input against the txt file
                foreach (string value in boyNames)
                {
                    if (boyNames[counter].ToUpper() == searchForBoyName.ToUpper() && searchForBoyName != "")
                    {
                        message += searchForBoyName + " was the #" + (counter + 1) + "Boy's name\n";
                        found = true;
                        break;
                    }

                    counter++; // If name not found, increase the counter for the next iteration of the loop
                }
                // Statment if name not found
                if (!found && searchForBoyName != "")
                    message += searchForBoyName + " was NOT found in boys names!\n";

                // Evaluate girls name input against the txt file
                StreamReader sr = new StreamReader("C:GirlNames.txt");
                string line;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    girlNames.Add(line); // Populate list of names
                }

                // Second argument to Validate upper and lower case input
                if (girlNames.Contains(searchForGirlName, StringComparer.OrdinalIgnoreCase))
                {
                    // Make it a first letter uppercase case
                    string name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(searchForGirlName);                    counter = girlNames.IndexOf(name);
                    message += searchForGirlName + " was the #" + (counter + 1) + "Girl's name\n";
                   
                }
                else if (searchForGirlName != "")
                    message += searchForGirlName + " was NOT found in girls names! \n";
                

                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
