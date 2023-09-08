

namespace sampleAPI.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("adminData")]
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [Column("adminName")]
        public string Name { get; set; }
        [Column("adminEmail")]
        public string Email { get; set; }
        public DateTime createdAt { get; set; }
        public int createdBy { get; set; }
        //public DateTime updatedAt { get; set; }
        public int updatedBy { get; set; }
       // public Int16 isSuperAdmin { get; set; }

    }
}