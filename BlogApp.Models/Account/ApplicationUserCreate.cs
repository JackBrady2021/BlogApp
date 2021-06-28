using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Models.Account
{
    public class ApplicationUserCreate : ApplicationUserLogin
    {
        [MinLength(10, ErrorMessage = "Must be at least 10-30 characters")]
        [MaxLength(30, ErrorMessage = "Must be at least 10-30 characters")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [MinLength(30, ErrorMessage = "Maximum 30 characters")]
        [EmailAddress(ErrorMessage = "Must be a valid email")]
        public string Email { get; set; }
    }
}
