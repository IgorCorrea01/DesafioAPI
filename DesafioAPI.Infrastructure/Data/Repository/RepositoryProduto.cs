using DesafioAPI.Domain.Core.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioAPI.Infrastructure.Data.Repository
{
    public class RepositoryProduto<Produto> : IRepositoryProduto<Produto> where Produto : class
    {
        private readonly SqlContext sqlContext;

        public RepositoryProduto(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        public void Add(Produto produto)
        {
            try
            {
                sqlContext.Set<Produto>().Add(produto);
                sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Produto produto)
        {
            try
            {
                sqlContext.Set<Produto>().Update(produto);
                sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(Produto produto)
        {
            try
            {

                sqlContext.Set<Produto>().Update(produto);
                sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Produto> GetAll()
        {
            return sqlContext.Set<Produto>().ToList();
        }

        public Produto GetByCodigo(int codigo)
        {
            return sqlContext.Set<Produto>().Find(codigo);
        }
    }
}
