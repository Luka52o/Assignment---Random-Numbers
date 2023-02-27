using System.ComponentModel.DataAnnotations;

namespace Assignment___Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Inputted Range
            Random generator1 = new Random();
            double min, max;
            int[] numbers = new int[8];

            Console.WriteLine("Please a number to be used as the lowest number in your range:");
            while (!double.TryParse(Console.ReadLine(), out min))
            {
                Console.WriteLine("Please enter a valid number");
            }

            Console.WriteLine("Now enter a number to be used as the highest in your range:");
            Double.TryParse(Console.ReadLine(), out max);
            while (max < min)
            {
                Console.WriteLine("Please enter a maximum that is greater than the inputted minimum:");

                while (!double.TryParse(Console.ReadLine(), out max))
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }

            Console.WriteLine("Your random numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (int)Convert.ToDouble(generator1.NextDouble() * (max - min) + min);
                Console.Write($" {numbers[i]} ");
            }
            Console.WriteLine();


            // Dice Roller
            Random dice = new Random();
            int roll1, roll2;

            Console.WriteLine("Press ENTER to roll two dice");
            Console.ReadLine();
            roll1 = dice.Next(1, 7);
            roll2 = dice.Next(1, 7);
            Console.WriteLine("You rolled a " + roll1 + " and a " + roll2);
            Console.WriteLine("The sum of your rolls is " + (roll1 + roll2));
            Console.ReadLine();
            Console.WriteLine();


            // Random Decimal Numbers 
            int digits;
            Random decGenerator = new Random();
            double[] ranDecimals = new double[3];
            Console.WriteLine("The program will now generate 3 random decimal numbers from the range given earlier. How many decimal places ");
            Console.WriteLine("would you like to be used?");
            while (!Int32.TryParse(Console.ReadLine(), out digits))
            {
                Console.WriteLine("Please enter a valid integer number");
            }
            while (digits < 0 || digits > 15)
            {
                Console.WriteLine("Please enter a number between 0 and 15 inclusive");
                Int32.TryParse(Console.ReadLine(), out digits);
            }
            Console.WriteLine("Random decimal values: ");
            Convert.ToDouble(min);
            Convert.ToDouble(max);

            for (int i = 0; i < ranDecimals.Length; i++)
            {
                Console.Write(Math.Round(decGenerator.NextDouble() * (max - min) + min, digits) + " ");
            }
        }
    }
}