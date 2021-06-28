using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogApp.Models.BlogComment
{
    public class BlogCommentCreate
    {
        public int BlogCommentID { get; set; }
        public int? ParentBlogCommentID { get; set; }
        public int BlogID { get; set; }
        [Required(ErrorMessage = "Content is Required")]
        [MinLength(50, ErrorMessage = "at least 50 characters")]
        [MaxLength(3000, ErrorMessage = "Exceeded 3000 characters")]
        public string Content { get; set; }
    }
}
