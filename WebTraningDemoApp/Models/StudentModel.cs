using System.ComponentModel.DataAnnotations;

namespace WebTraningDemoApp.Models
{
    public class StudentModel
    {

        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public DateOnly DateOfBirth { get; set; }
        [Required]
        public string Organization { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
