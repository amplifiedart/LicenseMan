using LicenseMan.GeneralEntity;

namespace LicenseMan.Models
{
	public class PersonDetailViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Role { get; set; }
		public Department Department { get; set; }
	}
}
