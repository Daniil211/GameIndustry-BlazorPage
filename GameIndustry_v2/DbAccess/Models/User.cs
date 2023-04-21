using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Application.Persistence.Models;

public class User
{
    public int Id { get; set; }

    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }

    public int Age { get; set; }

    public bool IsPremiumMember { get; set; }

    [JsonIgnore]
    public virtual List<UsersRole>? UsersRoles { get; set; }
}