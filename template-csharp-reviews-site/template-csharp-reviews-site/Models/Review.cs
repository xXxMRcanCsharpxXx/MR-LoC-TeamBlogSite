namespace template_csharp_reviews_site.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Name { get; set; }
        VideoGame videoGame;
        public string User;
        public string Comment;
        public int Rating;

    }
}
