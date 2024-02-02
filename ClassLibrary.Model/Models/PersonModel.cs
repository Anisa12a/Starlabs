using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model.Models
{
    public class PersonModel
    {
        public int PersonId { get; set; }

        [Required(ErrorMessage = "Person's first name is required!")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Person's first name must be between 2 and 20 characters!")]
        public string PersonFirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Person's last name is required!")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Person's last name must be between 2 and 20 characters!")]
        public string PersonLastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Person's email address is required!")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [StringLength(50, MinimumLength = 12, ErrorMessage = "This format is invalid for the email address!")]
        public string PersonEmail { get; set; } = string.Empty;

        [Required(ErrorMessage = "Date of birth is required!")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string PhoneNumber { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true; 
    }
}

