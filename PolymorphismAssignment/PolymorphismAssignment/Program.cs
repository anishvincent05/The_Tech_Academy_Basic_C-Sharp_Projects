using System;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
        IQuittable quit = new Employee(); //Polymorphism
            quit.Quit();//Calling method

            Employee Emp = new Employee();// Instantiate Employee class
            Emp.FirstName = "Anish";
            Emp.LastName = "Vincent";
            Emp.Id = "01";
            Emp.SayName();
            Console.WriteLine(":" + Emp.Id);
        }
    }
}
