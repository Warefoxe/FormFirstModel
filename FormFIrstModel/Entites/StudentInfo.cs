using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFIrstModel.Entites
{
    [Table("tbl_StudentInfo")]
    public class StudentInfo
    {
        [Key]
        [ForeignKey("StudentsInfoOf")]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<Students> Students { get; set; }
        public Students StudentsInfoOf { get; set; }

    }
}
