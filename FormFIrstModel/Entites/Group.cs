using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFIrstModel.Entites
{
    [Table("tbl_Group")]
    public class Group
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required,ForeignKey("TeacherOf")]
        public int KuratorID { get; set; }

        public virtual Teacher TeacherOf { get; set; }

        public virtual ICollection<Students> StudentOf { get; set; }
    }
}
