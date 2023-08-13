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
                Console.WriteLine("Your BMI is " + bmi);
                WriteGroup(bmi);

                Console.WriteLine("\nPress R for calculating a new BMI, or any other key for closing the program");
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

        /// <summary>
        /// Writes the specific group which fits to the bmi <paramref name="bmi"/>
        /// </summary>
        /// <param name="bmi">bmi of the user</param>
        static void WriteGroup(double bmi)
        {
            // Body weight dificit (Blue area)
            if(bmi > 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("You are in the group: Body weight deficit");
            }

            // Normal body weight (Dark green area)
            else if(bmi > 24)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("You are in the group: Normal body weight");
            }

            // Weight over (Light green area)
            else if (bmi > 30)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You are in the group: Weight over");
            }

            // Obesity first degree (Yellow area)
            else if (bmi > 35)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You are in the group: Obesity first degree");
            }

            // Obesity second degree (Orange area)
            else if (bmi > 40)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("You are in the group: Obesity second degree");
            }

            // Obesity third degree (Dark red area)
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You are in the group: Obesity third degree");
            }

            // Resets color
            Console.ResetColor();
        }
    }
}
