using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ph.Domain.Entities
{
    public class Compra
    {
        public long Id { get; set; }
        public long NumeroNotaFiscal { get; set; }
        public long OrdemDeCompra { get; set; }
        public DateTime DataEntrada { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public IEnumerable<ItemProdutoCompra> ItensProduto { get; set; }

        public decimal ObterValorTotal => ItensProduto.Sum(x => x.ValorUnitario * x.Quantidade);

    }

}
