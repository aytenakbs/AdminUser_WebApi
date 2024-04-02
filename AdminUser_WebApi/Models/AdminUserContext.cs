using Microsoft.EntityFrameworkCore;

namespace AdminUser_WebApi.Models;

public class AdminUserContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=LAPTOP-SPHGMM2D;Database=AdminUserDb;Trusted_Connection=true;TrustServerCertificate=true;");
    }
    public DbSet<AdminUser> AdminUsers { get; set; }
}
