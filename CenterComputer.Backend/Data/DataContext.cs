using CenterComputer.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CenterComputer.Backend.Data
{
    public class DataContext : DbContext
    {
        internal readonly object MyCenterComputer;
        internal readonly object MyComputer;

        public DataContext(DbContextOptions<DataContext> op) : base(op)
        {
        }

        public DbSet<MyCenterComputer> CenterComputers { get; set; }

    }
}
}
