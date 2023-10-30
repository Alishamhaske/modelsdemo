using System.ComponentModel.DataAnnotations;

namespace modelsdemo.Models
{
    public class Employee: IValidatableObject


    {
        [Required(ErrorMessage ="emp ID is required")]
        [Display(Name="Emp ID")]
    public int EmpId { get; set; }

        [Required]
        [Display(Name="Employee Name")]
        [MaxLength(40)]
        [MinLength(4)]
        public string? Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? EmailId { get; set; }
        [Required]
        public double Salary { get; set; }
        [Required]
        [Range(18,60)]
        public int Age { get; set; }

        [Required]
        [Display(Name ="emp Birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }



        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Required]
        [Compare("Password",ErrorMessage="Password does not match")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var PName = new[] { "Dob" };
            if (Dob > DateTime.Now)
            {
                yield return new ValidationResult("Date of birth can not be in future", PName);
            }
            if (Dob < DateTime.Now.AddYears(-100))
            {
                yield return new ValidationResult("Date of birth can not be in too past", PName);
            }
        }




    }
}
