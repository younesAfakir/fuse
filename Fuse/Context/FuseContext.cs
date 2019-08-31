using System;
using Fuse.Model;
using Microsoft.EntityFrameworkCore;

namespace Fuse.Context
{
    public class FuseContext : DbContext
    {
        public FuseContext(DbContextOptions<FuseContext> options) : base(options)
        {
        }

        public DbSet<Costumer> Costumer { get; set; }

    }
}
