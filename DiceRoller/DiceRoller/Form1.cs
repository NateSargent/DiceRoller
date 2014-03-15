using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;

namespace DiceRoller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {

            string numberOfRollsString = numericUpDownNumOfRolls.Text;
            string minValueString = numericUpDownMinValue.Text;
            string maxValueString = numericUpDownMaxValue.Text;
            string optionalConstantString = numericUpDownOptionalConstant.Text;

            int numberOfRollsInt = 0;
            int minValueInt = 0;
            int maxValueInt = 0;
            int optionalConstantInt = 0;

            try
            {
                numberOfRollsInt = convertStringToInt(numberOfRollsString);                
                minValueInt = convertStringToInt(minValueString);
                maxValueInt = convertStringToInt(maxValueString);
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Invalid Input! Please only use numbers, and ensure all fields are filled in.", "DiceRoller", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            catch (OverflowException exception)
            {
                MessageBox.Show("Invalid Input! Number too large.", "DiceRoller", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            //handle optional constant
            if (optionalConstantString == "")
            {
                numericUpDownOptionalConstant.Text = "0";
                optionalConstantString = "0";
                optionalConstantInt = 0;
            }
            else
            {
                try
                {
                    optionalConstantInt = convertStringToInt(optionalConstantString);
                }
                catch (FormatException exception)
                {
                    MessageBox.Show("Invalid Input! Please only use numbers, and ensure all fields are filled in.", "DiceRoller", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
                catch (OverflowException exception)
                {
                    MessageBox.Show("Invalid Input! Number too large.", "DiceRoller", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
            }

            //check to ensure number of rolls and max and min values aren't negative.
            if (numberOfRollsInt <= 0 || minValueInt < 0 || maxValueInt <= 0)
            {
                MessageBox.Show("Improper negative value!", "DiceRoller", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            else
            {
                // roll the dice
                //MessageBox.Show("Theoretically, this would have rolled dice. We'll work on it.", "DiceRoller", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                //build URL
                string url = "http://www.random.org/integers/?num=" + numberOfRollsString +
                "&min=" + minValueString + "&max=" + maxValueString + "&col=1&base=10&format=plain&rnd=new";

                //use URL to get HTML from random.org
                WebClient client = new WebClient();
                string htmlCode = client.DownloadString(url);
                //replace \n newlines with Windows-compliant \r\n newlines
                string htmlCodeWithNewlines = htmlCode.Replace("\n", "\r\n");

                //We're about to use .Split(), so we should strip the trailing \r\n so Split won't expect a value to the right of it that isn't there.
                string htmlCodeWithNewlinesTrimmed = htmlCodeWithNewlines.TrimEnd('\r','\n');
                Console.WriteLine(htmlCodeWithNewlinesTrimmed);


                //HTML is of the form '1\r\n2\r\n3\r\n...' explode into array with .Split and convert array elements to integers to add the optional constant
                string[] valueArrayString = Regex.Split(htmlCodeWithNewlinesTrimmed, "\r\n");
                Console.WriteLine("Length: " + valueArrayString.Length.ToString());
                //Console.WriteLine(valueArrayString[0] + "+" + valueArrayString[1] + "+" + valueArrayString[3]);
                int[] valueArrayInt = new int[valueArrayString.Length];
                Console.WriteLine("Length int: " + valueArrayInt.Length.ToString());
                //fill valueArrayInt with integer equivalents from valueArrayString
                for (int i = 0; i < valueArrayString.Length; i++)
                {
                    valueArrayInt[i] = convertStringToInt(valueArrayString[i]);
                }

                //add optional constant to each value in valueArrayInt
                for (int i = 0; i < valueArrayInt.Length; i++)
                {
                    valueArrayInt[i] = valueArrayInt[i] + optionalConstantInt;
                }

                //replace the old values in valueArrayString with the new ones from valueArrayInt
                for (int i = 0; i < valueArrayString.Length; i++)
                {
                    valueArrayString[i] = valueArrayInt[i].ToString();
                }

                //Join valueArrayString into a single string with the newlines put back in
                string htmlCodeWithNewlinesPlusOptionalConstant = String.Join("\r\n", valueArrayString);
                //print values to textBoxValues:
                textBoxValues.Text = htmlCodeWithNewlinesPlusOptionalConstant;

                //total values and fill total box:
                int total = 0;
                for (int i = 0; i < valueArrayInt.Length; i++)
                {
                    total += valueArrayInt[i];
                }
                textBoxTotal.Text = total.ToString();
                
            }

        }

        private int convertStringToInt(string stringValueToBeConverted)
        //converts strings to ints using Convert.ToInt32
        //    raises two exceptions: FormatException, on non-numeric input,
        //    and OverflowException, when value exceeds capacity of int32.
        { 
            int integerConversion = Convert.ToInt32(stringValueToBeConverted);
            return integerConversion;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "DiceRoller 0.1, by Nate Sargent, 2014. " +
                "DiceRoller rolls dice. More exactly, DiceRoller is a graphical frontend for the random.org HTTP API. " +
                "All the randomness comes from them. "
                , "DiceRoller", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void saveDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save default configuration
        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
