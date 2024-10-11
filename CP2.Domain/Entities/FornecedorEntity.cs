using System;
using System.ComponentModel.DataAnnotations;

namespace CP2.Domain.Entities
{
    public class FornecedorEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; } = string.Empty; // Inicializando com um valor padrão

        [Required]
        [MaxLength(18)]
        public string CNPJ { get; set; } = string.Empty;

        [MaxLength(200)]
        public string Endereco { get; set; } = string.Empty;

        [MaxLength(15)]
        public string Telefone { get; set; } = string.Empty;

        [MaxLength(100)]
        [EmailAddress(ErrorMessage = "O formato do email é inválido.")]
        public string Email { get; set; } = string.Empty;

        public DateTime CriadoEm { get; set; } = DateTime.UtcNow; // Definindo um valor padrão para a data
    }
}
