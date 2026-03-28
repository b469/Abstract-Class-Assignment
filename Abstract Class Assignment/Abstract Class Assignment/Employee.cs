using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment 
{
    public  class Employee:Person, IQuittable///Creating another Employee and have it inherit from the Person Class
                               
   
    {
        public int Id { get; set; } // Int Id to Employee
        

        public override void SayName() // Override the Abstract in Person
        {
            Console.WriteLine("Name:" + firsName + "  " + lastName); // It will show in Console "Sample" and "Studen"
        }


        public void Quittable(Employee employee)  //Interface is been apply to Employee Regulation       
        {
            
            throw new NotImplementedException();
        }




    }
}
