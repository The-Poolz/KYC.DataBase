using KYC.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using ConfiguredSqlConnection.Extensions;

namespace KYC.DataBase;

public class KycDbContext : DbContext
{
    public KycDbContext() { }

    public KycDbContext(DbContextOptions<KycDbContext> options)
        : base(options)
    { }

    public virtual DbSet<User> Users { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .ConfigureFromActionConnection()
            .ConfigureFromSecretConnection();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.RecordId);
        });
    }
}