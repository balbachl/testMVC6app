using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace testMVCapp.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Display(Name = "Zipcode")]
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        public string Email { get; set; }

    }
}
