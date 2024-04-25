using System;

namespace OperatorsAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp1 = new Employee() { ID = 01 ,FirstName="Anish",LastName="Vincent"};//Employee 1
            Employee Emp2 = new Employee() { ID = 02, FirstName = "Alwyn", LastName = "Vincent" };//Employee 2

            //Comparing Employees 
            if (Emp1==Emp2)
            {
                Console.WriteLine("Same Employees");

            }
            else
            {
                Console.WriteLine("Not Same Employees");
            }
            

        }
    }
}
