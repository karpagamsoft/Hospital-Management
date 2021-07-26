using HospitalManagement.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagement.Models
{
    public class User
    {
        public Guid Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [UserValidate(Allowed = new string[] { "Admin", "Patient", "Doctor" }, ErrorMessage = "You User Role are invalid")]
        public string UserRole { get; set; }

        public string Emailid { get; set; }
        public string PhoneNo { get; set; }

        public DateTime AddedOn { get; set; }
    }
}
