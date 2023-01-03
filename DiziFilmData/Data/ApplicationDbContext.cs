using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DiziFilmModel.Models;

namespace DiziFilmData.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Kanallar> Kanallar { get; set; }
        public DbSet<Diziler> Diziler { get; set; }
        public DbSet<Oyuncular> Oyuncular { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<joinler> joinler { get; set; }


    }
}
