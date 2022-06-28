namespace template_csharp_reviews_site.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int VideoGameId { get; set; }
        public virtual VideoGame VideoGame { get; set; }
        public string User { get; set; }
        public string Comment { get; set; }
        public string ReviewBody { get; set; }
        public int Rating { get; set; }
        public DateTime PublishDate { get; set; }

    }
}
