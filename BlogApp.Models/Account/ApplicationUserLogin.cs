using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogApp.Models.Account
{
    public class ApplicationUserLogin
    {
        [Required(ErrorMessage = "Username is Required")]
        [MinLength(5, ErrorMessage = "Must be at least 5-20 characters")]
        [MaxLength(20, ErrorMessage = "Must be at least 5-20 characters")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [MinLength(10, ErrorMessage = "Must be at least 10-50 characters")]
        [MaxLength(50, ErrorMessage = "Must be at least 10-50 characters")]
        public string Password { get; set; }

    }
}
