using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Models.Blog
{
    public class Blog
    {
        public string Username { get; set; }
        public int UserID { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
