using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CP2.Infrastructure.Repositories
{
    public class VendedorRepository : IVendedorRepository
    {
        private readonly ApplicationContext _context;

        public VendedorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Add(VendedorEntity vendedor)
        {
            _context.Vendedores.Add(vendedor);
            SaveChanges(); // Salva as mudanças
        }

        public void Update(VendedorEntity vendedor)
        {
            _context.Vendedores.Update(vendedor);
            SaveChanges(); // Salva as mudanças
        }

        public void Remove(int id) // Método ajustado para receber um ID
        {
            var vendedor = _context.Vendedores.Find(id);
            if (vendedor != null)
            {
                _context.Vendedores.Remove(vendedor);
                SaveChanges(); // Salva as mudanças
            }
        }

        public VendedorEntity? GetById(int id)
        {
            return _context.Vendedores.Find(id);
        }

        public IEnumerable<VendedorEntity> GetAll()
        {
            return _context.Vendedores.ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
