using System;
using System.Collections.Generic;
using System.Text;

namespace ClassCashGuys
{
public class Guy
    {
        public string Name { get; set; }
        public int Cash { get; set; }
        public void WriteMyInfo() 
        {
            Console.WriteLine(Name + " has " + Cash + "bucks.");
        }

        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: " + amount + "isn’t a valid ammount");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine(Name + "says: " + "I don’t have enough cash to give you " + amount);
                return 0;
            }
            Cash-=amount;
            return amount;
        }

        public void ReciveCash(int amount) 
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: " + amount + "isn’t an ammount I'll take");
            }
            else
            {
                Cash += amount;
            }
        }
    }
}
