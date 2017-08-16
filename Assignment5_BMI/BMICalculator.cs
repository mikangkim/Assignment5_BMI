using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Name : Mikang Kim
 * Student ID : 300921431
 * Date : August 15, 2017
 * Description : Assignment5 BMI Calculator
 * Version : 0.4 Actual Calculation work
 */
namespace Assignment5_BMI
{
    public partial class BMICalculator : Form
    {

        /// <summary>
        /// This is Private instance variables
        /// </summary>
        private double myHeight;
        private double myWeight;
        private double myBMI;

        /// <summary>
        /// This is Public Properties
        /// </summary>

        // Height
        public double height
        {
            get
            {
                return this.myHeight;
            }

            set
            {
                this.myHeight = value;
            }

        }

        // Weight
        public double weight
        {
            get
            {
                return this.myWeight;
            }

            set
            {
                this.myWeight = value;
            }

        }

        // BMI value
        public double BMI
        {
            get
            {
                return this.myBMI;
            }

            set
            {
                this.myBMI = value;
            }

        }

        public BMICalculator()
        {
            InitializeComponent();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightLabel.Text = "My Height(in):";
            WeightLabel.Text = "My Weight(lb):";
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            HeightLabel.Text = "My Height(m):";
            WeightLabel.Text = "My Weight(kg):";
        }

        private void noticeBMI(double myBMI)
        {
            if (myBMI < 18.5)
            {
                BMIScaleTextBox.Text = "Notice: Underweight";
            }

            else if (myBMI >= 25 && myBMI <= 29.9)
            {
                BMIScaleTextBox.Text = "Notice: Overweight";
            }

            else if (myBMI > 30)
            {
                BMIScaleTextBox.Text = "Notice: Obese";
            }

            else if (myBMI >= 18.5 && myBMI <= 24.9)
            {
                BMIScaleTextBox.Text = "Notice: Normal weight";
            }
        }
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            double myHeight = double.Parse(HeightTextBox.Text);
            double myWeight = double.Parse(WeightTextBox.Text);

            if (RadioButton.Checked)
            {
                myBMI = (myWeight * 703) / (myHeight * myHeight);
                BMIResultTextBox.Text = Math.Round(myBMI, 1).ToString();
                noticeBMI(myBMI);
            }
            else if (RadioButton1.Checked)
            {
                myBMI = myWeight / (myHeight * myHeight);
                BMIResultTextBox.Text = Math.Round(myBMI, 1).ToString();
                noticeBMI(myBMI);
            }

        }


        /// <summary>
        /// Clearing user inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {

            HeightTextBox.Clear();
            WeightTextBox.Clear();
            BMIResultTextBox.Clear();
            BMIScaleTextBox.Clear();

        }
        /// <summary>
        /// Showing the notice message after the calculation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMIScaleTextBox_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BMIResultTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void BMICalculator_Load_1(object sender, EventArgs e)
        {

        }

        private void HeightLabel_Click_1(object sender, EventArgs e)
        {

        }
 
    }
}
