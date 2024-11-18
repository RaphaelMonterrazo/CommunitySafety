
using CommunitySafety.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CommunitySafety.Infrastructure.EntitiesConfiguration
{
    public class IncidentConfiguration : IEntityTypeConfiguration<Incident>
    {
        public void Configure(EntityTypeBuilder<Incident> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Description).HasMaxLength(50).IsRequired();
            builder.HasOne(e => e.Category).WithMany(e => e.Incidents).HasForeignKey(e => e.CategoryId);
            builder.HasOne(e => e.Location).WithMany(e => e.Incidents).HasForeignKey(e => e.LocationId);
        }
    }
}
