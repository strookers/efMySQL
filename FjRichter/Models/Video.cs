namespace FJRichter.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Embed { get; set; }
        public virtual Post Post { get; set; }
        public int PostId { get; set; }
    }
}