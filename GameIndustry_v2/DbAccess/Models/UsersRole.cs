using System.Text.Json.Serialization;

namespace Application.Persistence.Models;

public class UsersRole
{
    public int Id { get; set; }

    public int UserId { get; set; }

    [JsonIgnore]
    public virtual User? User { get; set; }
    public int RoleId { get; set; }

    [JsonIgnore]
    public virtual Role? Role { get; set; }
}