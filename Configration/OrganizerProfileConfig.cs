using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Configration
{
    internal class OrganizerProfileConfig : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> OP)
        {
            OP.HasOne(OP => OP.organizer)
                .WithOne(O => O.OrganizerProfile)
                .HasForeignKey<OrganizerProfile>(OP => OP.OrganizerId);
        }
    }
}
