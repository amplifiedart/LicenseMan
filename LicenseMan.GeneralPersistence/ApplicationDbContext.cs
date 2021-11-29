using LicenseMan.GeneralEntity;
using LicenseMan.LicenseEntity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LicenseMan.ApplicationPersistence
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<Department>()
				.HasOne(d => d.DepartmentHead)
				.WithMany(p => p.DepartmentHeads)
				.OnDelete(DeleteBehavior.ClientNoAction);

			builder.Entity<Department>()
				.HasOne(d => d.DepartmentDeputy)
				.WithMany(p => p.DepartmentDeputies)
				.OnDelete(DeleteBehavior.ClientNoAction);

			base.OnModelCreating(builder);
		}

		//
		//  General Entity Registration
		// 

		public DbSet<Person> Persons { get; set; }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<Contact> Contacts { get; set; }

		//
		//  License Manager Entity Registrations
		//

		public DbSet<LicenseCollection> Collections { get; set; }
		public DbSet<LicensePackage> Packages { get; set; }
		public DbSet<LicenseContract> Contracts { get; set; }
		public DbSet<LicenseItem> Items { get; set; }
		public DbSet<LicenseAssignment> Assignments { get; set; }
	}
}