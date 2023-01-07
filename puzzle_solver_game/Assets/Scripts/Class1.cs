using System;
namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            string codeToBreak = "";
            int charactersLength = 4;
            string[] numbers = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            for (int i = 0; i <= charactersLength - 1; i++)
                {
                   var random = new Random();
                   int idx = random.Next(numbers.Length);
                   codeToBreak += numbers[idx];
            }
            Console.WriteLine(codeToBreak);
        }
    }
}