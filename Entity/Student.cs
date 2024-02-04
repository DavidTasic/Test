using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        public string Name { get; set; }    
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string index { get; set; }

        public virtual Kontakt Kontakt { get; set; }    
    }
}
