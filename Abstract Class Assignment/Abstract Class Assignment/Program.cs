using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
   public class Program
    {
        static void Main(string[] args)
        {
            // In the Main method. instantiate an Employee object
            Employee sam = new Employee() { firsName = "Sample", lastName = "Student" };
            sam.SayName(); // Call the SayName method on the Object
            Console.ReadLine();//Show on Console


        }
    }
}
