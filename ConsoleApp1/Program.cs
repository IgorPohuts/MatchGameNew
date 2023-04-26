using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number of cards:");
            string line = Console.ReadLine();
            if (int.TryParse(line,out int numberOfCards))

            {
                foreach (var card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Enter a valid number");
            }

        }
    }
}
