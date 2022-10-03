using DesafioAPI.Domain.Core.Interfaces.Repository;
using DesafioAPI.Domain.Core.Interfaces.Service;
using System.Collections.Generic;

namespace DesafioAPI.Domain.Services
{
    public class ServiceProduto<Produto> : IServiceProduto<Produto> where Produto : class
    {
        private readonly IRepositoryProduto<Produto> repository;

        public ServiceProduto(IRepositoryProduto<Produto> repository)
        {
            this.repository = repository;
        }

        public void Add(Produto produto)
        {
            repository.Add(produto);
        }

        public void Update(Produto produto)
        {
           repository.Update(produto);
        }

        public void Remove(Produto produto)
        {
            repository.Remove(produto);
        }

        public IEnumerable<Produto> GetAll()
        {
            return repository.GetAll();
        }

        public Produto GetByCodigo(int codigo)
        {
            return repository.GetByCodigo(codigo);
        }
    }
}
