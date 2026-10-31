using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EF02
{
    internal class Attendee
    {
        public int  AttendeeId { get; set; }

        [Required]
        [Column(TypeName = "varchar(150)")]
        public string FullNmae { get;set; }
        [Required]
        [Column(TypeName = "varchar(200)")]
        public string Email { get; set; }

        [Required]
        public Address FullAddress { get; set; }
        public Badge Badge { get; set; }

    }
}
