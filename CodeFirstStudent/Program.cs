using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace CodeFirstStudent
{
    class Program
    {
      
       
       

        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill" };
                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
