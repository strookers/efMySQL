using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FjRichter.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string Head { get; set; }
        public string Text { get; set; }
        public DateTime Updated { get; set; }
    }
}