using Microsoft.EntityFrameworkCore;
using CP2.Domain.Entities;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

    public DbSet<VendedorEntity> Vendedores { get; set; }
    public DbSet<FornecedorEntity> Fornecedores { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FornecedorEntity>(entity =>
        {
            entity.Property(e => e.Nome)
                  .HasColumnType("NVARCHAR2(100)")
                  .IsRequired();

            entity.Property(e => e.CNPJ)
                  .HasColumnType("NVARCHAR2(18)")
                  .IsRequired();

            entity.Property(e => e.Endereco)
                  .HasColumnType("NVARCHAR2(200)")
                  .IsRequired(false); // Opcional, pois não possui [Required]

            entity.Property(e => e.Telefone)
                  .HasColumnType("NVARCHAR2(15)")
                  .IsRequired(false); // Opcional

            entity.Property(e => e.Email)
                  .HasColumnType("NVARCHAR2(100)")
                  .IsRequired(false) // Opcional
                  .HasMaxLength(100);

            entity.Property(e => e.CriadoEm)
                  .HasColumnType("DATE")
                  .IsRequired();
        });
    }
}