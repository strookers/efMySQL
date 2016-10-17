using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FjRichter.Models;
using FJRichter.Models;

namespace FjRichter.ViewModels
{
    public class BlogViewModel
    {
        public Content Content { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}