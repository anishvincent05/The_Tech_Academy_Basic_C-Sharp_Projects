using System;
using System.Collections.Generic;
using System.Text;

namespace MethodAssignment
{
    public class Meth

    {   
        public  int Ad(int num1 , int num2)// Method for adding integer
        {
            return num1 + num2;
        }
        public  int Ad( decimal num1, decimal num2)//Overloaded method for decimal
        {
            return Convert.ToInt32(num1 * num2);
        }
        public  int Ad(string num1, string num2)//Overloaded method for  string
        {
            int c = Convert.ToInt32(num1); //Converting string to integer
            int d = Convert.ToInt32(num2);//Converting string to integer
            return c - d;
        }
    }
}
