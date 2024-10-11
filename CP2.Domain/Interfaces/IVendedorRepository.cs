using CP2.Domain.Entities;
using System.Collections.Generic;

namespace CP2.Domain.Interfaces
{
    public interface IVendedorRepository
    {
        void Add(VendedorEntity vendedor);
        void Update(VendedorEntity vendedor);
        void Remove(int id); // Altere para receber um ID
        VendedorEntity? GetById(int id);
        IEnumerable<VendedorEntity> GetAll();
        void SaveChanges();
    }
}
