using Microsoft.EntityFrameworkCore;
using Skinet.Core.Entities;

namespace Skinet.Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        #region entity classes
        public DbSet<Product> Products { get; set; }

        #endregion
    }
}
