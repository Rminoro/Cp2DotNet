using CP2.Domain.Interfaces.Dtos;
using CP2.Domain.Entities;
using System.Collections.Generic;

namespace CP2.Domain.Interfaces
{
    public interface IVendedorApplicationService
    {
        void SalvarDadosVendedor(IVendedorDto vendedorDto);
        void DeletarDadosVendedor(int id);
        IEnumerable<VendedorEntity> ObterTodosVendedores();
        VendedorEntity? ObterVendedorPorId(int id);
        void EditarDadosVendedor(int id, IVendedorDto vendedorDto);
    }
}
