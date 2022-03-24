namespace Course.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public byte[] Image { get; set; }
        public int rated { get; set; } 
        public float rating { get; set; }
        public int sum { get; set; }
    }
}
