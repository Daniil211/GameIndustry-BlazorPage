namespace DbAccess.Models
{
    public class GameDeveloper
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string StudioDescription { get; set; }
        public IEnumerable<GameModel>? Games { get; set; }
    }
}
