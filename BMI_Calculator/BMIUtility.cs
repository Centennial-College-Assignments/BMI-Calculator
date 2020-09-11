using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//Devesh Kumar 
//Student Id 301117993 (Section - 004)
//Assignment 4

namespace BMI_Calculator
{
    /// <summary>
    /// this class is used to store utility methods which are used to generate BMI and ideal weight
    /// </summary>
    public static class BMIUtility
    {
        // this method below will calculate and return BMI
        public static double calculateBmi(double weight, double height)
        {
            double bmi;
            bmi = (weight) / (height / 100 * height / 100);
            return bmi;
        }

        // this method below will calculate and return ideal body weight based on gender and height entered
        public static double calculateIdealBodyWeight(Gender gender, double height)
        {
            if (gender.Equals(Gender.MALE))
            {
                return 50 + (0.91 * (height - 152.4));
            }

            if (gender.Equals(Gender.FEMALE))
            {
                return 45.5 + (0.91 * (height - 152.4));
            }

            throw new Exception("Invalid gender type");
        }

        // this method below will accept weight in pounds and return in kg
        public static double convertPoundToKilogram(double weight)
        {
            return weight * 0.45359237;
        }

        // this method below will accept height in Inches and return in cm
        public static double convertInchToCentimeter(double height)
        {
            return height * 2.54;
        }
    }
}
