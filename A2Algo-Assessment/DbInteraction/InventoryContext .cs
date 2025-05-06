using A2Algo_Assessment.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.Entity;

namespace A2Algo_Assessment.DbInteraction
{
    public class InventoryContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options) { }
        public Microsoft.EntityFrameworkCore.DbSet<Product> Products => Set<Product>();
        public Microsoft.EntityFrameworkCore.DbSet<Sale> Sales => Set<Sale>();
        public Microsoft.EntityFrameworkCore.DbSet<Purchase> Purchases => Set<Purchase>();
    }

}
