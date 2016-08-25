using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;




namespace LogManipulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                /*openFileDialog1.FileName);*/
                string FileName = openFileDialog1.FileName;
                textBoxFileName.Text = FileName;
                listHeadings.Items.Clear();
                updateFileDetails(sender, e);

            }
        }

        private void updateFileDetails(object sender, EventArgs e)
        {

            string FileName = textBoxFileName.Text;

            if (FileName == "")
            {
                return;
            }

            using (ShellObject shell = ShellObject.FromParsingName(FileName))
            {
                // alternatively: shell.Properties.GetProperty("System.Media.Duration");
                IShellProperty prop = shell.Properties.System.Media.Duration;
                // Duration will be formatted as 00:44:08
                //string duration = prop.FormatForDisplay(PropertyDescriptionFormatOptions.None);
                //string[] hms = duration.Split(':');

                string filetype = shell.Properties.System.ItemType.Value;
                textBoxFileType.Text = filetype;

                //Parse the headers and populate the listbox
                read_TSVFile(sender, e, textBoxFileName.Text, true);
            }

        }

        private void read_TSVFile(object sender, EventArgs e, string FileName, bool HeadersOnly)
        {
       
            string line;
            string regexString = "";
            string regexStringFooter = "";
            string splitChar = "";
            string HeaderFile = "";
            string ProcessedFile = "";

            if (HeadersOnly)
            {
                labelMaxItems.Text = " of 0";
                listHeadings.ResetText();
                ProcessedFile = FileName + ".headers" + textBoxFileType.Text;

            }
            else
            {
                HeaderFile = FileName + ".headers" + textBoxFileType.Text;
                ProcessedFile = FileName + ".processed" + textBoxFileType.Text;
            }

            int fieldToMod = Int16.Parse(textItemNo.Text);

            if (FileName == "")
            {
                return; 
            }

            // Read the file and display it line by line.

            StreamReader file = new StreamReader(FileName);

            StreamWriter outputFile = new StreamWriter(ProcessedFile);

            if (textBoxFileType.Text == ".csv")
            {
                regexString = @"^CUSTOM.updateTime";
                //This is a fudge there is no footer in the csv file;
                regexStringFooter = @"#Flight Recorder Session End";
                splitChar = ",";
            }
            else if (textBoxFileType.Text == ".tsv")
            {
                regexString = @"^Date\/Time \(GMT\)";
                regexStringFooter = @"#Flight Recorder Session End";
                splitChar = "\t";
            }
            else
            {
                MessageBox.Show ("Could not Recognise File Type","File Not Recognised");
            }
           
            bool isHeader = true;
            bool isFooter = false;
            bool Continue = true;
            bool Success = true;

            string strHeader = "";
            string[] strHeadings = new string[0];

            while ( Success && Continue && (line = file.ReadLine()) != null )
            {
                //Console.WriteLine(line);

                Regex regexFooter = new Regex(regexStringFooter);
                Match matchFooter = regexFooter.Match(line);

                if (matchFooter.Success)
                {
                    isFooter = true;
                }

                if (isHeader)
                {
                    Regex regexHeader = new Regex(regexString);
                    Match match = regexHeader.Match(line);
                    if (match.Success)
                    {
                        isHeader = false;
                        if (HeadersOnly)
                        {
                            strHeadings = line.Split(splitChar.ToCharArray());
                            listHeadings.Items.AddRange(strHeadings);
                            int itemcount = listHeadings.Items.Count - 1;
                            labelMaxItems.Text = "of " + itemcount.ToString();
                            Continue = false;
                        }
                        else
                        {
                            outputFile.WriteLine(line);
                        }
                    }
                    else
                    {
                        strHeader = strHeader + line;
                        if (HeadersOnly)
                        {
                            outputFile.WriteLine(line);
                        }
                    }
                }
                else if (isFooter)
                {

                    //StreamWriter outputFooter = new StreamWriter(HeaderFile, true); }
                    //outputFooter.WriteLine(line);

                }
                else if (!isHeader)
                {
                    // Manipulate the data here
                    //outputFile.WriteLine(line);
                    var values = line.Split(splitChar.ToCharArray());
                    string strModified = "";
                    string strModField = values[fieldToMod].ToString();
                    double dblmodField = 0;
                    if (strModField != "")
                    {

                        try
                        {
                            dblmodField = Double.Parse(strModField);

                        }
                        catch (FormatException fe)
                        {
                            strModified = strModField;
                            Success = false;
                            string Message = "Failed to parse field '" + fieldToMod.ToString() + "' Value '" + strModField + "'\nError Message '" + fe.Message + "'";
                            MessageBox.Show(Message, "Failed to Parse Field");

                        }

                    }
                    else
                    {
                        dblmodField = 0;
                    }


                    double modValue = 0;
                    try
                    {
                        modValue = Double.Parse(textBoxAdjustment.Text);
                    }
                    catch (FormatException fe)
                    {
                        strModified = strModField;
                        Success = false;
                        string Message = "Failed to parse Adjustment Value '" + textBoxAdjustment.Text + "'\nError Message '" + fe.Message +"'";
                        MessageBox.Show(Message, "Failed to Parse Adjustment Value");

                    }
                    

                    dblmodField = dblmodField + modValue;
                    strModified = dblmodField.ToString();
                    values[fieldToMod] = dblmodField.ToString();
                    outputFile.WriteLine( String.Join(splitChar, values));
                    //outputFile.WriteLine("Field to Mod " + fieldToMod.ToString() + " Value " + strModField + " Modified:" + strModified);
                }
  
            }

            file.Close();
            outputFile.Close();

            if (Success && !HeadersOnly)
            {
                MessageBox.Show("Operation Completed Successfully", "File Processing Complete");
            } else if (!Success && HeadersOnly)
            {
                File.Delete(HeaderFile);
            } else if (!Success)
            {
                File.Delete(HeaderFile);
                File.Delete(ProcessedFile);
            }

            

          
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBoxAdjustment.Text = Convert.ToString(Convert.ToInt16(textBoxAdjustment.Text) + 1);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBoxAdjustment.Text = Convert.ToString(Convert.ToInt16(textBoxAdjustment.Text) - 1);
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            read_TSVFile(sender, e, textBoxFileName.Text , true);
        }

        private void listHeadings_SelectedIndexChanged(object sender, EventArgs e)
        {
            textItemNo.Text = listHeadings.SelectedIndex.ToString();
        }

        private void textItemNo_TextChanged(object sender, EventArgs e)
        {
            int indSelected = 0;

            try
            {
                indSelected = Int16.Parse(textItemNo.Text);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                listHeadings.SelectedIndex = indSelected;
            }
            catch ( ArgumentOutOfRangeException ae)
            {
                Console.WriteLine(ae.Message);
                listHeadings.SelectedIndex = 0;
                //textItemNo.Text = "0";
            }
            
        }

        private void buttonProcess_Click_1(object sender, EventArgs e)
        {
            read_TSVFile(sender, e, textBoxFileName.Text, false);
        }
    }
}
