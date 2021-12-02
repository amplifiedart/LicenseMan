using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LicenseMan.LicenseEntity
{
    [Table("LicenseContract", Schema = "Collector")]
    public class LicenseContract
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(200)]
		public string Name { get; set; }

        [Required, MaxLength(50)]
		public string ContractNumber { get; set; }

		public DateTime StartDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}