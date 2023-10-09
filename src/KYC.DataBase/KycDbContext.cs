using KYC.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using ConfiguredSqlConnection.Extensions;

namespace KYC.DataBase;

public class KycDbContext : DbContext
{
    public virtual DbSet<User> Users { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .ConfigureFromActionConnection()
            .ConfigureFromSecretConnection();
    }
}