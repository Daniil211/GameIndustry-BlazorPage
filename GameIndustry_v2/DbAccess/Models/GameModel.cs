﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Persistence.Models
{
    public class GameModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3), MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MinLength(3), MaxLength(50)]
        public string Description { get; set; }

        public bool InSale { get; set; }

        public string? GamePlayVideo { get; set; }

        public virtual List<Genre>? Genres { get; set; }
        
        [Required]
        public DateTime? ReleaseDate { get; set; }

        public string Image { get; set; }

        public int? DeveloperId { get; set; }

        public virtual GameDeveloper? Developer { get; set; }

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
