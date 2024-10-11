using CP2.Domain.Interfaces.Dtos;
using FluentValidation;
using System;
using System.Linq;

namespace CP2.Application.Dtos
{
    public class VendedorDto : IVendedorDto
    {
        public int Id { get; set; }  // Adicionando a propriedade Id
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public DateTime DataContratacao { get; set; }
        public decimal ComissaoPercentual { get; set; }
        public decimal MetaMensal { get; set; }
        public DateTime CriadoEm { get; set; }

        public void Validate()
        {
            var validationResult = new VendedorDtoValidation().Validate(this);
            if (!validationResult.IsValid)
                throw new Exception(string.Join(", ", validationResult.Errors.Select(x => x.ErrorMessage)));
        }
    }

    internal class VendedorDtoValidation : AbstractValidator<VendedorDto>
    {
        public VendedorDtoValidation()
        {
            RuleFor(x => x.Nome).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Email).EmailAddress().NotEmpty();  // Adicionando a regra NotEmpty
            RuleFor(x => x.Telefone).NotEmpty().Length(10, 15);
            RuleFor(x => x.ComissaoPercentual).GreaterThan(0);
            RuleFor(x => x.MetaMensal).GreaterThan(0);
        }
    }
}
