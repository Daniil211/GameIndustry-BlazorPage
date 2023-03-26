using System.Security.AccessControl;

namespace GameIndustry_v2.Models
{
    public class GameModel
    {
        public int Id { get; set; } = 1;

        public string Name { get; set; }

        public string Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Image { get; set; }
    }
}
