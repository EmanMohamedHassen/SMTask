using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    [Table("tbl_Student")]
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Phone { get; set; }
        public string Address { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public int FacultyID { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }
        public Nullable<DateTime> ModificationDate { get; set; }
    }
}
