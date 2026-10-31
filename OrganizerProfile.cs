using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02
{
    internal class OrganizerProfile
    {
        public int OrganizerProfileId { get; set; }
        public string Bio { get; set; }
        public string Website { get; set; }
        public string Logo { get; set; }
        public int OrganizerId { get; set; }
        public Organizer organizer { get; set; }

    }
}
