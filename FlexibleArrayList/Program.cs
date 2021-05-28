using System;

namespace FlexibleArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new FlexibleIntList();
            while (true)
            {
                var number = AskForInt("Tall: ");
                numbers.AddNumber(number);
                numbers.Show();
            }
        }

        private static int AskForInt(string prompt)
        {
            Console.Write(prompt);
            var numberTxt = Console.ReadLine();
            var number = Convert.ToInt32(numberTxt);
            return number;
        }
    }
}
