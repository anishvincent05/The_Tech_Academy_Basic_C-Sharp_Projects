using System;

namespace Package_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");//Title
            Console.WriteLine("Please enter the package weight");//Package weight
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)//Checking package weight is grater than 50
            {
                Console.WriteLine("Package too heavy to be shepped via Package Express. Have a good day");
            }
            Console.WriteLine("Please enter the package width");//Package wudth
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height");//Package  height
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length");//Package length
            int length = Convert.ToInt32(Console.ReadLine());
            if ((width+height+length) > 50)//Checking package total dimension is greater than 50
            {
                Console.WriteLine("Package too heavy to be shepped via Package Express. Have a good day");
            }
            else//Displaying total shipping cost for package if total dimension is less than 50
            {
                Console.WriteLine("Your estimated total for shipping this package is : $" + (width * height * length * weight / 100));
                Console.WriteLine("Thank you");
            }
        }   
    }   
}
