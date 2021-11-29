using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LicenseMan.GeneralEntity
{
    [Table("Contact", Schema ="General")]
    public class Contact
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }
        [MaxLength(20)]
        public string ZipCode { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }

        public IEnumerable<Person> Persons { get; set; }
    }
}