using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> Emp = new List<Employees>() 
            {
                new Employees(){ID=1,FirstName="Danish",LastName="Anish"},
                new Employees(){ID=2,FirstName="Dani",LastName="Anish"},
                new Employees(){ID=3,FirstName="Ana",LastName="Jacon"},
                new Employees(){ID=4,FirstName="Dinesh",LastName="Thomas"},
                new Employees(){ID=5,FirstName="Tancy",LastName="Chi"},
                new Employees(){ID=6,FirstName="Hanna",LastName="Varghese"},
                new Employees(){ID=7,FirstName="Anu",LastName="Peter"},
                new Employees(){ID=8,FirstName="Mark",LastName="Antony"},
                new Employees(){ID=9,FirstName="Shibu",LastName="Paul"},
                new Employees(){ID=10,FirstName="Joe",LastName="Johnson"}
            };
            List<Employees> Emp2 = Emp.Where(x => x.FirstName == "Joe").ToList();//Lambda Expressiuon

            Console.WriteLine(Emp2[0].FirstName);
            
        }
    }
}
