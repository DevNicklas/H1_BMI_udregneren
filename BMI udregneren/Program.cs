using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_udregneren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Loops until another key than R is pressed when asked
            do
            {

                // Variables which gets their value from the user
                float weight = Question("Please enter your weight in kg.\nExample: 65");
                float height = Question("Please enter your height in meters.\nExample: 1.83");

                Console.Clear();

                // Calculating BMI and rounds to 1 decimal
                double bmi = Math.Round(weight / (Math.Pow(height, 2)), 1);
                Console.WriteLine("Your BMI is " + bmi + "\n\nPress R for calculating a new BMI, or any other key for closing the program");
            } while (Console.ReadKey().Key == ConsoleKey.R);
        }

        /// <summary>
        /// Asks a user a certain question
        /// </summary>
        /// <param name="text">question which the user will be asked</param>
        /// <returns>User input as an float</returns>
        static float Question(string text)
        {
            Console.Clear();
            float userInput = 0;

            // Loops until the user enters an float value
            do
            {
                Console.WriteLine(text);
            } while (!float.TryParse(Console.ReadLine(), out userInput));
            return userInput;
        }
    }
}
