using MyVet.Web.Data.Entities;
using System.Data.Entity;

namespace MyVet.Web.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Owner> Owners { get; set; }
        public DbContextOptions<DataContext> Options { get; }
    }
}
