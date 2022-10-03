using System;
using System.ComponentModel.DataAnnotations;

namespace DesafioAPI.Domain.Entity
{
    public class Produto
    {

        [Key]
        public int Codigo { get; set; }

        [Required]
        public string Descricao { get; set; }

        public bool Situacao { get; set; }

        public DateTime Fabricacao { get; set; }

        public DateTime Validade { get; set; }

        public int CodigoFornecedor { get; set; }

        public string DescricaoFornecedor { get; set; }

        public string CnpjFornecedor { get; set; }

        public bool validaProduto(Produto produto)
        {
            return produto.Fabricacao > produto.Validade;
        }

        public void atualizaProduto(Produto produto)
        {
            if(produto.Situacao == true)
            {
                produto.Situacao = false;
            }
            else
            {
                produto.Situacao = true;
            }
        }
    }
}
