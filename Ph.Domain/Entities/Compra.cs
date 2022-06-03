using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ph.Domain.Entities
{
    public class Compra
    {
        public Compra()
        {
            ItensProduto = new List<ItemProdutoCompra>();
        }
        public long Id { get; set; }
        public long NumeroNotaFiscal { get; set; }
        public long OrdemDeCompra { get; set; }
        public DateTime DataEntrada { get; set; }
        public Fornecedor Fornecedor { get; protected set; }
        public IEnumerable<ItemProdutoCompra> ItensProduto { get; protected set; }

        public decimal ValorTotal => ItensProduto.Sum(x => x.ValorUnitario * x.Quantidade);

        public void AtribuirFornecedor(Fornecedor fornecedor)
        {
            Fornecedor = fornecedor;
        }

        public bool ContemPeloMenosUmItemProduto => ItensProduto.Any();

        public void RemoverTodosItensDeProduto()
        {
            ItensProduto = new List<ItemProdutoCompra>();
        }

        public void AtribuirItensProdutos(List<ItemProdutoCompra> itensProduto)
        {
            this.ItensProduto = itensProduto;
        }
    }

}
