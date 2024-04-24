using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {


            Meth Math = new Meth();

            Console.WriteLine(Math.Ad(1,2));//Method for interger
            Console.WriteLine(Math.Ad(3.2m,4.2m));//Method for decimal
            Console.WriteLine(Math.Ad("5","6"));//Method for string


            Math M = new Math(); //Instiating Math class

            Console.WriteLine("Enter first number"); 
            
            int a = Convert.ToInt32(Console.ReadLine());//Input for first number
           
            Console.WriteLine("Enter second number");
            string b = Console.ReadLine();//Input for second number
            bool k = string.IsNullOrEmpty(b);// checking second number is null
            if(k == true)
            {
                Console.WriteLine(M.Addition(a));//If second nunber is null
            }
            else
            {
                Console.WriteLine(M.Addition(a,Convert.ToInt32(b)));//If second number is not null
            }
        }
    }
}
