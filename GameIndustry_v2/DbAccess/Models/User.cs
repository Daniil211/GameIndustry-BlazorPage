using System.ComponentModel.DataAnnotations;

namespace Application.Persistence.Models;

/// <summary>
/// Class User.
/// </summary>
public class User
{
    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the username.
    /// </summary>
    /// <value>The username.</value>
    [Required]
    public string Username { get; set; }

    /// <summary>
    /// Gets or sets the password.
    /// </summary>
    /// <value>The password.</value>
    [Required]
    public string Password { get; set; }

    /// <summary>
    /// Gets or sets the age.
    /// </summary>
    /// <value>The age.</value>
    public int Age { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is premium member.
    /// </summary>
    /// <value><c>true</c> if this instance is premium member; otherwise, <c>false</c>.</value>
    public bool IsPremiumMember { get; set; }

    /// <summary>
    /// Gets or sets the role.
    /// </summary>
    /// <value>The role.</value>
    public string? Role { get; set; }

    /// <summary>
    /// Gets or sets the date created.
    /// </summary>
    /// <value>The date created.</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="User"/> is sex.
    /// </summary>
    /// <value><c>true</c> if sex; otherwise, <c>false</c>.</value>
    public bool Sex { get; set; }
}