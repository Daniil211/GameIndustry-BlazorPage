using System.ComponentModel.DataAnnotations;

namespace GameIndustry_v2.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public List<GamesGenres> GamesGenres { get; set; } = new List<GamesGenres>();
    }
}
