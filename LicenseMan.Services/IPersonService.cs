using LicenseMan.GeneralEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseMan.Services
{
	public interface IPersonService
	{
		Task CreateAsync(Person newPerson);
		Person GetById(int id);
		Task UpdateAsync(Person person);
		Task UpdateAsync(int id);
		Task Delete(int id);
		IEnumerable<Person> GetAll();
		int Count();
	}
}
