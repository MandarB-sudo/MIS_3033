using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS3033_Student
{
    public class Student 
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Id { get; set; }
        public double  Gpa { get; set; }

        public Student( string f,string l, string id)
        {
            this.Firstname = f;

            this.Lastname = l;
           this.Id = Id;
        }
        public override string ToString()
        {
            string message = string.Format($" name :{Firstname} {Lastname}, id: {Id}");
            return message;
        }
        public static char Getdoublegrade(double grade)
        {
            if (grade>= 90)
            {
                return 'A';
            }
            else if (grade >= 80)
            {
                return 'B';
            }
            else if (grade >=70)
            {
                return 'C';

            }
            else if (grade >=60)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }

            
        }
    }
}

