﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogApp.Models.Account
{
    public class ApplicationUserIdentity
    {
        public int ApplicationUserID { get; set; }

        public string Username { get; set; }

        public string NormalizedUsername { get; set; }

        public string Email { get; set; }

        public string NormalizedEmail { get; set; }

        public string Fullname { get; set; }

        public string PasswordHash { get; set; }

    }
}
