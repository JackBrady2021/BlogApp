using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Models.BlogComment
{
    public class BlogComment
    {
        public string Username { get; set; }
        public int ApplicationUserID { get; set; }

        public DateTime PublishDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
