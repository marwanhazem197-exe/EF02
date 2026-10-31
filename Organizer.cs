using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02
{
    [Table("EventOrganizers")]
    internal class Organizer
    {
        [Key]
        public int OrgId { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        public string  OrganizerName { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string? CompanyName { get; set; }
        public string VerifidStatus { get; set; }
        public OrganizerProfile OrganizerProfile { get; set; }
        public List<Event> Events { get; set; }
    }
}
