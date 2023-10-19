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
            int counter = 0;
            string message = "";
            bool found = false;

            try
            {
                // Create arrays for boy's name and a list for girl's name
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

                    counter++;
                }

                if (!found && searchForBoyName != "")
                    message += searchForBoyName + " was NOT found in boys names!\n";

                // Evaluate girls name input against the txt file
                StreamReader sr = new StreamReader("C:GirlNames.txt");
                string line;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    girlNames.Add(line);
                }

                if (girlNames.Contains(searchForGirlName, StringComparer.OrdinalIgnoreCase))
                {
                    // Validate upper and lower case input
                    string name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(searchForGirlName);
                    counter = girlNames.IndexOf(name);
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
