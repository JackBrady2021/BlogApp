using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Models.Account
{
    public class ApplicationUser
    {
        public int ApplicationUserID { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
