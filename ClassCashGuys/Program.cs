using System;

namespace ClassCashGuys
{
    internal class Program
    {
        static void Main()
        {
            Guy joe = new Guy() { Name="Joe", Cash=150};
            Guy bob = new Guy() { Name = "Bob", Cash = 350 };

            while (true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.Write("Enter amount:");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;

                if (int.TryParse(howMuch, out int amount))
                {
                    Console.Write("Who should give cash: ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy == "Joe")
                    {
                        int cashGiven = joe.GiveCash(amount);
                        bob.ReciveCash(cashGiven);
                    }
                    else if (whichGuy == "Bob")
                    {
                        int cashGiven = bob.GiveCash(amount);
                        joe.ReciveCash(cashGiven);
                    }
                    else
                    {
                        Console.WriteLine("Joe or Bob ?");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount (or blank to exit)");
                }



            }

        }
    }
}
