namespace template_csharp_reviews_site.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string name;
        public string Studio;
        //Platform Platform;
        //Rating Rating;
        //Genre Genre;
        List<Review> Reviews;

        public VideoGame()
        {

        }

        //public Enum Platform {
        //Xbox,
        //Playstation,
        //PC, 
        //NTSwitch
        //}
        //public Enum Rating {
        //E,
        //T,
        //M,
        //RP
        //}
        //public Enum Genre {
        //Action,
        //Adventure,
        //FPS,
        //TPS
        //}

    }
}
