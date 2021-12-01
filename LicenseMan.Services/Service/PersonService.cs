using LicenseMan.ApplicationPersistence;
using LicenseMan.GeneralEntity;

namespace LicenseMan.Services.Service
{
	public class PersonService : IPersonService
	{
		private readonly ApplicationDbContext context;

		public PersonService(ApplicationDbContext context)
		{
			this.context = context;
		}

		public async Task CreateAsync(Person newPerson)
		{
			await context.Persons.AddAsync(newPerson);
			await context.SaveChangesAsync();
		}

		public async Task Delete(int id)
		{
			var person = GetById(id);
			context.Remove(person);
			await context.SaveChangesAsync();
		}

		public IEnumerable<Person> GetAll()
		{
			return context.Persons;
		}

		public Person GetById(int id)
		{
			return context.Persons.Where(p => p.Id == id).FirstOrDefault();
		}

		public async Task UpdateAsync(Person person)
		{
			context.Update(person);
			await context.SaveChangesAsync();
		}

		public async Task UpdateAsync(int id)
		{
			var person = GetById(id);
			context.Update(person);
			await context.SaveChangesAsync();
		}
	}
}
