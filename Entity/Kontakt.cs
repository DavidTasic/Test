using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Kontakt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KontakId { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string Brojtelefona { get; set;  }
        public Student Student { get; set; }
        public int StudentId { get; set; }


    }
}
