using Hospital.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Hospital.Models;

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
    }

    public DbSet<Hospital.Models.Appointment> Appointment { get; set; } = default!;
}
