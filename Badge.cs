using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02
{
    internal class Badge
    {
        public int BadgeId { get; set; }
        public DateTime IssuedDate { get; set; }
        public string Tier { get; set; }
        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; }
    }
}
