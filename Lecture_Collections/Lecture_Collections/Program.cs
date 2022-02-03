using System;
using System.Collections.Generic;

namespace Lecture_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stuNames = new string[5];
            int[] stuAge = new int[5];
            double[] StudGradedbl = { 95.5, 90, 90.6, 94, 100 };
            stuNames[0] = "Mandar";
            stuNames[1] = "James";
            stuNames[2] = "Rita";
            stuNames[3] = "Cory";
            stuNames[4] = "Zack";

            //var numberofStu = stuNames.Length;
            //Console.WriteLine(stuNames.Length);
            //Array.Reverse(stuNames);
            //Array.Sort(stuNames);
            //Array.Sort(StudGradedbl);

            //string[] stunamescopy = new string[5];
            //Array.Copy(stuNames, stunamescopy, 5);

            //stunamescopy[4] = "Change Name";

            List<string> StuNamesList = new List<string>();
            StuNamesList.Add("Max");
            StuNamesList.AddRange(stuNames);
            int InList = StuNamesList.Count;
            



        }
    }
}
