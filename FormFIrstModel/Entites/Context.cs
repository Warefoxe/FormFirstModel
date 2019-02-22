using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFIrstModel.Entites
{
    public class Context:DbContext
    {
        public Context():base("StudentsDB")
        {

        }
        public DbSet<Students> Students2 { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<StudentInfo> studentInfos { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
    }
}
