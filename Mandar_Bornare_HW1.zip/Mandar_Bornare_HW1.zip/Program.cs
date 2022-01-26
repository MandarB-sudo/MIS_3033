using System;

namespace Mandar_Bornare_HW1.zip
{
    class Program
    {
        const double whole_sale_cogs_price = 79.99;
        const int whole_sale_gears_price = 250;
        const double normalmarkup = 0.15;
        const double discount_markup = 0.12;
        const double sales_tax = 0.089;
        static void Main(string[] args)
        {

            int cogs_quantity, gears_quanitity, Totalquantity = 0 ;
            double sales_total, sales_markup, after_markup_sales_total = 0, tax_total, discount,Total;
            Console.WriteLine("Please input the number of Cogs you would like to buy");
            string ans1 = Console.ReadLine();
            cogs_quantity = Convert.ToInt32(ans1);
            Console.WriteLine("Please input the number of Gears you would like to buy");
            string ans2= Console.ReadLine();
            gears_quanitity = Convert.ToInt32(ans2);

            Totalquantity = cogs_quantity + gears_quanitity;

            if (Totalquantity < 16 && cogs_quantity <= 10 && gears_quanitity <= 10)
            {
                sales_total = (cogs_quantity * whole_sale_cogs_price) + (gears_quanitity * whole_sale_gears_price);
                after_markup_sales_total = sales_total + sales_total * normalmarkup;
                   

            }
            else if (Totalquantity < 16 && cogs_quantity > 10 && gears_quanitity <= 10)
            {
                sales_total = (cogs_quantity * whole_sale_cogs_price) + (gears_quanitity * whole_sale_gears_price);
                after_markup_sales_total = sales_total + sales_total * discount_markup;
                    
            }
            else if (Totalquantity < 16 && cogs_quantity <=10 && gears_quanitity >10)
            {
                sales_total = (cogs_quantity * whole_sale_cogs_price) + (gears_quanitity * whole_sale_gears_price);
                after_markup_sales_total = sales_total + sales_total * discount_markup;

                    
            }
            else if (Totalquantity >=16 && cogs_quantity > 10 && gears_quanitity >10)
            {
                sales_total = (cogs_quantity * whole_sale_cogs_price) + (gears_quanitity * whole_sale_gears_price);
                after_markup_sales_total = sales_total + sales_total * discount_markup;
            }
            else if (Totalquantity >=16 && cogs_quantity <= 10 && gears_quanitity <=10)
            {
                sales_total = (cogs_quantity * whole_sale_cogs_price) + (gears_quanitity * whole_sale_gears_price);
                after_markup_sales_total = sales_total + sales_total * discount_markup;
            }
            else if (Totalquantity >=16 && cogs_quantity <=10 && gears_quanitity >10)
            {
                sales_total = (cogs_quantity * whole_sale_cogs_price) + (gears_quanitity * whole_sale_gears_price);
                after_markup_sales_total = sales_total + sales_total * discount_markup;
            }
            else if (Totalquantity >=16 && cogs_quantity >10 && gears_quanitity <=10)
            {
                sales_total = (cogs_quantity * whole_sale_cogs_price) + (gears_quanitity * whole_sale_gears_price);
                after_markup_sales_total = sales_total + sales_total * discount_markup;
            }
            tax_total = after_markup_sales_total * sales_tax;
            Total = after_markup_sales_total + tax_total;
            Console.WriteLine($" the subtotal of your order is {after_markup_sales_total} ");
            Console.WriteLine($"The tax on your order is {tax_total}");
            Console.WriteLine($"The Grand total of your order is {Total}");
        }
    }
}
