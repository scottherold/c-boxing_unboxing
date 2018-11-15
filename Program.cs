using System;
using System.Collections.Generic;

namespace boxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> newList = new List<object>();
            newList.Add(7);
            newList.Add(28);
            newList.Add(-1);
            newList.Add(true);
            newList.Add("chair");

            int sum = 0;

            for (var i = 0; i < newList.Count; i++)
            {
                Console.WriteLine(newList[i]);
                if (newList[i] is int)
                {
                    sum = sum + Convert.ToInt32(newList[i]);
                }
            }

            // int sum = Convert.ToInt32(newList[0])+Convert.ToInt32(newList[1])+Convert.ToInt32(newList[2]);
            Console.WriteLine("The sum of the list's integers is {0}.", sum);
        }
    }
}
