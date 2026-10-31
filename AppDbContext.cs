using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF02
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = EventHub; Trusted_Connection = True;TrustServerCertificate = True;");
        }
        protected override void OnModelCreating(ModelBuilder b)
        {
            b.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            b.Entity<Badge>()
                .HasOne(B => B.Attendee)
                .WithOne(B => B.Badge)
                .HasForeignKey<Badge>(B => B.AttendeeId);
        }
        DbSet<Organizer> organizers {  get; set; }
        DbSet<OrganizerProfile> organizerProfiles { get; set; }
        DbSet<Event> Events { get; set; }
        DbSet<Attendee> Attendees { get; set; }
        DbSet<Badge> Badges { get; set; }
    }
}
