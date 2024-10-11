using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using CP2.Domain.Interfaces.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CP2.Application.Services
{
    public class FornecedorApplicationService : IFornecedorApplicationService
    {
        private readonly IFornecedorRepository _fornecedorRepository; // Supondo que você tenha um repositório

        public FornecedorApplicationService(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        public FornecedorEntity? SalvarDadosFornecedor(IFornecedorDto dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto));
            }

            var fornecedor = new FornecedorEntity
            {
                Nome = dto.Nome,
                CNPJ = dto.CNPJ,
                Endereco = dto.Endereco,
                Telefone = dto.Telefone,
                Email = dto.Email,
                CriadoEm = DateTime.UtcNow
            };

            // Salva o fornecedor no banco de dados
            _fornecedorRepository.Add(fornecedor);
            _fornecedorRepository.SaveChanges(); // Supondo que tenha um método SaveChanges

            return fornecedor; // Retorna o fornecedor criado
        }

        public FornecedorEntity? EditarDadosFornecedor(int id, IFornecedorDto dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto));
            }

            var fornecedor = _fornecedorRepository.GetById(id); // Lógica para obter o fornecedor pelo ID
            if (fornecedor == null)
            {
                return null; // Retorne null se o fornecedor não for encontrado
            }

            fornecedor.Nome = dto.Nome;
            fornecedor.CNPJ = dto.CNPJ;
            fornecedor.Endereco = dto.Endereco;
            fornecedor.Telefone = dto.Telefone;
            fornecedor.Email = dto.Email;

            // Salve as mudanças no banco de dados
            _fornecedorRepository.Update(fornecedor);
            _fornecedorRepository.SaveChanges();

            return fornecedor; // Retorne o fornecedor atualizado
        }

        public FornecedorEntity? DeletarDadosFornecedor(int id)
        {
            var fornecedor = _fornecedorRepository.GetById(id); // Lógica para obter o fornecedor pelo ID
            if (fornecedor == null)
            {
                return null; // Retorne null se o fornecedor não for encontrado
            }

            // Lógica para deletar o fornecedor
            _fornecedorRepository.Remove(fornecedor);
            _fornecedorRepository.SaveChanges();

            return fornecedor; // Retorne o fornecedor que foi deletado
        }

        public FornecedorEntity? ObterFornecedorPorId(int id)
        {
            var fornecedor = _fornecedorRepository.GetById(id); // Lógica para obter fornecedor pelo ID
            return fornecedor; // Retorna null se não encontrado
        }

        public IEnumerable<FornecedorEntity> ObterTodosFornecedores()
        {
            var fornecedores = _fornecedorRepository.GetAll(); // Lógica para obter todos os fornecedores
            return fornecedores ?? Enumerable.Empty<FornecedorEntity>(); // Retorna uma coleção vazia se não houver fornecedores
        }
    }
}
