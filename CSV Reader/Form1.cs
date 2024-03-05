using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;                    // Added reference for the input box.

namespace CSV_Reader
{
    public partial class Form1 : Form
    {
        private DataTable csvData;
        private string selectedFilePath;
        private string[] FileData;             // Creating a global variable to store .csv file data.

        public Form1()
        {
            InitializeComponent();
        }

        private void ImportFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                openFileDialog.Filter = "CSV Files Only (*.csv)|*.csv";        // Importing and filtering file.
                openFileDialog.Title = "Select file";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = openFileDialog.FileName;
                    FileNameLabel.Text = openFileDialog.FileName + " imported successfully";       // Message for bottom left label
                    try
                    {
                        csvData = new DataTable();
                        ReadCsvFile(openFileDialog.FileName);
                        DisplayCsvData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void DisplayCsvData()                                // Displays or refreshes data.
        {
            DataGridView.DataSource = csvData;
        }

        private void ReadCsvFile(string filepath)                    // Main method for processing the csv file.
        {
            csvData = new DataTable();

            string[] lines = File.ReadAllLines(filepath);           // Reading all lines in .csv file.
            FileData = File.ReadAllLines(filepath);                 // Copying data to global variable.
            ColumnDropDown.Items.Clear();                           // Clearing items so as to reset values
                                                                    // if new file is imported.(Else the 
            if (lines.Length == 0)                                  // old items will stack dropdown items).
            {
                throw new Exception("The CSV file is empty.");
            }
            if(HeaderCheckBox.Checked)                               // Checking if headers provided.
            {                                                        // If true then:
                string[] headers = lines[0].Split(',');              // Splitting first line into Headers.
                string[] data = lines[1].Split(',');                 // Splitting first data line to acquire
                if(headers.Length >= data.Length)                    // array length to check for empty 
                {                                                    // header values.
                    for(int i=0; i < headers.Length; i++)
                    {
                        csvData.Columns.Add(headers[i].Trim());      // Adding headers.
                        ColumnDropDown.Items.Add(headers[i]);        // Adding headers to Filter Options Dropdown.
                    }

                    for (int i = 1; i < lines.Length; i++)
                    {
                        data = lines[i].Split(',');                  // Splitting and adding data from each line.
                        csvData.Rows.Add(data);
                    }
                }
                else
                {
                    MessageBox.Show("Empty value found in header. File cannot be loaded.");
                }
            }
            else                                                      // Else if headers not provided then:
            {
                string[] headers = new string[20];
                string[] data = lines[0].Split(',');
                for(int i = 0; i<data.Length; i++)                    // Taking input for headers.
                {
                    headers[i] = Interaction.InputBox("Enter value for index: " + i, "Header Input", "Enter column header here");
                    csvData.Columns.Add(headers[i].Trim());
                    ColumnDropDown.Items.Add(headers[i]);
                }

                for (int i = 0; i < lines.Length; i++)                // Adding the rest of the data.
                {
                    data = lines[i].Split(',');
                    csvData.Rows.Add(data);
                }
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)    // Applies selected filters
        {
            if(selectedFilePath != null)
            {
                string SelectedColumnHeader = ColumnDropDown.SelectedItem.ToString();
                csvData = new DataTable();
                csvData.Columns.Add(SelectedColumnHeader);
                string[] columnData = FileData;
                for (int i = 1; i < columnData.Length; i++)
                {
                    string[] data = columnData[i].Split(',');
                    csvData.Rows.Add(data[ColumnDropDown.SelectedIndex]);       // Column filter.
                }
                DisplayCsvData();
            }
            else
            {
                MessageBox.Show("No .csv file is selected.");
            }

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if(selectedFilePath != null)
            {
                csvData = new DataTable();
                ReadCsvFile(selectedFilePath); // Pass the selected file path to ReadCsvFile method
                DisplayCsvData();
            }
            else
            {
                MessageBox.Show("No .csv file is selected.");
            }    
                
        }
    }
}
