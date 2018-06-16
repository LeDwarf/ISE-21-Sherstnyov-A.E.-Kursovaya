using FurnitureFactoryModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace FurnitureFactoryService
{
    [Table("FurnitureFactoryDatabase")]
    public class FurnitureFactoryDbContext : DbContext
    {
        public FurnitureFactoryDbContext()
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public virtual DbSet<Admin> Admins { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

    }
}
