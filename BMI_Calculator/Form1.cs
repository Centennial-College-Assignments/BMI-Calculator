using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Devesh Kumar 
//Student Id 301117993 (Section - 004)
//Assignment 4

namespace BMI_Calculator
{
    /// <summary>
    /// This a partial BMI form class which executes events
    /// </summary>
    public partial class BMIForm : Form
    {
        public BMIForm()
        {
            InitializeComponent();
            bmiChartGridView.DataSource = BMIData.getBMIDataList();
        }

        //Calculate button event
       private void CalculateButton_Click(object sender, EventArgs e)
       {
            try
            {
                // Weight in kg
                double weight = GetWeight();

                // Height in cm
                double height = GetHeight();

                double bmi = BMIUtility.calculateBmi(weight, height);
                bmiTextBox.Text = Convert.ToString(Math.Round(bmi, 2));

                Gender gender = GetGender();

                double idealWeight = BMIUtility.calculateIdealBodyWeight(gender, height);
                recommendationTextBox.Text = $"Your ideal weight is {idealWeight}";

                List<BMIData> bmiDataList = BMIData.getBMIDataList();
                BMIData resultBmiData = GetBmiData(bmi, bmiDataList);

                resultsTextBox.Text = resultBmiData.Category;
                unfocusResultInDataGrid();
                focusResultInDataGrid(bmiDataList, resultBmiData);


            } catch(Exception ex)
            {
                MessageBox.Show("Exception occurred: " + ex.Message);
            }
        }

       //the method below will unhighlight all rows of data grid of BMI chart
       private void unfocusResultInDataGrid()
       {
           foreach (DataGridViewRow dataGridViewRow in bmiChartGridView.Rows)
           {
               dataGridViewRow.DefaultCellStyle.BackColor = Color.White;
           }
       }

       //the method below will highlight the BMI result in data grid
       private void focusResultInDataGrid(List<BMIData> bmiDataList, BMIData resultBmiData)
       {
           int resultIndex = bmiDataList.IndexOf(resultBmiData);
           bmiChartGridView.CurrentCell = this.bmiChartGridView[0, resultIndex];
           bmiChartGridView.Rows[resultIndex].DefaultCellStyle.BackColor = Color.Aquamarine;
       }

       //this method will find the appropriate BMI category based on BMI value
       private static BMIData GetBmiData(double bmi, List<BMIData> dataList)
       {
           IEnumerable<BMIData> bMiDataQuery =
               from bmiData in dataList
               where bmiData.BMI_Lower_Bound <= bmi && bmi < bmiData.BMI_Upper_Bound
               select bmiData;

           BMIData resultBmiData = bMiDataQuery.Any() ? 
                bMiDataQuery.First() : dataList[dataList.Count() - 1];

           return resultBmiData;
       }

       //this method would fetch the gender value entered in form 
       private Gender GetGender()
       {
           Gender gender = maleRadioButton.Checked
               ? Gender.MALE
               : (femalRadioButton.Checked ? Gender.FEMALE : throw new Exception("Gender selection cannot be ignored."));
           return gender;
       }

       //this method would fetch and validate the height value entered in form 
        private double GetHeight()
       {
            double height;
            try
            {
               height = Convert.ToDouble(heightTextBox.Text);
            }
            catch (Exception ex)
            {
               throw new Exception("Invalid value for height");
            }

            if (height <= 0)
            {
                throw new Exception("Height cannot be zero or less than zero");
            }

            if (heightComboBox.Text.Equals("inch"))
            {
                height = BMIUtility.convertInchToCentimeter(height);
            }

            return height;
       }

        //this method would fetch and validate the weight value entered in form 
        private double GetWeight()
       {
           double weight;
           try
           {
               weight = Convert.ToDouble(weightTextBox.Text);
           }
           catch (Exception)
           {
               throw new Exception("Invalid value for weight");
           }

           if (weight <= 0)
           {
               throw new Exception("Weight cannot be zero or less than zero");
           }
           if (weightComboBox.Text.Equals("lb"))
           {
               weight = BMIUtility.convertPoundToKilogram(weight);
           }

           return weight;
       }

        // this method will clear the form
       private void clearButton_Click(object sender, EventArgs e)
        {
            weightTextBox.Text = "";
            heightTextBox.Text = "";
            recommendationTextBox.Text = "";
            resultsTextBox.Text = "";
            bmiTextBox.Text = "";
        }
    }
}
