using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFIrstModel.Entites
{
    public class StudentSubject
    {
        [Key,ForeignKey("StudentsOf"),Column(Order = 1 )]
        public int StudentId { get; set; }
        [Key, ForeignKey("SubjectOf"), Column(Order = 2 )]
        public int SubjectId { get; set; }
        public int Mark { get; set; }
        public virtual Students StudentsOf { get; set; }
        public virtual Subject SubjectOf { get; set; }
    }
}
