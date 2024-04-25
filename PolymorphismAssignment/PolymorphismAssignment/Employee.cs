using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAssignment
{
   public class Employee : Person, IQuittable //Inheriting class and interface
    {
        public Employee()
        {
            Id = "00";
        }
        public string Id { get; set; }
    public void Quit() //implementing Interface
    {
        throw new NotImplementedException();
    }
    }
}
