using LicenseMan.GeneralEntity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LicenseMan.LicenseEntity
{
    [Table("LicensePackage", Schema = "Collector")]
    public class LicensePackage
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        public int? ManufacturerContactId { get; set; }
        [ForeignKey("ManufacturerContactId")]
        public Contact? ManufacturerContact { get; set; }

        [MaxLength(100)]
        public string ManufacturerReference { get; set; }

        public IEnumerable<LicenseItem> Licenses { get; set; }


    }
}