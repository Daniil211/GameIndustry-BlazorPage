using System.ComponentModel.DataAnnotations;

namespace Application.Persistence.Models;

public class Genre
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    public virtual List<GameModel>? Games { get; set; }
}