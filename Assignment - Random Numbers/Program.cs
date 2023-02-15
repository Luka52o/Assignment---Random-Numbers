namespace Assignment___Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Inputted Range
            Random generator1 = new Random();
            int num1, num2;
            int[] numbers = new int[8];
            Console.WriteLine("Please a number to be used as the lowest number in your range:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now enter a number to be used as the highest in your range:");
            num2 = Convert.ToInt32(Console.ReadLine());

            // standard for loop convention: for (int i = start; i <= end; increment)
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = generator1.Next(num1, num2);

            }

        }
    }
}