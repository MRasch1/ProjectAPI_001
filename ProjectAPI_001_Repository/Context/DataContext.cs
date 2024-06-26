﻿using Microsoft.EntityFrameworkCore;
using ProjectAPI_001_Repository.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAPI_001_Repository.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<Samurai> Samurai { get; set; }

        public DbSet<Ninja> Ninja { get; set; }

        public DbSet<Warrior> Warrior { get; set; }
    }
}
