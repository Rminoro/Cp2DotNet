using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using CP2.Domain.Interfaces.Dtos;
using System;
using System.Collections.Generic;

namespace CP2.Application.Services
{
    public class VendedorApplicationService : IVendedorApplicationService
    {
        private readonly IVendedorRepository _repository;

        public VendedorApplicationService(IVendedorRepository repository)
        {
            _repository = repository;
        }

        public void SalvarDadosVendedor(IVendedorDto vendedorDto)
        {
            // Valida os dados do vendedor
            vendedorDto.Validate();

            var vendedor = new VendedorEntity
            {
                Nome = vendedorDto.Nome,
                Email = vendedorDto.Email,
                Telefone = vendedorDto.Telefone,
                DataNascimento = vendedorDto.DataNascimento,
                Endereco = vendedorDto.Endereco,
                DataContratacao = DateTime.Now,
                ComissaoPercentual = vendedorDto.ComissaoPercentual,
                MetaMensal = vendedorDto.MetaMensal,
                CriadoEm = DateTime.Now
            };

            // Salva o vendedor usando o repositório
            _repository.Add(vendedor);
        }

        public void DeletarDadosVendedor(int id) // Ajustado para void
        {
            _repository.Remove(id);
        }

        public IEnumerable<VendedorEntity> ObterTodosVendedores()
        {
            return _repository.GetAll();
        }

        public VendedorEntity? ObterVendedorPorId(int id)
        {
            return _repository.GetById(id);
        }

        public void EditarDadosVendedor(int id, IVendedorDto vendedorDto)
        {
            // Implementação da edição (se necessário)
        }
    }
}
