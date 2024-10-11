namespace CP2.Domain.Interfaces.Dtos
{
    public interface IVendedorDto
    {
        int Id { get; set; } // Adicione esta linha
        string Nome { get; set; }
        string Email { get; set; }
        string Telefone { get; set; }
        DateTime DataNascimento { get; set; }
        string Endereco { get; set; }
        decimal ComissaoPercentual { get; set; }
        decimal MetaMensal { get; set; }

        void Validate(); // Supondo que você tenha um método para validação
    }
}
