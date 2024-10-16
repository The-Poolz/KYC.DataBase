using KYC.DataBase.Models;
using KYC.DataBase.Models.Types;
using Microsoft.EntityFrameworkCore;
using ConfiguredSqlConnection.Extensions;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

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
            entity.Property(e => e.Status)
                .HasConversion(new EnumToStringConverter<Status>());
        });
    }
}