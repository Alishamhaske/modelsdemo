using System.ComponentModel.DataAnnotations;

namespace modelsdemo.Models
{
    public class Student
    {
        [Required (ErrorMessage ="std id is require")]
        [Display(Name ="Student Id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        [MinLength(5)]
        [Display(Name = "Student Name")]
        public string? Name { get; set; }

        [Required]
        [Display(Name = "Student Branch")]
        public string? Branch { get; set; }

        [Required]
        [Display(Name = "Student Persentge")]
        public double Persentage { get; set; }

        [Display(Name = "City")]
        public string? City { get; set; }

        [Required]
        [Display(Name = "Student Age")]
        [Range(18,60)]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Student Birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
    }
}
