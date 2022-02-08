using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Hw_2
{
    class Receipt
    {
        public int CustomerID { get; set; }
        public int CogQuantity { get; set; }
        public int GearQuantity { get; set; }
        public DateTime SaleDate { get; set; }
        private double SalesTaxPercent { get; set; }
        private double CogPrice { get; set; }
        private double GearPrice { get; set; }

        public Receipt()
        {
            CustomerID = 0;
            CogQuantity = 0;
            GearQuantity = 0;
            SaleDate = DateTime.Now;
            SalesTaxPercent = 0.0;
            CogPrice = 0.0;
            GearPrice = 0.0;
        }
        public Receipt(int id , int cog,int gear)
        {
            CustomerID= id;
            CogQuantity = cog;
            GearQuantity = gear;
        }

       
        public double CalculateTotal ()
        {
            double Total;
            Total = CalculateNetAmount() + CalculateTaxAmount();
            return Total;
        }
        public void PrintReceipt()
        {
            Console.WriteLine($" Customer ID: {CustomerID} \n  The no. of Cogs  :{CogQuantity} \n The no. of Gears : {GearQuantity} \n The Price of the order is {CalculateNetAmount().ToString("C")} \n" +
                $" The Tax applied is : {CalculateTaxAmount().ToString("C")} \n The Total price is : {CalculateTotal().ToString("C")} \n {SaleDate}");
                 
        }
        private double CalculateTaxAmount()
        {
            double SalesTaxTotal;
            SalesTaxTotal = CalculateNetAmount() * SalesTaxPercent;
            return SalesTaxTotal;
        }
        private double CalculateNetAmount()
        {
            const double standardmarkup = 0.15;
            const double discountmarkup = 0.125;
            int TotalQuantity = CogQuantity + GearQuantity;
            double netamount;
            if (CogQuantity > 10 || GearQuantity >10 || TotalQuantity >=16 )
            {
                netamount = CogQuantity * (CogPrice + discountmarkup * CogPrice) + GearQuantity * (GearPrice + discountmarkup * GearPrice);
                return netamount;
            }
            else
            {
                netamount = CogQuantity * (CogPrice + standardmarkup * CogPrice) + GearQuantity * (GearPrice + standardmarkup * GearPrice);
                return netamount;
            }


            
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
