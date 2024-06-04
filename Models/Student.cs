using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIPatterenPractise.Models
{
    [Table("Student")]

    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string SName { get; set; }
        [Required]

        public int SPercentage { get; set; }
        [Required]

        public string City { get; set; }

    }

}
