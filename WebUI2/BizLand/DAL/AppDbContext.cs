﻿using BizLand.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizLand.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        :base(options)
        {
        }
        public DbSet<Team> Team { get; set; }
        public DbSet<Settings> Settings { get; set; }
    }
}
