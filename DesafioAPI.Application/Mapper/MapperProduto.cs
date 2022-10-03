using DesafioAPI.Application.Dtos;
using DesafioAPI.Application.Interfaces.Mapper;
using DesafioAPI.Domain.Entity;
using System.Collections.Generic;
using System.Linq;

namespace DesafioAPI.Application.Mapper
{
    public class MapperProduto : IMapperProduto
    {
        public Produto MapperDtoToEntity(ProdutoDto produtoDto)
        {
            var produto = new Produto()
            {
                Codigo = produtoDto.Codigo,
                Descricao = produtoDto.Descricao
            };
            return produto;
        }

        public ProdutoDto MapperEntitytoDto(Produto produto)
        {
            var produtoDto = new ProdutoDto()
            {
                Codigo = produto.Codigo,
                Descricao = produto.Descricao
            };
            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produtos)
        {
            var produtosDto = produtos.Select(p => new ProdutoDto() { Codigo = p.Codigo, Descricao = p.Descricao });

            return produtosDto;
        }
    }
}
