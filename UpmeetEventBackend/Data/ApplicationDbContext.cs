﻿using Microsoft.EntityFrameworkCore;
using UpmeetEventBackend.Models;

namespace UpmeetEventBackend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Event> Events { get; set; }
    }
}
