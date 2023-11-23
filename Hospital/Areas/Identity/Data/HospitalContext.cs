using Hospital.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Hospital.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital.Areas.Identity.Data;

public class HospitalContext : IdentityDbContext<HospitalUser>
{
    public HospitalContext(DbContextOptions<HospitalContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new HospitalUserEntityConfiguration());
    }

    public DbSet<Hospital.Models.Appointment> Appointment { get; set; } = default!;

    public DbSet<Hospital.Models.Inventory> Inventory { get; set; } = default!;

    public DbSet<Hospital.Models.Patient> Patient { get; set; } = default!;

    public DbSet<Hospital.Models.Staff> Staff { get; set; } = default!;
}

internal class HospitalUserEntityConfiguration : IEntityTypeConfiguration<HospitalUser>
{
    public void Configure(EntityTypeBuilder<HospitalUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(255);
        builder.Property(u => u.LastName).HasMaxLength(255);
    }
}