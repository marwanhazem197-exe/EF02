using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02
{
    internal class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MaxNumAttend { get; set; }
        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; }
    }
}
