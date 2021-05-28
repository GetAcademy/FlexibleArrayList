using System;
using System.Collections.Generic;
using FlexibleArrayList.FlexibleArrayList;

namespace FlexibleArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers = new List<int>();
            //var numbers = new FlexibleIntList();
            var lists = new FlexibleList<FlexibleList<int>>();
            while (true)
            {
                var listNo = AskForInt("Hvilken liste vil du legge til i? ");
                while (lists.Count<listNo)
                {
                    lists.Add(new FlexibleList<int>());
                }

                var list = lists.Get(listNo-1);

                var number = AskForInt("Tall: ");
                list.Add(number);
                for(var i = 0; i < lists.Count; i++)
                {
                    Console.WriteLine($"Liste {i+1}");
                    lists.Get(i).Show();
                }
            }
        }

        private static int AskForInt(string prompt)
        {
            Console.Write(prompt);
            var numberTxt = Console.ReadLine();
            var number = Convert.ToInt32(numberTxt);
            return number;
        }

        private static string AskForString(string prompt)
        {
            Console.Write(prompt);
            var txt = Console.ReadLine();
            return txt;
        }
    }
}
