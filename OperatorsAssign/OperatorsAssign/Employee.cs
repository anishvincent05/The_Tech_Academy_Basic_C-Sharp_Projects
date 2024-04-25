using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAssign
{
   public class Employee
    {
       //Declaring properties
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Overloading comparing operator
        public static bool operator== (Employee Emp1,Employee Emp2)
        {
            if (Emp1.ID==Emp2.ID && Emp1.FirstName==Emp2.FirstName && Emp1.LastName == Emp2.LastName)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Overloading comparing operator pair
        public static bool operator !=(Employee Emp1, Employee Emp2)
        {
            if (Emp1.ID != Emp2.ID || (Emp1.FirstName != Emp2.FirstName && Emp1.LastName != Emp2.LastName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
