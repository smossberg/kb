﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KB.Enteties
{
    public class Article
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public string Content { get; set; }
        public Author Author { get; set; }
       
        public Category Category { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}