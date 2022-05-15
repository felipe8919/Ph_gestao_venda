using Ph.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ph.Domain.Entities
{
    public class Venda
    {
        public long Id { get; set; }
        public double DescontoPercentual { get; set; }
        public double DescontoValor { get; set; }
        public TipoFormaPagamento TipoFormaPagamento { get; set; }
        public IEnumerable<ItemProdutoVenda> ItensProduto { get; set; }
        public Cliente Cliente { get; set; }
        public decimal ObterValorTotal => ItensProduto.Sum(x => x.ValorUnitario * x.Quantidade);
    }
}
