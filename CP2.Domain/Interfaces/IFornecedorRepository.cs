using CP2.Domain.Entities;
using System.Collections.Generic;

namespace CP2.Domain.Interfaces
{
    public interface IFornecedorRepository
    {
        void Add(FornecedorEntity fornecedor);
        FornecedorEntity? GetById(int id);
        void Update(FornecedorEntity fornecedor);
        void Remove(FornecedorEntity fornecedor);
        IEnumerable<FornecedorEntity> GetAll();
        void SaveChanges(); // Para salvar alterações, se necessário
    }
}
