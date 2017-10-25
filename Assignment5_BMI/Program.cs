﻿using System;
using System.Collections.Generic;
using System.Linq;
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
    static class Program
    {
        public static BMICalculator BMICalculator;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculator());
            Console.Write("Hello world!");
        }
    }
}
