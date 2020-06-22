using AeronauticsX.aspnet.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AeronauticsX.aspnet.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Plane> Planes { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    }
}
