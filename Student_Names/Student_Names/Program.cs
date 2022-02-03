using System;
using System.Collections.Generic;

namespace Student_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ListofStudents = new List<string>();
            string userinput;
            int lenghtofname = 0;
            double avg = 0;
            Console.WriteLine("Please enter the name of the 35 students or enter -1 to print the names already mentioned");

            do
            {

     
                Console.WriteLine("Please enter the name of Student ");
                userinput = Console.ReadLine();
                if (userinput!= "-1")
                {
                    ListofStudents.Add(userinput);
                }
              
        } while (ListofStudents.Count <=35 && userinput!= "-1");


            ListofStudents.Sort();
            
            foreach (var student in ListofStudents)
            {
            
                Console.WriteLine(student);
            }
            Console.WriteLine($"The number of students is {ListofStudents.Count}");

            for (int i = 0; i < ListofStudents.Count; i++)
            {
                 lenghtofname+= ListofStudents[i].Length;
                
                   
            }
            avg = lenghtofname / ListofStudents.Count;
            Console.WriteLine($"The avg lenght of name is {avg}");
    
        }
    }
}
