using LicenseMan.LicenseEntity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LicenseMan.LicensePersistence
{
    public class LicenseDbContext : IdentityDbContext
    {
        public LicenseDbContext(DbContextOptions<LicenseDbContext> options)
            : base(options)
        {
        }

        public DbSet<LicenseCollection> LicenseCollections { get; set; }

        public DbSet<LicenseContract> LicenseContracts { get; set; }

        public DbSet<LicensePackage> LicensePackages { get; set; }


    }
}