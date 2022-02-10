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
            List<Receipt> CsReceipt = new List<Receipt>();
            string ans = "";
            do
            {
                Console.WriteLine("Please input the Customer ID");
                int ID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please input the number of Cogs you would like to buy ");
                int cogamount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please input the number of Gears you would like to buy");
                int gearamount = Convert.ToInt32(Console.ReadLine());

                Receipt customer = new Receipt();

                customer.CogQuantity = cogamount;
                customer.CustomerID = ID;
                customer.GearQuantity = gearamount;

                customer.PrintReceipt();
                CsReceipt.Add(customer);

                Console.WriteLine("Would you like to print another order ? y/n");
                ans = Console.ReadLine();
               
            } while (ans.ToLower() == "y");

            Console.WriteLine("How would you like to print the reciept ?\n by customerID enter A\n by day enter B\n by hishest total enter C");
            ans = Console.ReadLine();
            if (ans.ToUpper() == "A")
            {
                Console.WriteLine("Please enter customer ID");
                int cusans = Convert.ToInt32(Console.ReadLine());
                
                foreach (var item in CsReceipt)
                {

                    if (cusans == item.CustomerID)
                    {
                        Console.WriteLine(item);
                    }
                    
                }
            }
             if (ans.ToUpper() == "B")
            {
                Console.WriteLine("Please enter the day:");
                ans = Console.ReadLine();
                DateTime datetimeobj = new DateTime();
                bool isvalid = DateTime.TryParse(ans, out datetimeobj);
                foreach (var item in CsReceipt)
                {
                    if (datetimeobj.Day == item.SaleDate.Day)
                    {
                        Console.WriteLine(item);
                    }
                }
               
            }
            if (ans.ToUpper() == "C")
            {
                double max = 0;
                foreach (var item in CsReceipt)
                {
                    if (item.CalculateTotal() > max)
                    {
                        max = Convert.ToDouble(item);
                       // I got stuck here as I was confused about how to convert the item to double.
                       
                    }
                    Console.WriteLine(item);
                }
                
            }
           

           


            

                

        }
    }
}
