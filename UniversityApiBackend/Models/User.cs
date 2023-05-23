using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.Models
{
    public class User : BaseEntity
    {
        [System.ComponentModel.DataAnnotations.Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [System.ComponentModel.DataAnnotations.Required, StringLength(100)]
        public string LastName { get; set; } = string.Empty;
        [System.ComponentModel.DataAnnotations.Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [System.ComponentModel.DataAnnotations.Required]
        public string Password { get; set; } = string.Empty;
    }
}
