using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Configration
{
    internal class EventConfigration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> E)
        {
            E.HasOne(E => E.Organizer)
                .WithMany(O => O.Events)
                .HasForeignKey(E => E.OrganizerId);
        }
    }
}
