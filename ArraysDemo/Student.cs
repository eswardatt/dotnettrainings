using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    [Table("StudentData")]
    class Student
    {
        [Key]
        public int Id { get; set; }

        [Column("StudentName")]
        public string Name { get; set; }
        public string Email { get; set; }
        public double AnnualFee { get; set; }

        public bool Feepaid { get; set; }

        public DateTime JoinedDate { get; set; }
    }
}
