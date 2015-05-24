using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KB.Enteties
{
    public class Article
    {
        public int Id { get; set; }

        [Required]
        [Range(3,100)]
        public string Title { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        [Required]

        public string Content { get; set; }
        public Author Author { get; set; }
        [Required]
        public Category Category { get; set; }

    }
}