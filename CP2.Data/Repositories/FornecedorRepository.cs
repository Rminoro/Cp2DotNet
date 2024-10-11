using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CP2.Infrastructure.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly ApplicationContext _context; // Assumindo que você tenha um ApplicationContext

        public FornecedorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Add(FornecedorEntity fornecedor)
        {
            _context.Fornecedores.Add(fornecedor);
        }

        public FornecedorEntity? GetById(int id)
        {
            return _context.Fornecedores.Find(id);
        }

        public void Update(FornecedorEntity fornecedor)
        {
            _context.Fornecedores.Update(fornecedor);
        }

        public void Remove(FornecedorEntity fornecedor)
        {
            _context.Fornecedores.Remove(fornecedor);
        }

        public IEnumerable<FornecedorEntity> GetAll()
        {
            return _context.Fornecedores.ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
