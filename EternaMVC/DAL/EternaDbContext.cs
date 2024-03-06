﻿using EternaMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EternaMVC.DAL
{
    public class EternaDbContext : DbContext
    {
        public EternaDbContext(DbContextOptions<EternaDbContext> options) : base(options)
        {
            
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Clients> Clients { get; set; }
    }
}
