using HospitalManagement.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagement.Models
{
    public class UserType
    {
        public Guid Id { get; set; }

        [Required]
        public string UserTypeName { get; set; }

        public DateTime AddedOn { get; set; }
    }
}
