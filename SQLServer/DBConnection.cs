using Microsoft.EntityFrameworkCore;
using Models;
using System;

namespace SQLServer
{
    public class DBConnection : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=.;Database=AspNetCoreSimpleUiCrudAndFrontEnd;Trusted_Connection=True;");
    }
}
