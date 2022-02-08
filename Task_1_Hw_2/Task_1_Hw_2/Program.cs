using System;

namespace Task_1_Hw_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "Apples", "Oranges", "Bananas", "Grapes", "Blueberries" };
            double[] fruitprices = { 0.9, 0.5, 0.5,2.99, 1.99};

            Console.WriteLine("Please input the fruits you would like to buy ");

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine($"{fruits[i]}");
            }

            string ans = Console.ReadLine();
            if (ans.ToLower() != "apples" && ans.ToLower() != "oranges" && ans.ToLower() !="grapes" && 
                ans.ToLower() != "blueberries")
            {
                Console.WriteLine("The input is invalid");
            }
            else
            {
                for (int i = 0; i < fruits.Length; i++)
                {
                    if (ans == fruits[i])
                    {
                        Console.WriteLine($"{fruits[i]} : {fruitprices[i].ToString("C")}");
                    }
                    
                }
            }


        }
    }
}
