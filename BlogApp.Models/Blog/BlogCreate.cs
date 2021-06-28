using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogApp.Models.Blog
{
    public class BlogCreate
    {
        public int BlogID { get; set; }

        [Required(ErrorMessage = "Title is Required")]
        [MinLength(5, ErrorMessage = "at least 5 characters")]
        [MaxLength(30, ErrorMessage = "at most 30 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is Required")]
        [MinLength(50, ErrorMessage = "at least 50 characters")]
        [MaxLength(3000, ErrorMessage = "Exceeded 3000 characters")]
        public string Content { get; set; }
        public int? PhotoID { get; set; }
    }
}
