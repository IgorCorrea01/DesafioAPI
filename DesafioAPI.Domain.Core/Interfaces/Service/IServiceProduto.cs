using System.Collections.Generic;

namespace DesafioAPI.Domain.Core.Interfaces.Service
{
    public interface IServiceProduto<Produto> where Produto : class 
    {
        void Add(Produto produto);
        void Update(Produto produto);
        void Remove(Produto produto);
        IEnumerable<Produto> GetAll();
        Produto GetByCodigo(int codigo);
    }
}
