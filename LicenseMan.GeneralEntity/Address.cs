using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LicenseMan.GeneralEntity
{
	[Table("Address", Schema = "General")]
	public class Address
	{
		[Key]
		public int Id { get; set; }

		public AddressType AddressType { get; set; }

		[Required, MaxLength(50)]
		public string AddressLabel { get; set; }

		[Required, MaxLength(1000)]
		public string AddressValue { get; set; }

		public int? PersonId { get; set; }
		[ForeignKey("PersonId")]
		public Person? Person { get; set; }

	}
}