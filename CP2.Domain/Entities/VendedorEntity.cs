using System.ComponentModel.DataAnnotations;

namespace CP2.Domain.Entities;

public class VendedorEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Nome { get; set; } = string.Empty;

    [MaxLength(100)]
    public string Email { get; set; } = string.Empty;

    [MaxLength(15)]
    public string Telefone { get; set; } = string.Empty;

    public DateTime DataNascimento { get; set; } = DateTime.UtcNow; // Definindo um valor padrão para data

    [MaxLength(200)]
    public string Endereco { get; set; } = string.Empty;

    public DateTime DataContratacao { get; set; } = DateTime.UtcNow; // Definindo um valor padrão para data

    public decimal ComissaoPercentual { get; set; }

    public decimal MetaMensal { get; set; }

    public DateTime CriadoEm { get; set; } = DateTime.UtcNow; // Definindo um valor padrão para data
}