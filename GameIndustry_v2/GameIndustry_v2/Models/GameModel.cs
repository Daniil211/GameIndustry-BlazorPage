using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace GameIndustry_v2.Models
{
    public class GameModel
    {
        public int Id { get; set; } = 1;
        [Required]
        [MinLength(3), MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MinLength(3), MaxLength(50)]
        public string Description { get; set; }
        public bool InSale { get; set; }
        public string GamePlayVideo { get; set; }

        public int GenreId { get; set; }
        [Required]
        public DateTime? ReleaseDate { get; set; }

        public string Image { get; set; }

        public string ShortName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Name))
                    return null;
                if(Name.Length > 60)
                    return Name.Substring(0, 57) + "...";
                else
                    return Name;
            }
        }
    }
}
