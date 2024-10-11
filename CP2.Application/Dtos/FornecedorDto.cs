using CP2.Domain.Interfaces.Dtos;
using FluentValidation;
using System;
using System.Linq;

namespace CP2.Application.Dtos
{
    public class FornecedorDto : IFornecedorDto
    {
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime CriadoEm { get; set; } // Certifique-se de que essa propriedade está na interface

        public void Validate()
        {
            var validateResult = new FornecedorDtoValidation().Validate(this);
            if (!validateResult.IsValid)
                throw new Exception(string.Join(" e ", validateResult.Errors.Select(x => x.ErrorMessage)));
        }
    }

    internal class FornecedorDtoValidation : AbstractValidator<FornecedorDto>
    {
        public FornecedorDtoValidation()
        {
            RuleFor(f => f.Nome).NotEmpty().WithMessage("O nome é obrigatório.");
            RuleFor(f => f.CNPJ).NotEmpty().WithMessage("O CNPJ é obrigatório.");
            // Adicione mais regras de validação conforme necessário
        }
    }
}
