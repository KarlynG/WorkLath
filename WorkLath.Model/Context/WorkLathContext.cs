using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WorkLath.Model.Contexts;
using WorkLath.Model.Entities;

namespace WorkLath.Model.Context
{
    public class WorkLathContext : BaseDbContext
    {
        public WorkLathContext(DbContextOptions<WorkLathContext> options) : base(options)
        {
        }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}
