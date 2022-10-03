using DesafioAPI.Application.Dtos;
using DesafioAPI.Domain.Entity;
using System.Collections.Generic;

namespace DesafioAPI.Application.Interfaces.Mapper
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDto produtoDto);
        IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produtos);
        ProdutoDto MapperEntitytoDto(Produto produto);
    }
}
