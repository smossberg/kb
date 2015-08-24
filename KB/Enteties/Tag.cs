using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KB.Enteties
{
    public class Tag
    {
        [Key]
        public string Name { get; set; }
        public Tag(string Name)
        {
            this.Name = Name;
        }
    }
}