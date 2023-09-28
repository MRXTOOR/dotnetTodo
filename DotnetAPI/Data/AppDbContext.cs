using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptionsBuilder<AppDbContext> options) :base(options)
        {
            
        }

        public DbSet<ToDo> Todos => Set<ToDo>();
    }
}