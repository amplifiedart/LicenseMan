using LicenseMan.GeneralEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseMan.LicenseEntity
{
    [Table("LicenseCollection",Schema ="Collector")]
    public class LicenseCollection
    {
        public int Id { get; set; }
        
        [Required, MaxLength(50)]
        public string Name { get; set; } = string.Empty;


        public int? LicenseContractId { get; set; }
        [ForeignKey("LicenseContractId")]
        public LicenseContract? Contract { get; set; }

        public IEnumerable<LicensePackage> LicensePackages{ get; set;}

        public int? VendorContactId { get; set; }
        [ForeignKey("VendorContactId")]
        public Contact? Vendor { get; set; }
	}
}
