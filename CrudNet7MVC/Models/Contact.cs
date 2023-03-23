using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CrudNet7MVC.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is required.")]        
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone Number is required.")]
        [DisplayName("Phone Numbner")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        public DateTime Date { get; set; }
    }
}
