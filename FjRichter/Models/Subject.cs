using System;
using System.Collections.Generic;

namespace FJRichter.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual List<Post> Posts { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}