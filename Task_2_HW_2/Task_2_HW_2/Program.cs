using System;
using System.Collections.Generic;

namespace Task_2_HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> Typesofruits = new Dictionary<string, double>();
            Typesofruits.Add("Apples", 0.99);
            Typesofruits.Add("Oranges" ,0.5);
            Typesofruits.Add("Bananas", 0.5);
            Typesofruits.Add("Grapes", 2.99);
            Typesofruits.Add("Blueberries", 1.99);

            foreach (KeyValuePair<string,double> Fruit in Typesofruits)
            {
                Console.WriteLine($"{Fruit.Key}");
            }
            Console.WriteLine("Please enter the fruit you would like to buy from the above list ");
            string ans = Console.ReadLine();
            if (Typesofruits.ContainsKey(ans))
            {
                Console.WriteLine($" {ans} : {Typesofruits[ans].ToString("C")}");
            }
            else
            {
                Console.WriteLine("The input is invalid");
            }
        }
    }
}
