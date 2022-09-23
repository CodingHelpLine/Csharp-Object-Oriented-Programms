using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicStatisticsApp
{
    public partial class MainForm : Form
    {

        // Data storage
        private int[] rawData;
        private int[] sortedData;
        private int size, lowerLimit, upperLimit;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler to read the inputs - generate Data and Sort the data. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Parse values
            size = int.Parse(txtSize.Text);
            lowerLimit = int.Parse(txtLower.Text);
            upperLimit = int.Parse(txtUpper.Text);

            //allocate
            rawData = new int[size];
            sortedData = new int[size];

            // Generate data
            Random random = new Random();
            for(int i=0; i<size; i++)
            {
                rawData[i] = random.Next(lowerLimit, upperLimit + 1);
                sortedData[i] = rawData[i];
            }

            // sort
            SortedData();

            // Load into Lists
            lstRaw.Items.Clear();
            lstSorted.Items.Clear();

            for(int i=0; i<size; i++)
            {
                lstRaw.Items.Add(rawData[i]);
                lstSorted.Items.Add(sortedData[i]);
            }
        }

        private void SortedData()
        {
            for(int i=0; i<size; i++)
            {
                for(int j=i+1; j<size; j++)
                {
                    if(sortedData[i] > sortedData[j])
                    {
                        int tmp = sortedData[i];
                        sortedData[i] = sortedData[j];
                        sortedData[j] = tmp;
                    }
                }
            }
        }

        // Call Mean, mode and mean functions
        // display Histogram
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int[] freq = CalculateFrequencies();

            txtMean.Text = CalcMean().ToString("0.00");
            txtMode.Text = CalcMode(freq).ToString("0.00");
            txtMedian.Text = CalMedian().ToString("0.00");

            // Now we display the Chart
            this.histogramChart.Series.Clear();
            var series = this.histogramChart.Series.Add("Random Variable");
            for(int i=0; i<freq.Length; i++)
            {
                series.Points.AddXY(i, freq[i]);
            }
        }

        // Function to calculate the frequencies of the numbers
        private int [] CalculateFrequencies()
        {
            // new array
            int[] freq = new int[upperLimit + 1];

            for(int i=0; i<size; i++)
            {
                freq[rawData[i]] += 1;
            }

            return freq;
        }

        // Function to Calculate the mean of the data
        private double CalcMean()
        {
            double sum = 0; 
            for(int i=0; i<size; i++)
            {
                sum += rawData[i];
            }

            return sum / size;
        }

        private double CalMedian()
        {
            double median = 0;
            int mid = 0; 

            // check the size 
            if(size % 2 == 0)
            {
                mid = size / 2;

                median = (sortedData[mid] + sortedData[mid+1]) / 2.0;
            }
            else
            {
                mid = size / 2;
                median = sortedData[mid];
            }

            return median;
        }

        // Mode
        private int CalcMode(int [] frequenies)
        {
            // find max frequency
            int max = frequenies[0];
            int maxIndex = 0; 

            for(int i=0; i<frequenies.Length; i++)
            {
                if(max < frequenies[i])
                {
                    max = frequenies[i];
                    maxIndex = i;
                }
            }

            return maxIndex; // this is our mode
        }


    }
}
