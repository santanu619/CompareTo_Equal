using System;

namespace CompareTo_Equal
{
    class Program
    {
        static void Main(string[] args)
        {
            string itemA = "Santanu";
            string itemB = "Mohapatra";
            string itemC = "Santanu";
            string itemD = "BridgeLabz";
            //String.Equals Function
            if (String.Equals(itemA, itemB))
                Console.WriteLine($"{itemA} and {itemB} are same.");
            else
                Console.WriteLine($"{itemA} and {itemB} are different");
            if (String.Equals(itemA, itemC))
                Console.WriteLine($"{itemA} and {itemC} are same.");
            else
                Console.WriteLine($"{itemA} and {itemC} are different");
            if (String.Equals(itemA, itemD))
                Console.WriteLine($"{itemA} and {itemD} are same.");
            else
                Console.WriteLine($"{itemA} and {itemD} are different");

            //CompareTo Function
            if (itemA.CompareTo(itemB) == 0)
                Console.WriteLine($"Both strings have same value.");
            else if (itemA.CompareTo(itemB) < 0)
                Console.WriteLine($"{itemA} precedes {itemB}.");
            else
                Console.WriteLine($"{itemA} follows {itemB}.");
            if (itemA.CompareTo(itemC) == 0)
                Console.WriteLine($"Both strings have same value.");
            else if (itemA.CompareTo(itemC) < 0)
                Console.WriteLine($"{itemA} precedes {itemC}.");
            else
                Console.WriteLine($"{itemA} follows {itemC}.");
            if (itemA.CompareTo(itemD) == 0)
                Console.WriteLine($"Both strings have same value.");
            else if (itemA.CompareTo(itemD) < 0)
                Console.WriteLine($"{itemA} precedes {itemD}.");
            else
                Console.WriteLine($"{itemA} follows {itemD}.");
        }
    }
}
