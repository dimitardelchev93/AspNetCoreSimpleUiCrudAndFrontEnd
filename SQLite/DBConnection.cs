using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.IO;

namespace SQLite
{
    public class DBConnection : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            var sqlitePath = Path.Combine(
                Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()),
                @"SQLite\main.db"
            );

            options.UseSqlite("Data Source=" + sqlitePath);
        }
    }
}

