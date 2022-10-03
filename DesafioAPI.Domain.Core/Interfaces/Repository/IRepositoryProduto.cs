using System.Collections.Generic;

namespace DesafioAPI.Domain.Core.Interfaces.Repository
{
    public interface IRepositoryProduto<Produto> where Produto : class
    {
        void Add(Produto produto);
        void Update(Produto produto);
        void Remove(Produto produto);
        IEnumerable<Produto> GetAll();
        Produto GetByCodigo(int codigo);
    }
}
