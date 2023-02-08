namespace VideoGamesAPI.Models
{
    public class GameModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Genre { get; set; }
        public string? Developer { get; set; }
        public string? Publisher { get; set; }
        public double? Price { get; set; }
    }
}
