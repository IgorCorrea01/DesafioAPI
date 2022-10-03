using DesafioAPI.Application.Dtos;
using DesafioAPI.Application.Interfaces;
using DesafioAPI.Application.Interfaces.Mapper;
using DesafioAPI.Domain.Core.Interfaces.Service;
using DesafioAPI.Domain.Entity;
using System.Collections.Generic;

namespace DesafioAPI.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto<Produto> serviceProduto;
        private readonly IMapperProduto mapperProduto;

        public ApplicationServiceProduto(IServiceProduto<Produto> serviceProduto, IMapperProduto mapperProduto)
        {
            this.serviceProduto = serviceProduto;
            this.mapperProduto = mapperProduto;
        }
        public void Add(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Add(produto);
        }

        public ProdutoDto GetByCodigo(int codigo)
        {
            var produto = serviceProduto.GetByCodigo(codigo);
            return mapperProduto.MapperEntitytoDto(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var produtos = serviceProduto.GetAll();
            return mapperProduto.MapperListProdutosDto(produtos);
        }

        public void Remove(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Remove(produto);
        }

        public void Update(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Update(produto);
        }
    }
}
