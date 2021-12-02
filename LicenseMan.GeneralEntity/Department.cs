using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LicenseMan.GeneralEntity
{
	[Table("Department", Schema = "General")]
	public class Department
	{
		[Key]
		public int Id { get; set; }

		[Required, MaxLength(50)]
		public string Name { get; set; } 

		[Required, MaxLength(10)]
		public string Abbreviation { get; set; }

		public int? DepartmentHeadPersonId { get; set; }
		[ForeignKey("DepartmentHeadPersonId")]
		public Person? DepartmentHead { get; set; }

		public int? DepartmentDeputyPersonId { get; set; }
		[ForeignKey("DepartmentDeputyPersonId")]
		public Person? DepartmentDeputy { get; set; }
	}
}