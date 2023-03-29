﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DbAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

        public DbSet<GameModel> GameModels { get; set; }
        public DbSet<GameDeveloper> GameDevelopers { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}