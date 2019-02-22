using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFIrstModel.Entites
{       
    [Table("tbl_Students")]
    public class Students
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Course { get; set; }


        [Required,ForeignKey("GroupOf")]
        public int GroupId {get; set; }

        public virtual Group GroupOf { get; set; }

        public StudentInfo StudentInfo { get; set; }
        
    }
}
