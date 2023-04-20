using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        // options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
        options.UseSqlite("Data source=datingapp.db");
        
    }


        public DbSet<AppUser> Users { get; set; }
    }
}