using System.ComponentModel.DataAnnotations;
namespace EMS.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength (30)]
        public string Email { get; set; }
        [Required]
        [StringLength (12)]
        public string Phone { get; set; }
        [Required]
        [StringLength (50)]
        public string Department { get; set; }

        public Employee(string Name,string Email,string Phone,string Department)
        {
            this.Name = Name;
            this.Email = Email;
            this.Phone = Phone;
            this.Department = Department;
        }
    }
}
