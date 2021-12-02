using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LicenseMan.GeneralEntity
{
    [Table("Person", Schema = "General")]
    public class Person
    {
        [Key]
        public int Id { get; set; } 
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(50)]
        public string Role { get; set; }

        public int? DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department? Department { get; set; }

        public int? ContactId { get; set; }
        [ForeignKey("ContactId")]
		public Contact Contact { get; set; }

		public IEnumerable<Address> Addresses { get; set; }

		public IEnumerable<Department> DepartmentHeads { get; set; }
		public IEnumerable<Department> DepartmentDeputies { get; set; }
	}
}