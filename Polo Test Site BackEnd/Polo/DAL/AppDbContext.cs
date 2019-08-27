using Microsoft.EntityFrameworkCore;
using Polo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polo.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Description> Descriptions { get; set; }

        public DbSet<Welcome> Welcomes{ get; set; }
        public DbSet<WhatWeDo> WhatWeDos { get; set; }

        public DbSet<OurWork> OurWorks { get; set; }


    }
}
