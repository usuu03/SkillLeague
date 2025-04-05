using System;
using Microsoft.EntityFrameworkCore;
using SkillLeague.Domain;

namespace SkillLeague.Persistence;

// Inherits from DbContext
public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Challenge> Challenges { get; set; }
}