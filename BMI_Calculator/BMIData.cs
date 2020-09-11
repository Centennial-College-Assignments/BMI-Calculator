using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Devesh Kumar 
//Student Id 301117993 (Section - 004)
//Assignment 4


namespace BMI_Calculator
{
    /// <summary>
    /// this class is used to store BMI chart values
    /// </summary>
    class BMIData
    {
        public string Category { get; set; }
        public double BMI_Lower_Bound { get; set; }
        public double BMI_Upper_Bound { get; set; }

        private List<BMIData> BMIDataList = new List<BMIData>();



        public BMIData(string category, double lower, double upper)
        {
            Category = category;
            BMI_Lower_Bound = lower;
            BMI_Upper_Bound = upper;
        }

        // Given below is a method which will initialize the BMI list data
        public static List<BMIData> getBMIDataList()
        {
            List<BMIData> bMIDataList = new List<BMIData>(5);
            BMIData data1 = new BMIData("Severe Thinness", 0, 16);
            BMIData data2 = new BMIData("Moderate Thinness", 16, 17);
            BMIData data3 = new BMIData("Mild Thinness", 17, 18.5);
            BMIData data4 = new BMIData("Normal", 18.5, 25);
            BMIData data5 = new BMIData("Overweight", 25, 30);
            BMIData data6 = new BMIData("Obese Class I", 30, 35);
            BMIData data7 = new BMIData("Obese Class II", 35, 40);
            BMIData data8 = new BMIData("Obese Class III", 40, 99);

            bMIDataList.Add(data1);
            bMIDataList.Add(data2);
            bMIDataList.Add(data3);
            bMIDataList.Add(data4);
            bMIDataList.Add(data5);
            bMIDataList.Add(data6);
            bMIDataList.Add(data7);
            bMIDataList.Add(data8);
            return bMIDataList;
        }

        // This method is used to compare and return a bool
        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }

            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            BMIData other = (BMIData) obj;

            if (!Category.Equals(other.Category))
            {
                return false;
            }

            if (!BMI_Lower_Bound.Equals(other.BMI_Lower_Bound))
            {
                return false;
            }

            if (!BMI_Upper_Bound.Equals(other.BMI_Upper_Bound))
            {
                return false;
            }

            return true;
        }
    }
}
