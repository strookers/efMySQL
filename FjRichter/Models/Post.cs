using System;
using System.Collections.Generic;

namespace FJRichter.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public virtual List<Picture> Pictures { get; set; }
        public virtual List<Video> Videos { get; set; }
        public virtual List<Audio> Audios { get; set; }
        public virtual Subject Subject { get; set; }
        public int SubjectId { get; set; }
    }
}