using Microsoft.EntityFrameworkCore;
using Models;
using System;

namespace SQLite
{
    public class DBConnection : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=main.db");
    }
}

