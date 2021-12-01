using LicenseMan.GeneralEntity;
using System.ComponentModel.DataAnnotations;

namespace LicenseMan.Models
{
	public class PersonEditViewModel
	{
		[Key]
		public int Id { get; set; }
		[
			Display(Name = "Name"),
			Required(ErrorMessage = "Name is Required"),
			MaxLength(50, ErrorMessage = "The maximum length is 50")
		]
		public string Name { get; set; }

		[
			Display(Name = "Persons Role"),
			Required(ErrorMessage = "Role is Required"),
			MaxLength(50, ErrorMessage = "The maximum length is 50")
		]
		public string Role { get; set; }

		[Display(Name = "Department")]
		public Department Department { get; set; }
	}
}
