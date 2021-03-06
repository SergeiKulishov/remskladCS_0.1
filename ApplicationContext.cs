﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace remsklad_C_
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Datum> Datums { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=remskladappdb;Trusted_Connection=True;");
        }
    }
}
