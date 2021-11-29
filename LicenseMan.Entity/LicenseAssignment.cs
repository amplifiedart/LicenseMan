using LicenseMan.GeneralEntity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LicenseMan.LicenseEntity
{
    public class LicenseAssignment
    {
        [Key]
        public int Id { get; set; }

		public int? CustodianPersonId { get; set; }
        [ForeignKey("CustodianPersonId")]
        public Person Custodian { get; set; }

        public int? LicenseId { get; set; }
        [ForeignKey("LicenseId")]
		public LicenseItem License { get; set; }

		public DateTime StartDate { get; set; }
		public DateTime DateReturned { get; set; }

		public bool IsActive { get; set; }
	}
}