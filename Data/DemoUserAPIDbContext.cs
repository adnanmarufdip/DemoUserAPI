using DemoUserAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoUserAPI.Data
{
    public class DemoUserAPIDbContext : DbContext
    {
        public DemoUserAPIDbContext(DbContextOptions<DemoUserAPIDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
