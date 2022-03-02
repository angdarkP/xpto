using Microsoft.EntityFrameworkCore;
using xpto.Entities;

namespace xpto.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public virtual DbSet<Medication> Medication { get; private set; }
    }
}
