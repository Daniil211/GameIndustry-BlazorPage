﻿using System.ComponentModel.DataAnnotations;

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

    public string? Role { get; set; }
}