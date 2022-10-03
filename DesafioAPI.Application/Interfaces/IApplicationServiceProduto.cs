using DesafioAPI.Application.Dtos;
using System.Collections.Generic;

namespace DesafioAPI.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDto produtoDto);
        void Update(ProdutoDto produtoDto);
        void Remove(ProdutoDto produtoDto);
        IEnumerable<ProdutoDto> GetAll();
        ProdutoDto GetByCodigo(int codigo);
    }
}
