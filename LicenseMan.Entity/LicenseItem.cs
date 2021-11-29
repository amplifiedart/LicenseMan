using System.ComponentModel.DataAnnotations;

namespace LicenseMan.LicenseEntity
{
    public class LicenseItem
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string LicenseKey { get; set; }

        [MaxLength(256)]
        public string LicenseFileUrl { get; set; }

        public int LicenseAmount { get; set; }

		public DateTime StartDate { get; set; }
        
		public DateTime ExpiryDate { get; set; }

		public IEnumerable<LicenseAssignment> LicenseAssignments { get; set; }
    }
}