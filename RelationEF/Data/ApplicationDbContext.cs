﻿using Microsoft.EntityFrameworkCore;
using RelationEF.Model;

namespace RelationEF.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
           
        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Grade> Grades { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
    }
}