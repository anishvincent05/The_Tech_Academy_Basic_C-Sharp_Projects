using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodeFirstStudent.Program;

namespace CodeFirstStudent
{
    public class SchoolContext : System.Data.Entity.DbContext
    {
        public SchoolContext() : base()
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

    }
}
