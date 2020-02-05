using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Weight in Pounds");
            string userWeight = Console.ReadLine();
            int intWeight = Int32.Parse(userWeight);
            Console.Write("Enter Height in Inches");
            string userHeight = Console.ReadLine();
            int intHeight = Int32.Parse(userHeight);
            int result = intWeight / intHeight ^ 2;
            Console.WriteLine("Your BMI is "  + result);  
            Console.ReadLine();
            if (result < 18.5)
        {
                Console.WriteLine("Your BMI indicates you are Underweight");
           
             
            }
            
        }
    }
}
