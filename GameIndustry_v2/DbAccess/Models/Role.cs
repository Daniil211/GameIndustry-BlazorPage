using System.Text.Json.Serialization;

namespace Application.Persistence.Models;

public class Role
{
    public int Id { get; set; }

    public string Name { get; set; }

    [JsonIgnore]
    public virtual List<UsersRole>? UsersRoles { get; set; }
}