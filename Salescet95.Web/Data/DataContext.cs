using Microsoft.EntityFrameworkCore;
using Salescet95.Web.Data.Entities;

namespace Salescet95.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }

        public DbSet<Country> Countries { get; set; }
    }
}
