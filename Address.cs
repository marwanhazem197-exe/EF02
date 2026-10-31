using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02
{
    [ComplexType]
    internal class Address
    {
        [Required]
        [Column(TypeName = "varchar(150)")]
        public string Street { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string City { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Country { get; set; }

        [Required]
        [Column("ZipCode",TypeName = "varchar(20)")]
        public string PostalCode { get; set; }

    }
}
