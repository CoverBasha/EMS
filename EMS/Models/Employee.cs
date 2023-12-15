using System.ComponentModel.DataAnnotations;
namespace EMS.Models
{
    public class Employee
    {
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "Email address")]
        [Required]
        [StringLength (30)]
        public string Email { get; set; }

        [Display(Name = "Phone number")]
        [Required]
        [StringLength (12)]
        public string Phone { get; set; }

        [Display(Name = "Department name")]
        [Required]
        [StringLength (50)]
        public string Department { get; set; }
    }
}
