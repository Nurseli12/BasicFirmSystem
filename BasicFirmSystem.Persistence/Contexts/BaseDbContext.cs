using BasicFirmSystem.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Persistence.Contexts
{
    public  class BaseDbContext :DbContext
    {
        protected IConfiguration Configuration;

        protected BaseDbContext(DbContextOptions dbContextoptions,IConfiguration configuration):base(dbContextoptions)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //    base.OnConfiguring(
            //        optionsBuilder.UseSqlServer(Configuration.GetConnectionString("SomeConnectionString")));
        }
        public DbSet<AlternativeCurrent> AlternativeCurrents { get; set; }
        public DbSet<AlternativeStock> AlternativeStocks { get; set; }
        public DbSet<Appellation> Appellations { get; set; }
        public DbSet<CurrentCard> CurrentCards { get; set; }
        public DbSet<CurrentGroup> CurrentGroups { get; set; }
        public DbSet<CurrentSubGroup> CurrentSubGroups { get; set; }
        public DbSet<MoneyUnit> MoneyUnits { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<RoleUserRestraint> RoleUserRestraints { get; set; }
        public DbSet<StockAuthorization> StockAuthorizations { get; set; }
        public DbSet<StockCard> StockCards { get; set; }
        public DbSet<StockMainGroup> StockMainGroups { get; set; }
        public DbSet<StockMiddleGroup> StockMiddleGroups { get; set; }
        public DbSet<StockSubGroup> StockSubGroups { get; set; }
        public DbSet<StockTechnicalFeature> StockTechnicalFeatures { get; set; }
        public DbSet<TaxOffice> TaxOffices { get; set; }
        //public DbSet<User> Users { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<TechnicalImage> TechnicalImages { get; set; }


    }
}
