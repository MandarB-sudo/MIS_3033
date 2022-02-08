using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_3_Hw_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the Customer ID");
            int ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the number of Cogs you would like to buy ");
            int cogamount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the number of Gears you would like to buy");
            int gearamount = Convert.ToInt32(Console.ReadLine());

            Receipt customer = new Receipt(ID, cogamount, gearamount);

            

                

        }
    }
}
